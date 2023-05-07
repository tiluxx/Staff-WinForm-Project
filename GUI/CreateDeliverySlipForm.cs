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
        private DataTable currOrderProductList;
        private string currOrderStatus;
        private string currPaymentStatus;

        public CreateDeliverySlipForm()
        {
            InitializeComponent();
        }

        private void CreateDeliverySlip_Load(object sender, EventArgs e)
        {
            deliverySlipBUS = new BUS.DeliverySlipBUS("", "", DateTime.Now, false, 0);
            orderBUS = new BUS.OrderBUS("", "", "", "", "", false, 0, DateTime.Now, DateTime.Now);
            OrderListGRD.DataSource = orderBUS.SelectOrderQuery();

            // Disable sensitive input
            OrderIDtxt.Enabled = false;
            AgentIDTxt.Enabled = false;
            OrderDateTxt.Enabled = false;
            TotalBillInput.Enabled = false;
            PaymentDateTxt.Enabled = false;
            PaymentMethodCB.Enabled = false;
            OrderStatusCB.Enabled = false;
            PaymentStatusCB.Enabled = false;
            PaymentMethodCB.Enabled = false;

            OrderListGRD.DataSource = orderBUS.SelectOrderQuery();
        }

        public void ShowGRD()
        {
            OrderListGRD.DataSource = orderBUS.SelectOrderQuery();
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

                            MessageBox.Show("Create Delivery Slip Successfully!", "Info");
                            ProductGrd.Refresh();
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
        }

        private void OrderListGRD_Click(object sender, EventArgs e)
        {
            DataGridViewRow currentRow = OrderListGRD.CurrentRow;

            // Get product list of current order
            string orderID = currentRow.Cells[0].Value.ToString();
            orderDetailBUS = new BUS.OrderDetailBUS(orderID, "", 0);
            currOrderProductList = orderDetailBUS.GetOrderProductByOrderID();
            ProductGrd.DataSource = currOrderProductList;

            // Get information of current order
            OrderIDtxt.Text = currentRow.Cells[0].Value.ToString();
            OrderDateTxt.Text = currentRow.Cells[1].Value.ToString();
            AgentIDTxt.Text = currentRow.Cells[2].Value.ToString();
            OrderStatusCB.Text = currentRow.Cells[3].Value.ToString();
            PaymentStatusCB.Text = currentRow.Cells[4].Value.ToString();
            PaymentDateTxt.Text = currentRow.Cells[5].Value.ToString();
            PaymentMethodCB.Text = currentRow.Cells[7].Value.ToString();
            TotalBillInput.Value = Convert.ToDecimal(currentRow.Cells[8].Value.ToString());

            // Update current state of order and payment status
            currOrderStatus = currentRow.Cells[3].Value.ToString();
            currPaymentStatus = currentRow.Cells[4].Value.ToString();

            // Enable update action input
            OrderStatusCB.Enabled = true;
            PaymentStatusCB.Enabled = true;
            PaymentMethodCB.Enabled = true;
        }

        private void UpdateStatusBtn_Click(object sender, EventArgs e)
        {
            if (OrderIDtxt == null || OrderIDtxt.Text.Equals(""))
            {
                MessageBox.Show("Please choose an order to update", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string orderStatus = OrderStatusCB.SelectedItem.ToString();
            string paymentStatus = PaymentStatusCB.SelectedItem.ToString();
            string orderID = OrderIDtxt.Text;


            if (!currOrderStatus.Equals(orderStatus))
            {
                orderBUS = new BUS.OrderBUS(orderID, "", orderStatus, "", "", false, 0, DateTime.Now, DateTime.Now);
                orderBUS.UpdateOrderStatusQuery();

                if (orderStatus.Equals("Delivery In Progress"))
                {
                    string newDeliverySlipID = deliverySlipBUS.GetNewDeliverySlipID();
                    deliverySlipBUS = new BUS.DeliverySlipBUS(newDeliverySlipID, orderID, DateTime.Now, false, 0);
                    deliverySlipBUS.AddDeliverySlipQuery();
                }
            }

            if (!currPaymentStatus.Equals(paymentStatus))
            {
                orderBUS = new BUS.OrderBUS(orderID, "", "", paymentStatus, "", false, 0, DateTime.Now, DateTime.Now);

                if (paymentStatus.Equals("Payment Received") || paymentStatus.Equals("Completed"))
                {
                    orderBUS.UpdateOrderPaymentStatusQuery(true);
                }
                else
                {
                    orderBUS.UpdateOrderPaymentStatusQuery(false);
                }
            }
            
            ShowGRD();
        }
    }
}
