namespace GUI
{
    partial class CreateDeliverySlipForm
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
            this.OrderInforGroup = new System.Windows.Forms.GroupBox();
            this.PaymentDateTxt = new System.Windows.Forms.TextBox();
            this.PaymentStatusCB = new System.Windows.Forms.ComboBox();
            this.OrderStatusCB = new System.Windows.Forms.ComboBox();
            this.TotalBillTxt = new System.Windows.Forms.TextBox();
            this.OrderDateTxt = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.AgentIDtxt = new System.Windows.Forms.TextBox();
            this.OrderIDtxt = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.CreateDeliverySlipBtn = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.OrderListGRD = new System.Windows.Forms.DataGridView();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.ProductGrd = new System.Windows.Forms.DataGridView();
            this.PaymentMethodCB = new System.Windows.Forms.ComboBox();
            this.OrderInforGroup.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.OrderListGRD)).BeginInit();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ProductGrd)).BeginInit();
            this.SuspendLayout();
            // 
            // OrderInforGroup
            // 
            this.OrderInforGroup.Controls.Add(this.PaymentMethodCB);
            this.OrderInforGroup.Controls.Add(this.PaymentDateTxt);
            this.OrderInforGroup.Controls.Add(this.PaymentStatusCB);
            this.OrderInforGroup.Controls.Add(this.OrderStatusCB);
            this.OrderInforGroup.Controls.Add(this.TotalBillTxt);
            this.OrderInforGroup.Controls.Add(this.OrderDateTxt);
            this.OrderInforGroup.Controls.Add(this.label8);
            this.OrderInforGroup.Controls.Add(this.label7);
            this.OrderInforGroup.Controls.Add(this.label6);
            this.OrderInforGroup.Controls.Add(this.label2);
            this.OrderInforGroup.Controls.Add(this.label1);
            this.OrderInforGroup.Controls.Add(this.label5);
            this.OrderInforGroup.Controls.Add(this.label4);
            this.OrderInforGroup.Controls.Add(this.label3);
            this.OrderInforGroup.Controls.Add(this.AgentIDtxt);
            this.OrderInforGroup.Controls.Add(this.OrderIDtxt);
            this.OrderInforGroup.Location = new System.Drawing.Point(13, 13);
            this.OrderInforGroup.Margin = new System.Windows.Forms.Padding(4);
            this.OrderInforGroup.Name = "OrderInforGroup";
            this.OrderInforGroup.Padding = new System.Windows.Forms.Padding(4);
            this.OrderInforGroup.Size = new System.Drawing.Size(1110, 97);
            this.OrderInforGroup.TabIndex = 0;
            this.OrderInforGroup.TabStop = false;
            this.OrderInforGroup.Text = "Order information";
            // 
            // PaymentDateTxt
            // 
            this.PaymentDateTxt.Location = new System.Drawing.Point(914, 20);
            this.PaymentDateTxt.Margin = new System.Windows.Forms.Padding(4);
            this.PaymentDateTxt.Name = "PaymentDateTxt";
            this.PaymentDateTxt.Size = new System.Drawing.Size(182, 22);
            this.PaymentDateTxt.TabIndex = 25;
            // 
            // PaymentStatusCB
            // 
            this.PaymentStatusCB.FormattingEnabled = true;
            this.PaymentStatusCB.Items.AddRange(new object[] {
            "Awaiting Payment",
            "Payment Received",
            "Payment Updated",
            "Completed",
            "Cancelled",
            "Failed"});
            this.PaymentStatusCB.Location = new System.Drawing.Point(622, 53);
            this.PaymentStatusCB.Name = "PaymentStatusCB";
            this.PaymentStatusCB.Size = new System.Drawing.Size(163, 24);
            this.PaymentStatusCB.TabIndex = 24;
            // 
            // OrderStatusCB
            // 
            this.OrderStatusCB.FormattingEnabled = true;
            this.OrderStatusCB.Items.AddRange(new object[] {
            "Processing Stock",
            "Ready for Packing",
            "Ready to Deliver",
            "Delivery In Progress",
            "Delivered",
            "Received",
            "Not Delivered"});
            this.OrderStatusCB.Location = new System.Drawing.Point(622, 20);
            this.OrderStatusCB.Name = "OrderStatusCB";
            this.OrderStatusCB.Size = new System.Drawing.Size(163, 24);
            this.OrderStatusCB.TabIndex = 23;
            // 
            // TotalBillTxt
            // 
            this.TotalBillTxt.Location = new System.Drawing.Point(320, 50);
            this.TotalBillTxt.Margin = new System.Windows.Forms.Padding(4);
            this.TotalBillTxt.Name = "TotalBillTxt";
            this.TotalBillTxt.Size = new System.Drawing.Size(182, 22);
            this.TotalBillTxt.TabIndex = 22;
            // 
            // OrderDateTxt
            // 
            this.OrderDateTxt.Location = new System.Drawing.Point(320, 19);
            this.OrderDateTxt.Margin = new System.Windows.Forms.Padding(4);
            this.OrderDateTxt.Name = "OrderDateTxt";
            this.OrderDateTxt.Size = new System.Drawing.Size(182, 22);
            this.OrderDateTxt.TabIndex = 21;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(792, 53);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(114, 17);
            this.label8.TabIndex = 20;
            this.label8.Text = "Payment method";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(792, 22);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(95, 17);
            this.label7.TabIndex = 19;
            this.label7.Text = "Payment date";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(510, 53);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(105, 17);
            this.label6.TabIndex = 18;
            this.label6.Text = "Payment status";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(510, 23);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 17);
            this.label2.TabIndex = 17;
            this.label2.Text = "Order status";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(235, 23);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 17);
            this.label1.TabIndex = 16;
            this.label1.Text = "Order date";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(235, 53);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 17);
            this.label5.TabIndex = 15;
            this.label5.Text = "Total bill";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(8, 56);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 17);
            this.label4.TabIndex = 8;
            this.label4.Text = "Agent ID";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 26);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 17);
            this.label3.TabIndex = 7;
            this.label3.Text = "Order ID";
            // 
            // AgentIDtxt
            // 
            this.AgentIDtxt.Location = new System.Drawing.Point(78, 53);
            this.AgentIDtxt.Margin = new System.Windows.Forms.Padding(4);
            this.AgentIDtxt.Name = "AgentIDtxt";
            this.AgentIDtxt.Size = new System.Drawing.Size(149, 22);
            this.AgentIDtxt.TabIndex = 4;
            // 
            // OrderIDtxt
            // 
            this.OrderIDtxt.Location = new System.Drawing.Point(78, 23);
            this.OrderIDtxt.Margin = new System.Windows.Forms.Padding(4);
            this.OrderIDtxt.Name = "OrderIDtxt";
            this.OrderIDtxt.Size = new System.Drawing.Size(149, 22);
            this.OrderIDtxt.TabIndex = 1;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.CreateDeliverySlipBtn);
            this.groupBox2.Location = new System.Drawing.Point(13, 118);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox2.Size = new System.Drawing.Size(1110, 54);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Function";
            // 
            // CreateDeliverySlipBtn
            // 
            this.CreateDeliverySlipBtn.Location = new System.Drawing.Point(427, 16);
            this.CreateDeliverySlipBtn.Margin = new System.Windows.Forms.Padding(4);
            this.CreateDeliverySlipBtn.Name = "CreateDeliverySlipBtn";
            this.CreateDeliverySlipBtn.Size = new System.Drawing.Size(265, 30);
            this.CreateDeliverySlipBtn.TabIndex = 4;
            this.CreateDeliverySlipBtn.Text = "Create Delivery Slip";
            this.CreateDeliverySlipBtn.UseVisualStyleBackColor = true;
            this.CreateDeliverySlipBtn.Click += new System.EventHandler(this.CreateDeliverySlipBtn_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.OrderListGRD);
            this.groupBox3.Location = new System.Drawing.Point(13, 180);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox3.Size = new System.Drawing.Size(557, 357);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Order list";
            // 
            // OrderListGRD
            // 
            this.OrderListGRD.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.OrderListGRD.Location = new System.Drawing.Point(9, 23);
            this.OrderListGRD.Margin = new System.Windows.Forms.Padding(4);
            this.OrderListGRD.Name = "OrderListGRD";
            this.OrderListGRD.RowHeadersWidth = 51;
            this.OrderListGRD.Size = new System.Drawing.Size(540, 326);
            this.OrderListGRD.TabIndex = 0;
            this.OrderListGRD.Click += new System.EventHandler(this.OrderListGRD_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.ProductGrd);
            this.groupBox4.Location = new System.Drawing.Point(578, 180);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox4.Size = new System.Drawing.Size(545, 357);
            this.groupBox4.TabIndex = 3;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Product list";
            // 
            // ProductGrd
            // 
            this.ProductGrd.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ProductGrd.Location = new System.Drawing.Point(9, 23);
            this.ProductGrd.Margin = new System.Windows.Forms.Padding(4);
            this.ProductGrd.Name = "ProductGrd";
            this.ProductGrd.RowHeadersWidth = 51;
            this.ProductGrd.Size = new System.Drawing.Size(522, 326);
            this.ProductGrd.TabIndex = 0;
            // 
            // PaymentMethodCB
            // 
            this.PaymentMethodCB.FormattingEnabled = true;
            this.PaymentMethodCB.Items.AddRange(new object[] {
            "Cash",
            "iBanking",
            "Digital wallet"});
            this.PaymentMethodCB.Location = new System.Drawing.Point(913, 50);
            this.PaymentMethodCB.Name = "PaymentMethodCB";
            this.PaymentMethodCB.Size = new System.Drawing.Size(182, 24);
            this.PaymentMethodCB.TabIndex = 26;
            // 
            // CreateDeliverySlipForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1140, 545);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.OrderInforGroup);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "CreateDeliverySlipForm";
            this.Text = "Create Delivery Slip Form";
            this.Load += new System.EventHandler(this.CreateDeliverySlip_Load);
            this.OrderInforGroup.ResumeLayout(false);
            this.OrderInforGroup.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.OrderListGRD)).EndInit();
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ProductGrd)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox OrderInforGroup;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button CreateDeliverySlipBtn;
        private System.Windows.Forms.DataGridView OrderListGRD;
        private System.Windows.Forms.TextBox AgentIDtxt;
        private System.Windows.Forms.TextBox OrderIDtxt;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox PaymentDateTxt;
        private System.Windows.Forms.ComboBox PaymentStatusCB;
        private System.Windows.Forms.ComboBox OrderStatusCB;
        private System.Windows.Forms.TextBox TotalBillTxt;
        private System.Windows.Forms.TextBox OrderDateTxt;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.DataGridView ProductGrd;
        private System.Windows.Forms.ComboBox PaymentMethodCB;
    }
}