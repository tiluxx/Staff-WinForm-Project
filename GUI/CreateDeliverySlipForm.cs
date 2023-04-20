using BUS;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Printing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace GUI
{
    public partial class CreateDeliverySlipForm : Form
    {
        private BUS.DeliverySlipBUS deliverySlipBUS;
        private BUS.OrderBUS orderBUS;
        private BUS.OrderDetailBUS orderDetailBUS;
        private BUS.ProductBUS productBUS;
        private DataTable currOrderProductList;

        public CreateDeliverySlipForm()
        {
            InitializeComponent();
        }

        private void CreateDeliverySlip_Load(object sender, EventArgs e)
        {
            deliverySlipBUS = new BUS.DeliverySlipBUS("", "", DateTime.Now, false, 0);
            orderBUS = new BUS.OrderBUS("", "", "", "", "", false, 0, DateTime.Now, DateTime.Now);
            productBUS = new BUS.ProductBUS("", "", "", "", "", "", 0, false, 0);
            OrderListGRD.DataSource = orderBUS.SelectOrderQuery();
            OrderInforGroup.Enabled = false;
            OrderStatusCB.Enabled = true;
            PaymentStatusCB.Enabled = true;
            PaymentMethodCB.Enabled = true;
        }

        public void ShowGRD()
        {
            OrderListGRD.DataSource = deliverySlipBUS.SelectDeliverySlipQuery();
        }

        private void CreateDeliverySlipBtn_Click(object sender, EventArgs e)
        {
            if (currOrderProductList == null || currOrderProductList.Rows.Count < 1)
            {
                MessageBox.Show("Please choose an order to create", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (currOrderProductList.Rows.Count > 0)
            {
                SaveFileDialog sfd = new SaveFileDialog
                {
                    Filter = "PDF (*.pdf)|*.pdf",
                    FileName = "Delivery Slip_" + OrderListGRD.CurrentRow.Cells[0].Value.ToString() + ".pdf"
                };
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
                            PdfPTable pdfTable = new PdfPTable(currOrderProductList.Columns.Count);
                            pdfTable.DefaultCell.Padding = 3;
                            pdfTable.WidthPercentage = 100;
                            pdfTable.HorizontalAlignment = Element.ALIGN_LEFT;
                            foreach (DataColumn column in currOrderProductList.Columns)
                            {
                                PdfPCell cell = new PdfPCell(new Phrase(column.ColumnName));
                                pdfTable.AddCell(cell);
                            }

                            for (int i = 0; i < currOrderProductList.Rows.Count; ++i)
                            {
                                for (int j = 0; j < currOrderProductList.Columns.Count; ++j)
                                {
                                    if (j != 3)
                                    {
                                        pdfTable.AddCell(currOrderProductList.Rows[i][j].ToString());
                                    }
                                    else
                                    {
                                        string date = currOrderProductList.Rows[i][j].ToString();
                                        pdfTable.AddCell(date.Split(' ')[0]);
                                    }

                                }
                            }
                            using (FileStream stream = new FileStream(sfd.FileName, FileMode.Create))
                            {
                                Document pdfDoc = new Document(PageSize.A4, 10f, 20f, 20f, 10f);
                                PdfWriter.GetInstance(pdfDoc, stream);
                                pdfDoc.Open();
                                pdfDoc.Add(pdfTable);
                                pdfDoc.Close();
                                stream.Close();
                            }

                            MessageBox.Show("Create Delivery Slip Successfully !!!", "Info");
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Error :" + ex.Message);
                        }
                    }
                }
            }
        }

        private void OrderListGRD_Click(object sender, EventArgs e)
        {
            string orderID = OrderListGRD.CurrentRow.Cells[0].Value.ToString();
            orderDetailBUS = new BUS.OrderDetailBUS(orderID, "", 0);
            currOrderProductList = orderDetailBUS.GetOrderProductByOrderID();
            ProductGrd.DataSource = currOrderProductList;
        }
    }
}
