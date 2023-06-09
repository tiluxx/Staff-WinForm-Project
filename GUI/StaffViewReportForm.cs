﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class StaffViewReportForm : Form
    {
        private BUS.WarehouseReceiptBUS warehouseReceiptBUS;

        public StaffViewReportForm()
        {
            InitializeComponent();
        }

        private void StaffViewReportForm_Load(object sender, EventArgs e)
        {
            warehouseReceiptBUS = new BUS.WarehouseReceiptBUS("", "", DateTime.Now, false, 0);

            // Get all month
            DateTimeFormatInfo dateTimeFormat = new DateTimeFormatInfo();
            for (int i = 1; i <= 12; i++)
            {
                MonthOptionCB.Items.Add(dateTimeFormat.GetMonthName(i));
            }

            // Get all year
            int currYear = DateTime.Now.Year;
            for (int i = currYear; i >= 1900; i--)
            {
                YearOptionCB.Items.Add(i.ToString());
            }
        }

        private int GetActualMonthNumber(string monthName)
        {
            switch (monthName) {
                case "January":
                    return 1;
                case "February":
                    return 2;
                case "March":
                    return 3;
                case "April":
                    return 4;
                case "May":
                    return 5;
                case "June":
                    return 6;
                case "July":
                    return 7;
                case "August":
                    return 8;
                case "September":
                    return 9;
                case "October":
                    return 10;
                case "November ":
                    return 11;
                case "December":
                    return 12;
                default:
                    return 12;
            }
        }

        private void viewReportBtn_Click(object sender, EventArgs e)
        {
            if (RevenueMonthlyReportOption.Checked)
            {
                ReportGrd.DataSource = warehouseReceiptBUS.GetRevenueMonthly();
                return;
            }

            if (MonthOptionCB.SelectedItem == null)
            {
                MessageBox.Show("Please choose a month to view report", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            int selectedMonth = GetActualMonthNumber(MonthOptionCB.SelectedItem.ToString());
            int selectedYear = Convert.ToInt32(YearOptionCB.SelectedItem.ToString());
            DataTable res = new DataTable();
            
            if (GoodsImportReportOption.Checked)
            {
                res = warehouseReceiptBUS.GetImportProductByMonth(selectedMonth, selectedYear);
            }
            else if (GoodsExportReportOption.Checked)
            {
                res = warehouseReceiptBUS.GetExportProductByMonth(selectedMonth, selectedYear);
            }
            else if (BestSellingProductReportOption.Checked)
            {
                res = warehouseReceiptBUS.GetBestSellingProduct(selectedMonth, selectedYear);
            }
            else if (RevenueByMonthReportOption.Checked)
            {
                res = warehouseReceiptBUS.GetRevenueByMonth(selectedMonth, selectedYear);
            }

            ReportGrd.DataSource = res;
        }

        private void RevenueMonthlyReportOption_CheckedChanged(object sender, EventArgs e)
        {
            if (RevenueMonthlyReportOption.Checked)
            {
                MonthOptionCB.Enabled = false;
                YearOptionCB.Enabled = false;
            }
        }

        private void GoodsImportReportOption_CheckedChanged(object sender, EventArgs e)
        {
            if (GoodsImportReportOption.Checked)
            {
                MonthOptionCB.Enabled = true;
                YearOptionCB.Enabled = true;
            }
        }

        private void GoodsExportReportOption_CheckedChanged(object sender, EventArgs e)
        {
            if (GoodsExportReportOption.Checked)
            {
                MonthOptionCB.Enabled = true;
                YearOptionCB.Enabled = true;
            }
        }

        private void BestSellingProductReportOption_CheckedChanged(object sender, EventArgs e)
        {
            if (BestSellingProductReportOption.Checked)
            {
                MonthOptionCB.Enabled = true;
                YearOptionCB.Enabled = true;
            }
        }

        private void RevenueByMonthReportOption_CheckedChanged(object sender, EventArgs e)
        {
            if (RevenueByMonthReportOption.Checked)
            {
                MonthOptionCB.Enabled = true;
                YearOptionCB.Enabled = true;
            }
        }
    }
}
