
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
            this.revenueMonthlyReportOption = new System.Windows.Forms.RadioButton();
            this.bestSellingProductReportOption = new System.Windows.Forms.RadioButton();
            this.goodsExportReportOption = new System.Windows.Forms.RadioButton();
            this.goodsImportReportOption = new System.Windows.Forms.RadioButton();
            this.staffReportViewer = new Microsoft.Reporting.WinForms.ReportViewer();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.monthOptionCB = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.viewReportBtn = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.revenueMonthlyReportOption);
            this.groupBox1.Controls.Add(this.bestSellingProductReportOption);
            this.groupBox1.Controls.Add(this.goodsExportReportOption);
            this.groupBox1.Controls.Add(this.goodsImportReportOption);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(776, 84);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Report options";
            // 
            // revenueMonthlyReportOption
            // 
            this.revenueMonthlyReportOption.AutoSize = true;
            this.revenueMonthlyReportOption.Location = new System.Drawing.Point(227, 48);
            this.revenueMonthlyReportOption.Name = "revenueMonthlyReportOption";
            this.revenueMonthlyReportOption.Size = new System.Drawing.Size(128, 21);
            this.revenueMonthlyReportOption.TabIndex = 3;
            this.revenueMonthlyReportOption.TabStop = true;
            this.revenueMonthlyReportOption.Text = "Revenue report";
            this.revenueMonthlyReportOption.UseVisualStyleBackColor = true;
            // 
            // bestSellingProductReportOption
            // 
            this.bestSellingProductReportOption.AutoSize = true;
            this.bestSellingProductReportOption.Location = new System.Drawing.Point(227, 21);
            this.bestSellingProductReportOption.Name = "bestSellingProductReportOption";
            this.bestSellingProductReportOption.Size = new System.Drawing.Size(196, 21);
            this.bestSellingProductReportOption.TabIndex = 2;
            this.bestSellingProductReportOption.TabStop = true;
            this.bestSellingProductReportOption.Text = "Best-selling product report";
            this.bestSellingProductReportOption.UseVisualStyleBackColor = true;
            // 
            // goodsExportReportOption
            // 
            this.goodsExportReportOption.AutoSize = true;
            this.goodsExportReportOption.Location = new System.Drawing.Point(6, 48);
            this.goodsExportReportOption.Name = "goodsExportReportOption";
            this.goodsExportReportOption.Size = new System.Drawing.Size(166, 21);
            this.goodsExportReportOption.TabIndex = 1;
            this.goodsExportReportOption.TabStop = true;
            this.goodsExportReportOption.Text = "Outgoing stock report";
            this.goodsExportReportOption.UseVisualStyleBackColor = true;
            // 
            // goodsImportReportOption
            // 
            this.goodsImportReportOption.AutoSize = true;
            this.goodsImportReportOption.Location = new System.Drawing.Point(6, 21);
            this.goodsImportReportOption.Name = "goodsImportReportOption";
            this.goodsImportReportOption.Size = new System.Drawing.Size(164, 21);
            this.goodsImportReportOption.TabIndex = 0;
            this.goodsImportReportOption.TabStop = true;
            this.goodsImportReportOption.Text = "Incoming stock report";
            this.goodsImportReportOption.UseVisualStyleBackColor = true;
            // 
            // staffReportViewer
            // 
            this.staffReportViewer.LocalReport.ReportEmbeddedResource = "GUI.IncomingStockReport.rdlc";
            this.staffReportViewer.Location = new System.Drawing.Point(12, 168);
            this.staffReportViewer.Name = "staffReportViewer";
            this.staffReportViewer.ServerReport.BearerToken = null;
            this.staffReportViewer.Size = new System.Drawing.Size(776, 329);
            this.staffReportViewer.TabIndex = 1;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.viewReportBtn);
            this.groupBox2.Controls.Add(this.monthOptionCB);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Location = new System.Drawing.Point(12, 102);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(776, 60);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Report options";
            // 
            // monthOptionCB
            // 
            this.monthOptionCB.FormattingEnabled = true;
            this.monthOptionCB.Location = new System.Drawing.Point(251, 21);
            this.monthOptionCB.Name = "monthOptionCB";
            this.monthOptionCB.Size = new System.Drawing.Size(255, 24);
            this.monthOptionCB.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(108, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(137, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Select month to view";
            // 
            // viewReportBtn
            // 
            this.viewReportBtn.Location = new System.Drawing.Point(512, 21);
            this.viewReportBtn.Name = "viewReportBtn";
            this.viewReportBtn.Size = new System.Drawing.Size(115, 24);
            this.viewReportBtn.TabIndex = 6;
            this.viewReportBtn.Text = "View report";
            this.viewReportBtn.UseVisualStyleBackColor = true;
            this.viewReportBtn.Click += new System.EventHandler(this.viewReportBtn_Click);
            // 
            // StaffViewReportForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 509);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.staffReportViewer);
            this.Controls.Add(this.groupBox1);
            this.Name = "StaffViewReportForm";
            this.Text = "View Report Form";
            this.Load += new System.EventHandler(this.StaffViewReportForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton revenueMonthlyReportOption;
        private System.Windows.Forms.RadioButton bestSellingProductReportOption;
        private System.Windows.Forms.RadioButton goodsExportReportOption;
        private System.Windows.Forms.RadioButton goodsImportReportOption;
        private Microsoft.Reporting.WinForms.ReportViewer staffReportViewer;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button viewReportBtn;
        private System.Windows.Forms.ComboBox monthOptionCB;
        private System.Windows.Forms.Label label2;
    }
}