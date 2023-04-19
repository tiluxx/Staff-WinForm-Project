namespace GUI
{
    partial class CreateDeliverySlip
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
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.CreateDeliverySlipBtn = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.DeliverySlipGRD = new System.Windows.Forms.DataGridView();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.actionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.actionToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.actionToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.actionToolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.actionToolStripMenuItem4 = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.ProductPriceNumInput = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DeliverySlipGRD)).BeginInit();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ProductPriceNumInput)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.ProductPriceNumInput);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.textBox4);
            this.groupBox1.Controls.Add(this.textBox2);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(5, 25);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(788, 79);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "De;iverySlip Information";
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(92, 47);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(243, 20);
            this.textBox4.TabIndex = 4;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(457, 21);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(239, 20);
            this.textBox2.TabIndex = 2;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(92, 21);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(243, 20);
            this.textBox1.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Delivery Slip";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.CreateDeliverySlipBtn);
            this.groupBox2.Location = new System.Drawing.Point(4, 110);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(788, 44);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "DeliverySlip functions";
            // 
            // CreateDeliverySlipBtn
            // 
            this.CreateDeliverySlipBtn.Location = new System.Drawing.Point(288, 14);
            this.CreateDeliverySlipBtn.Name = "CreateDeliverySlipBtn";
            this.CreateDeliverySlipBtn.Size = new System.Drawing.Size(199, 24);
            this.CreateDeliverySlipBtn.TabIndex = 4;
            this.CreateDeliverySlipBtn.Text = "Create Delivery Slip";
            this.CreateDeliverySlipBtn.UseVisualStyleBackColor = true;
            this.CreateDeliverySlipBtn.Click += new System.EventHandler(this.CreateDeliverySlipBtn_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.DeliverySlipGRD);
            this.groupBox3.Location = new System.Drawing.Point(5, 154);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(786, 290);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "DeliverySlip list";
            // 
            // DeliverySlipGRD
            // 
            this.DeliverySlipGRD.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DeliverySlipGRD.Location = new System.Drawing.Point(7, 19);
            this.DeliverySlipGRD.Name = "DeliverySlipGRD";
            this.DeliverySlipGRD.Size = new System.Drawing.Size(775, 254);
            this.DeliverySlipGRD.TabIndex = 0;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.actionToolStripMenuItem,
            this.actionToolStripMenuItem1,
            this.actionToolStripMenuItem2,
            this.actionToolStripMenuItem3,
            this.actionToolStripMenuItem4});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // actionToolStripMenuItem
            // 
            this.actionToolStripMenuItem.Name = "actionToolStripMenuItem";
            this.actionToolStripMenuItem.Size = new System.Drawing.Size(54, 20);
            this.actionToolStripMenuItem.Text = "Action";
            // 
            // actionToolStripMenuItem1
            // 
            this.actionToolStripMenuItem1.Name = "actionToolStripMenuItem1";
            this.actionToolStripMenuItem1.Size = new System.Drawing.Size(54, 20);
            this.actionToolStripMenuItem1.Text = "Action";
            // 
            // actionToolStripMenuItem2
            // 
            this.actionToolStripMenuItem2.Name = "actionToolStripMenuItem2";
            this.actionToolStripMenuItem2.Size = new System.Drawing.Size(54, 20);
            this.actionToolStripMenuItem2.Text = "Action";
            // 
            // actionToolStripMenuItem3
            // 
            this.actionToolStripMenuItem3.Name = "actionToolStripMenuItem3";
            this.actionToolStripMenuItem3.Size = new System.Drawing.Size(54, 20);
            this.actionToolStripMenuItem3.Text = "Action";
            // 
            // actionToolStripMenuItem4
            // 
            this.actionToolStripMenuItem4.Name = "actionToolStripMenuItem4";
            this.actionToolStripMenuItem4.Size = new System.Drawing.Size(54, 20);
            this.actionToolStripMenuItem4.Text = "Action";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(721, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Staff\'s Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 50);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "OrderID";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(365, 24);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "DeliveryDate";
            // 
            // ProductPriceNumInput
            // 
            this.ProductPriceNumInput.Increment = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.ProductPriceNumInput.Location = new System.Drawing.Point(457, 47);
            this.ProductPriceNumInput.Margin = new System.Windows.Forms.Padding(2);
            this.ProductPriceNumInput.Maximum = new decimal(new int[] {
            1410065408,
            2,
            0,
            0});
            this.ProductPriceNumInput.Name = "ProductPriceNumInput";
            this.ProductPriceNumInput.Size = new System.Drawing.Size(239, 20);
            this.ProductPriceNumInput.TabIndex = 14;
            this.ProductPriceNumInput.ThousandsSeparator = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(365, 50);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 13);
            this.label5.TabIndex = 15;
            this.label5.Text = "TotalBill";
            // 
            // CreateDeliverySlip
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "CreateDeliverySlip";
            this.Text = "CreateDeliverySlip";
            this.Load += new System.EventHandler(this.CreateDeliverySlip_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DeliverySlipGRD)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ProductPriceNumInput)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button CreateDeliverySlipBtn;
        private System.Windows.Forms.DataGridView DeliverySlipGRD;
        private System.Windows.Forms.ToolStripMenuItem actionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem actionToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem actionToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem actionToolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem actionToolStripMenuItem4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown ProductPriceNumInput;
    }
}