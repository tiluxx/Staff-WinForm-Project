using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class CreateWarehouseReceipt : Form
    {
        private BUS.WarehouseReceiptBUS warehouseReceiptBUS;
        private BUS.WarehouseReceiptDetailBUS warehouseReceiptDetailBUS;
        private BUS.ProductBUS productBUS;
        private int btnType = 0;
        // btnType = 1 -> Add button
        // btnType = 2 -> Edit button

        public CreateWarehouseReceipt()
        {
            InitializeComponent();
        }

        private void CreateWarehouseReceipt_Load(object sender, EventArgs e)
        {
            warehouseReceiptBUS = new BUS.WarehouseReceiptBUS("", "", DateTime.Now, false, 0);
            warehouseReceiptDetailBUS = new BUS.WarehouseReceiptDetailBUS("", "", 0);
            productBUS = new BUS.ProductBUS("", "", "", "", "", "", 0, false, 0);
            ReceiptGrd.DataSource = warehouseReceiptBUS.SelectWarehouseReceiptQuery();
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
            ProductGrd.DataSource = warehouseReceiptBUS.SelectWarehouseReceiptQuery();
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
                warehouseReceiptBUS = new BUS.WarehouseReceiptBUS("", "", DateTime.Now, false, 0);
                warehouseReceiptBUS.AddWarehouseReceiptQuery();
                string productID = productBUS.GetNewProductID();
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

                productBUS = new BUS.ProductBUS(ProductIDTxt.Text, ProductNameTxt.Text, ProductSizeTxt.Text, productUnitSize, ProductBrandTxt.Text, productOrigin, productQuan, false, productPrice);
                productBUS.UpdateProductQuery();
            }

            ShowGRD();
            Formload();
        }

        private void ProductGrd_Click(object sender, EventArgs e)
        {
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
            // Get Warehouse receipt ID
            string warehouseReceiptID = warehouseReceiptBUS.GetNewWarehouseReceiptID();

            // Insert new row to WarehouseReceipt table
            warehouseReceiptBUS = new BUS.WarehouseReceiptBUS(warehouseReceiptID, "", DateTime.Now, false, 0);
            warehouseReceiptBUS.AddWarehouseReceiptQuery();

            // Insert new rows to WarehouseReceiptDetail table
            foreach (DataGridViewRow row in ProductGrd.Rows)
            {
                string productID = row.Cells[0].Value.ToString();
                int productQuanNum = Convert.ToInt32(row.Cells[6].Value.ToString());
                warehouseReceiptDetailBUS = new BUS.WarehouseReceiptDetailBUS(warehouseReceiptID, productID, productQuanNum);
                warehouseReceiptDetailBUS.AddWarehouseReceiptDetailQuery();
            }

            ProductGrd.Rows.Clear();
            ProductGrd.Refresh();
            ReceiptGrd.DataSource = warehouseReceiptBUS.SelectWarehouseReceiptQuery();
            MessageBox.Show("Create new receipt successfully !!!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void CancelBtn_Click(object sender, EventArgs e)
        {
            Formload();
        }
    }
}
