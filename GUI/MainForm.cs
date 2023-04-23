using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            StaffNameLabel.Text = GlobalVariable.UserID != null ? GlobalVariable.UserID : "User";
        }

        private void CreateWarehouseReceiptToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CreateWarehouseReceiptForm createWarehouseReceipt = new CreateWarehouseReceiptForm
            {
                MdiParent = this
            };
            createWarehouseReceipt.Show();
        }

        private void AgentManagementToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CreateAgentForm createAgentForm = new CreateAgentForm
            {
                MdiParent = this
            };
            createAgentForm.Show();
        }

        private void ReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StaffViewReportForm staffViewReportForm = new StaffViewReportForm
            {
                MdiParent = this
            };
            staffViewReportForm.Show();
        }

        private void OrderManagementToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CreateDeliverySlipForm createDeliverySlipForm = new CreateDeliverySlipForm
            {
                MdiParent = this
            };
            createDeliverySlipForm.Show();
        }

        private void HorizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void VerticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.TileVertical);
        }

        private void createDeliverySlipToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CreateWarehouseReceiptForm createWarehouseReceipt = new CreateWarehouseReceiptForm
            {
                MdiParent = this
            };
            createWarehouseReceipt.Show();
        }
    }
}
