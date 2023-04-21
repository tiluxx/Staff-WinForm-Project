using Microsoft.Reporting.WinForms;
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
    public partial class StaffViewReportForm : Form
    {
        public StaffViewReportForm()
        {
            InitializeComponent();
        }

        private void StaffViewReportForm_Load(object sender, EventArgs e)
        {
            this.staffReportViewer.RefreshReport();
        }

        private void viewReportBtn_Click(object sender, EventArgs e)
        {
            int reportType = -1;
            if (goodsImportReportOption.Checked)
            {
                reportType = 0;
            }
            else if (goodsExportReportOption.Checked)
            {
                reportType = 1;
            }
            else if (bestSellingProductReportOption.Checked)
            {
                reportType = 2;
            }
            else if (revenueMonthlyReportOption.Checked)
            {
                reportType = 3;
            }
        }
    }
}
