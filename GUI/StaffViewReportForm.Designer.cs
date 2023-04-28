
namespace GUI
{
    partial class StaffViewReportForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.RevenueMonthlyReportOption = new System.Windows.Forms.RadioButton();
            this.RevenueByMonthReportOption = new System.Windows.Forms.RadioButton();
            this.BestSellingProductReportOption = new System.Windows.Forms.RadioButton();
            this.GoodsExportReportOption = new System.Windows.Forms.RadioButton();
            this.GoodsImportReportOption = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.viewReportBtn = new System.Windows.Forms.Button();
            this.MonthOptionCB = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.ReportGrd = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.YearOptionCB = new System.Windows.Forms.ComboBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ReportGrd)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.RevenueMonthlyReportOption);
            this.groupBox1.Controls.Add(this.RevenueByMonthReportOption);
            this.groupBox1.Controls.Add(this.BestSellingProductReportOption);
            this.groupBox1.Controls.Add(this.GoodsExportReportOption);
            this.groupBox1.Controls.Add(this.GoodsImportReportOption);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(776, 84);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Report options";
            // 
            // RevenueMonthlyReportOption
            // 
            this.RevenueMonthlyReportOption.AutoSize = true;
            this.RevenueMonthlyReportOption.Location = new System.Drawing.Point(476, 21);
            this.RevenueMonthlyReportOption.Name = "RevenueMonthlyReportOption";
            this.RevenueMonthlyReportOption.Size = new System.Drawing.Size(181, 21);
            this.RevenueMonthlyReportOption.TabIndex = 4;
            this.RevenueMonthlyReportOption.TabStop = true;
            this.RevenueMonthlyReportOption.Text = "Revenue report monthly";
            this.RevenueMonthlyReportOption.UseVisualStyleBackColor = true;
            this.RevenueMonthlyReportOption.CheckedChanged += new System.EventHandler(this.RevenueMonthlyReportOption_CheckedChanged);
            // 
            // RevenueByMonthReportOption
            // 
            this.RevenueByMonthReportOption.AutoSize = true;
            this.RevenueByMonthReportOption.Location = new System.Drawing.Point(227, 48);
            this.RevenueByMonthReportOption.Name = "RevenueByMonthReportOption";
            this.RevenueByMonthReportOption.Size = new System.Drawing.Size(128, 21);
            this.RevenueByMonthReportOption.TabIndex = 3;
            this.RevenueByMonthReportOption.TabStop = true;
            this.RevenueByMonthReportOption.Text = "Revenue report";
            this.RevenueByMonthReportOption.UseVisualStyleBackColor = true;
            this.RevenueByMonthReportOption.CheckedChanged += new System.EventHandler(this.RevenueByMonthReportOption_CheckedChanged);
            // 
            // BestSellingProductReportOption
            // 
            this.BestSellingProductReportOption.AutoSize = true;
            this.BestSellingProductReportOption.Location = new System.Drawing.Point(227, 21);
            this.BestSellingProductReportOption.Name = "BestSellingProductReportOption";
            this.BestSellingProductReportOption.Size = new System.Drawing.Size(196, 21);
            this.BestSellingProductReportOption.TabIndex = 2;
            this.BestSellingProductReportOption.TabStop = true;
            this.BestSellingProductReportOption.Text = "Best-selling product report";
            this.BestSellingProductReportOption.UseVisualStyleBackColor = true;
            this.BestSellingProductReportOption.CheckedChanged += new System.EventHandler(this.BestSellingProductReportOption_CheckedChanged);
            // 
            // GoodsExportReportOption
            // 
            this.GoodsExportReportOption.AutoSize = true;
            this.GoodsExportReportOption.Location = new System.Drawing.Point(6, 48);
            this.GoodsExportReportOption.Name = "GoodsExportReportOption";
            this.GoodsExportReportOption.Size = new System.Drawing.Size(166, 21);
            this.GoodsExportReportOption.TabIndex = 1;
            this.GoodsExportReportOption.TabStop = true;
            this.GoodsExportReportOption.Text = "Outgoing stock report";
            this.GoodsExportReportOption.UseVisualStyleBackColor = true;
            this.GoodsExportReportOption.CheckedChanged += new System.EventHandler(this.GoodsExportReportOption_CheckedChanged);
            // 
            // GoodsImportReportOption
            // 
            this.GoodsImportReportOption.AutoSize = true;
            this.GoodsImportReportOption.Location = new System.Drawing.Point(6, 21);
            this.GoodsImportReportOption.Name = "GoodsImportReportOption";
            this.GoodsImportReportOption.Size = new System.Drawing.Size(164, 21);
            this.GoodsImportReportOption.TabIndex = 0;
            this.GoodsImportReportOption.TabStop = true;
            this.GoodsImportReportOption.Text = "Incoming stock report";
            this.GoodsImportReportOption.UseVisualStyleBackColor = true;
            this.GoodsImportReportOption.CheckedChanged += new System.EventHandler(this.GoodsImportReportOption_CheckedChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.YearOptionCB);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.viewReportBtn);
            this.groupBox2.Controls.Add(this.MonthOptionCB);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Location = new System.Drawing.Point(12, 102);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(776, 60);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Report time";
            // 
            // viewReportBtn
            // 
            this.viewReportBtn.Location = new System.Drawing.Point(627, 21);
            this.viewReportBtn.Name = "viewReportBtn";
            this.viewReportBtn.Size = new System.Drawing.Size(143, 24);
            this.viewReportBtn.TabIndex = 6;
            this.viewReportBtn.Text = "View report";
            this.viewReportBtn.UseVisualStyleBackColor = true;
            this.viewReportBtn.Click += new System.EventHandler(this.viewReportBtn_Click);
            // 
            // MonthOptionCB
            // 
            this.MonthOptionCB.FormattingEnabled = true;
            this.MonthOptionCB.Location = new System.Drawing.Point(149, 21);
            this.MonthOptionCB.Name = "MonthOptionCB";
            this.MonthOptionCB.Size = new System.Drawing.Size(162, 24);
            this.MonthOptionCB.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(137, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Select month to view";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.ReportGrd);
            this.groupBox3.Location = new System.Drawing.Point(12, 168);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(776, 329);
            this.groupBox3.TabIndex = 7;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Report";
            // 
            // ReportGrd
            // 
            this.ReportGrd.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ReportGrd.Location = new System.Drawing.Point(6, 21);
            this.ReportGrd.Name = "ReportGrd";
            this.ReportGrd.RowHeadersWidth = 51;
            this.ReportGrd.RowTemplate.Height = 24;
            this.ReportGrd.Size = new System.Drawing.Size(764, 302);
            this.ReportGrd.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(317, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 17);
            this.label1.TabIndex = 7;
            this.label1.Text = "Select year to view";
            // 
            // YearOptionCB
            // 
            this.YearOptionCB.FormattingEnabled = true;
            this.YearOptionCB.Location = new System.Drawing.Point(449, 21);
            this.YearOptionCB.Name = "YearOptionCB";
            this.YearOptionCB.Size = new System.Drawing.Size(172, 24);
            this.YearOptionCB.TabIndex = 8;
            // 
            // StaffViewReportForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 509);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "StaffViewReportForm";
            this.Text = "View Report Form";
            this.Load += new System.EventHandler(this.StaffViewReportForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ReportGrd)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton RevenueByMonthReportOption;
        private System.Windows.Forms.RadioButton BestSellingProductReportOption;
        private System.Windows.Forms.RadioButton GoodsExportReportOption;
        private System.Windows.Forms.RadioButton GoodsImportReportOption;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button viewReportBtn;
        private System.Windows.Forms.ComboBox MonthOptionCB;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView ReportGrd;
        private System.Windows.Forms.RadioButton RevenueMonthlyReportOption;
        private System.Windows.Forms.ComboBox YearOptionCB;
        private System.Windows.Forms.Label label1;
    }
}