using iTextSharp.text;
using iTextSharp.text.pdf;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class CreateWarehouseReceiptForm : Form
    {
        private BUS.WarehouseReceiptBUS warehouseReceiptBUS;
        private BUS.WarehouseReceiptDetailBUS warehouseReceiptDetailBUS;
        private BUS.ProductBUS productBUS;
        private DataTable currProductTable;
        private int btnType = 0;
        // btnType = 1 -> Add button
        // btnType = 2 -> Edit button

        public CreateWarehouseReceiptForm()
        {
            InitializeComponent();
        }

        private void CreateWarehouseReceipt_Load(object sender, EventArgs e)
        {
            List<string> countryList = GetCountryList();
            foreach (string country in countryList)
            {
                ProductOriginCB.Items.Add(country);
            }

            warehouseReceiptBUS = new BUS.WarehouseReceiptBUS("", "", DateTime.Now, false, 0);
            warehouseReceiptDetailBUS = new BUS.WarehouseReceiptDetailBUS("", "", 0);
            productBUS = new BUS.ProductBUS("", "", "", "", "", "", 0, false, 0);
            ReceiptGrd.DataSource = warehouseReceiptBUS.SelectWarehouseReceiptQuery();

            CreateNewCurrProductTable();
            ShowGRD();
            Formload();
        }

        private void CreateNewCurrProductTable()
        {
            currProductTable = new DataTable();
            DataColumn productIDCol = new DataColumn("ID");
            DataColumn productNameCol = new DataColumn("Name");
            DataColumn productSizeCol = new DataColumn("Size");
            DataColumn productUnitSizeCol = new DataColumn("Unit Size");
            DataColumn productBarndCol = new DataColumn("Brand");
            DataColumn productOriginCol = new DataColumn("Origin");
            DataColumn productQualityCol = new DataColumn("Quality");
            DataColumn productPriceCol = new DataColumn("Price");
            currProductTable.Columns.Add(productIDCol);
            currProductTable.Columns.Add(productNameCol);
            currProductTable.Columns.Add(productSizeCol);
            currProductTable.Columns.Add(productUnitSizeCol);
            currProductTable.Columns.Add(productBarndCol);
            currProductTable.Columns.Add(productOriginCol);
            currProductTable.Columns.Add(productQualityCol);
            currProductTable.Columns.Add(productPriceCol);
        }

        private List<string> GetCountryList()
        {
            List<string> countryList = new List<string>();
            CultureInfo[] getCultureInfo = CultureInfo.GetCultures(CultureTypes.SpecificCultures);
            foreach (CultureInfo getCulture in getCultureInfo)
            {
                RegionInfo getRegionInfo = new RegionInfo(getCulture.LCID);
                if (!countryList.Contains(getRegionInfo.EnglishName))
                {
                    countryList.Add(getRegionInfo.EnglishName);
                }
            }
            countryList.Sort();
            return countryList;
        }

        public void EnableGRP(bool b, GroupBox grp)
        {
            grp.Enabled = b;
        }

        public void ShowGRD()
        {
            // ProductGrd.DataSource = productBUS.SelectProductQuery();
            ProductGrd.DataSource = currProductTable;
        }

        public void Formload()
        {
            EnableGRP(false, productInfoGroup);
            AddProductBtn.Enabled = true;
            DeleteProductBtn.Enabled = false;
            EditProductBtn.Enabled = false;
            SaveProductBtn.Enabled = false;

            ProductIDTxt.Clear();
            ProductNameTxt.Clear();
            ProductSizeTxt.Clear();
            ProductBrandTxt.Clear();
            ProductOriginCB.ResetText();
            ProductQuanNumInput.Value = 0;
            ProductPriceNumInput.Value = 0;
        }

        private void AddProductBtn_Click(object sender, EventArgs e)
        {
            btnType = 1;
            EnableGRP(true, productInfoGroup);

            // Reset input
            ProductIDTxt.Clear();
            ProductNameTxt.Clear();
            ProductSizeTxt.Clear();
            ProductBrandTxt.Clear();
            ProductOriginCB.ResetText();
            ProductQuanNumInput.Value = 0;
            ProductPriceNumInput.Value = 0;

            // Generate new product ID automatically
            ProductIDTxt.Text = productBUS.GetNewProductID();
            ProductIDTxt.Enabled = false; 
            
            ProductNameTxt.Focus();

            // Disable unnecessary buttons
            DeleteProductBtn.Enabled = false;
            EditProductBtn.Enabled = false;
            SaveProductBtn.Enabled = true;
        }

        private void EditProductBtn_Click(object sender, EventArgs e)
        {
            btnType = 2;
            EnableGRP(true, productInfoGroup);
            ProductIDTxt.Enabled = false;
            ProductNameTxt.Focus();
            AddProductBtn.Enabled = false;
            SaveProductBtn.Enabled = true;
        }

        private void DeleteProductBtn_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("This delete action cannot undo!", "Warning", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                if (ProductIDTxt == null || ProductIDTxt.Text.Equals(""))
                {
                    MessageBox.Show("An error occurred", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                DataRow foundRow = currProductTable.Select("ID='" + ProductIDTxt.Text + "'").FirstOrDefault();
                if (foundRow != null)
                {
                    foundRow.Delete();
                    currProductTable.AcceptChanges();
                }

                productBUS = new BUS.ProductBUS(ProductIDTxt.Text, "", "", "", "", "", 0, false, 0);
                productBUS.DeleteProductQuery();

                ShowGRD();
                Formload();
            }
        }

        private void SaveProductBtn_Click(object sender, EventArgs e)
        {
            string productName = ProductNameTxt.Text;
            string productSize = ProductSizeTxt.Text;
            string productUnitSize = ProductUnitSizeCB.SelectedItem != null ? ProductUnitSizeCB.SelectedItem.ToString() : "";
            string productBrand = ProductBrandTxt.Text;
            string productOrigin = ProductOriginCB.SelectedItem != null ? ProductOriginCB.SelectedItem.ToString() : "";
            int productQuan = (int)ProductQuanNumInput.Value;
            decimal productPrice = ProductPriceNumInput.Value;

            if (productName.Equals(""))
            {
                MessageBox.Show("Please enter a product name", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (productSize.Equals(""))
            {
                MessageBox.Show("Please enter a product size", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (productUnitSize.Equals(""))
            {
                MessageBox.Show("Please choose an unit size", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (productBrand.Equals(""))
            {
                MessageBox.Show("Please enter a product brand", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (productOrigin.Equals(""))
            {
                MessageBox.Show("Please choose a product origin", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (btnType == 1)
            {
                string productID = productBUS.GetNewProductID();
                DataRow newRow = currProductTable.NewRow();
                newRow["ID"] = productID;
                newRow["Name"] = productName;
                newRow["Size"] = productSize;
                newRow["Unit Size"] = productUnitSize;
                newRow["Brand"] = productBrand;
                newRow["Origin"] = productOrigin;
                newRow["Quality"] = productQuan;
                newRow["Price"] = productPrice;
                currProductTable.Rows.Add(newRow);
                productBUS = new BUS.ProductBUS(productID, ProductNameTxt.Text, ProductSizeTxt.Text, productUnitSize, ProductBrandTxt.Text, productOrigin, productQuan, false, productPrice);
                productBUS.AddProductQuery();
            }
            else if (btnType == 2)
            {
                if (ProductIDTxt == null || ProductIDTxt.Text.Equals(""))
                {
                    MessageBox.Show("An error occurred", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Find all rows with needed product ID and modify the proper row
                DataRow foundRow = currProductTable.Select("ID='" + ProductIDTxt.Text + "'").FirstOrDefault(); 
                if (foundRow != null)
                {
                    foundRow["Name"] = productName;
                    foundRow["Size"] = productSize;
                    foundRow["Unit Size"] = productUnitSize;
                    foundRow["Brand"] = productBrand;
                    foundRow["Origin"] = productOrigin;
                    foundRow["Quality"] = productQuan;
                    foundRow["Price"] = productPrice;
                }
                productBUS = new BUS.ProductBUS(ProductIDTxt.Text, ProductNameTxt.Text, ProductSizeTxt.Text, productUnitSize, ProductBrandTxt.Text, productOrigin, productQuan, false, productPrice);
                productBUS.UpdateProductQuery();
            }

            ShowGRD();
            Formload();
        }

        private void ProductGrd_Click(object sender, EventArgs e)
        {
            if (ProductGrd.CurrentRow == null)
            {
                return;
            }
            ProductIDTxt.Text = ProductGrd.CurrentRow.Cells[0].Value.ToString();
            ProductNameTxt.Text = ProductGrd.CurrentRow.Cells[1].Value.ToString();
            ProductSizeTxt.Text = ProductGrd.CurrentRow.Cells[2].Value.ToString();
            ProductUnitSizeCB.Text = ProductGrd.CurrentRow.Cells[3].Value.ToString();
            ProductBrandTxt.Text = ProductGrd.CurrentRow.Cells[4].Value.ToString();
            ProductOriginCB.Text = ProductGrd.CurrentRow.Cells[5].Value.ToString();
            ProductQuanNumInput.Value = Convert.ToInt32(ProductGrd.CurrentRow.Cells[6].Value.ToString());
            ProductPriceNumInput.Value = Convert.ToDecimal(ProductGrd.CurrentRow.Cells[7].Value.ToString());

            EnableGRP(false, productInfoGroup);
            AddProductBtn.Enabled = false;
            DeleteProductBtn.Enabled = true;
            EditProductBtn.Enabled = true;
            SaveProductBtn.Enabled = false;
        }

        private void CreateWarehouseReceiptBtn_Click(object sender, EventArgs e)
        {
            if (currProductTable.Rows.Count > 0)
            {
                // Get Warehouse receipt ID
                string warehouseReceiptID = warehouseReceiptBUS.GetNewWarehouseReceiptID();
                string staffID = GlobalVariable.UserID;

                // Insert new row to WarehouseReceipt table
                DateTime createdDate = DateTime.Now;
                warehouseReceiptBUS = new BUS.WarehouseReceiptBUS(warehouseReceiptID, staffID, createdDate, false, 0);
                warehouseReceiptBUS.AddWarehouseReceiptQuery();

                // Insert new rows to WarehouseReceiptDetail table
                foreach (DataGridViewRow row in ProductGrd.Rows)
                {
                    if (row.Cells[0].Value == null)
                    {
                        continue;
                    }
                    string productID = row.Cells[0].Value.ToString();
                    int productQuanNum = Convert.ToInt32(row.Cells[6].Value.ToString());
                    warehouseReceiptDetailBUS = new BUS.WarehouseReceiptDetailBUS(warehouseReceiptID, productID, productQuanNum);
                    warehouseReceiptDetailBUS.AddWarehouseReceiptDetailQuery();
                }

                ReceiptGrd.DataSource = warehouseReceiptBUS.SelectWarehouseReceiptQuery();

                // Print pdf file
                SaveFileDialog sfd = new SaveFileDialog();
                sfd.Filter = "PDF (*.pdf)|*.pdf";
                sfd.FileName = "Warehouse Receipt_" + warehouseReceiptID + ".pdf";
                bool fileError = false;
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    if (File.Exists(sfd.FileName))
                    {
                        try
                        {
                            File.Delete(sfd.FileName);
                        }
                        catch (IOException ex)
                        {
                            fileError = true;
                            MessageBox.Show("It wasn't possible to write the data to the disk." + ex.Message);
                        }
                    }
                    if (!fileError)
                    {
                        try
                        {
                            PdfPTable pdfTable = new PdfPTable(currProductTable.Columns.Count);
                            pdfTable.DefaultCell.Padding = 3;
                            pdfTable.WidthPercentage = 100;
                            pdfTable.HorizontalAlignment = Element.ALIGN_LEFT;
                            foreach (DataColumn column in currProductTable.Columns)
                            {
                                PdfPCell cell = new PdfPCell(new Phrase(column.ColumnName));
                                pdfTable.AddCell(cell);
                            }

                            for (int i = 0; i < currProductTable.Rows.Count; ++i)
                            {
                                for (int j = 0; j < currProductTable.Columns.Count; ++j)
                                {
                                    if (j != 3)
                                    {
                                        pdfTable.AddCell(currProductTable.Rows[i][j].ToString());
                                    }
                                    else
                                    {
                                        string date = currProductTable.Rows[i][j].ToString();
                                        pdfTable.AddCell(date.Split(' ')[0]);
                                    }

                                }
                            }
                            using (FileStream stream = new FileStream(sfd.FileName, FileMode.Create))
                            {
                                Document pdfDoc = new Document(PageSize.A4, 10f, 20f, 20f, 10f);
                                pdfDoc.AddTitle("Warehouse Receipt");
                                PdfWriter writerInstance = PdfWriter.GetInstance(pdfDoc, stream);
                                pdfDoc.Open();

                                PdfContentByte content = writerInstance.DirectContent;
                                BaseFont bf = BaseFont.CreateFont(BaseFont.TIMES_ROMAN, BaseFont.CP1252, BaseFont.NOT_EMBEDDED);
                                content.SetFontAndSize(bf, 8);
                                content.BeginText();
                                string text = "Long & Tien Co., Ltd";
                                content.ShowTextAlignedKerned(1, text, 100, 100, 0);
                                content.EndText();

                                content.BeginText();
                                text = "Receipt ID: " + warehouseReceiptID;
                                content.ShowTextAlignedKerned(1, text, 100, 200, 0);
                                content.EndText();

                                content.BeginText();
                                text = "Staff ID: " + staffID;
                                content.ShowTextAlignedKerned(1, text, 100, 300, 0);
                                content.EndText();

                                content.BeginText();
                                text = "Date created: " + createdDate;
                                content.ShowTextAlignedKerned(1, text, 100, 400, 0);
                                content.EndText();

                                pdfDoc.Add(pdfTable);
                                pdfDoc.Close();
                                stream.Close();
                            }

                            MessageBox.Show("Create new receipt successfully !!!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            CreateNewCurrProductTable();
                            ProductGrd.DataSource = currProductTable;
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
        }

        private void CancelBtn_Click(object sender, EventArgs e)
        {
            Formload();
        }
    }
}
