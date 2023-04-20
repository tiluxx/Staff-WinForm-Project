
namespace GUI
{
    partial class CreateWarehouseReceiptForm
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
            this.ProductGrd = new System.Windows.Forms.DataGridView();
            this.ProductOriginCB = new System.Windows.Forms.ComboBox();
            this.ProductUnitSizeCB = new System.Windows.Forms.ComboBox();
            this.ProductPriceNumInput = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.ProductQuanNumInput = new System.Windows.Forms.NumericUpDown();
            this.ProductBrandTxt = new System.Windows.Forms.TextBox();
            this.ProductSizeTxt = new System.Windows.Forms.TextBox();
            this.ProductIDTxt = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.AddProductBtn = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.CreateWarehouseReceiptBtn = new System.Windows.Forms.Button();
            this.CancelBtn = new System.Windows.Forms.Button();
            this.SaveProductBtn = new System.Windows.Forms.Button();
            this.DeleteProductBtn = new System.Windows.Forms.Button();
            this.EditProductBtn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.productNameLbl = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.productInfoGroup = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.ProductNameTxt = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.ReceiptGrd = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.ProductGrd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ProductPriceNumInput)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ProductQuanNumInput)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.productInfoGroup.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ReceiptGrd)).BeginInit();
            this.SuspendLayout();
            // 
            // ProductGrd
            // 
            this.ProductGrd.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ProductGrd.Location = new System.Drawing.Point(4, 17);
            this.ProductGrd.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ProductGrd.Name = "ProductGrd";
            this.ProductGrd.RowHeadersWidth = 51;
            this.ProductGrd.RowTemplate.Height = 24;
            this.ProductGrd.Size = new System.Drawing.Size(380, 199);
            this.ProductGrd.TabIndex = 0;
            this.ProductGrd.Click += new System.EventHandler(this.ProductGrd_Click);
            // 
            // ProductOriginCB
            // 
            this.ProductOriginCB.FormattingEnabled = true;
            this.ProductOriginCB.Location = new System.Drawing.Point(496, 40);
            this.ProductOriginCB.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ProductOriginCB.Name = "ProductOriginCB";
            this.ProductOriginCB.Size = new System.Drawing.Size(78, 21);
            this.ProductOriginCB.TabIndex = 3;
            // 
            // ProductUnitSizeCB
            // 
            this.ProductUnitSizeCB.FormattingEnabled = true;
            this.ProductUnitSizeCB.Items.AddRange(new object[] {
            "m",
            "dm",
            "cm",
            "mm",
            "inches"});
            this.ProductUnitSizeCB.Location = new System.Drawing.Point(496, 17);
            this.ProductUnitSizeCB.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ProductUnitSizeCB.Name = "ProductUnitSizeCB";
            this.ProductUnitSizeCB.Size = new System.Drawing.Size(78, 21);
            this.ProductUnitSizeCB.TabIndex = 3;
            // 
            // ProductPriceNumInput
            // 
            this.ProductPriceNumInput.Increment = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.ProductPriceNumInput.Location = new System.Drawing.Point(657, 41);
            this.ProductPriceNumInput.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ProductPriceNumInput.Maximum = new decimal(new int[] {
            1410065408,
            2,
            0,
            0});
            this.ProductPriceNumInput.Name = "ProductPriceNumInput";
            this.ProductPriceNumInput.Size = new System.Drawing.Size(88, 20);
            this.ProductPriceNumInput.TabIndex = 13;
            this.ProductPriceNumInput.ThousandsSeparator = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(750, 43);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(30, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "VND";
            // 
            // ProductQuanNumInput
            // 
            this.ProductQuanNumInput.Location = new System.Drawing.Point(657, 18);
            this.ProductQuanNumInput.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ProductQuanNumInput.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.ProductQuanNumInput.Name = "ProductQuanNumInput";
            this.ProductQuanNumInput.Size = new System.Drawing.Size(121, 20);
            this.ProductQuanNumInput.TabIndex = 1;
            this.ProductQuanNumInput.ThousandsSeparator = true;
            // 
            // ProductBrandTxt
            // 
            this.ProductBrandTxt.Location = new System.Drawing.Point(350, 40);
            this.ProductBrandTxt.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ProductBrandTxt.Name = "ProductBrandTxt";
            this.ProductBrandTxt.Size = new System.Drawing.Size(142, 20);
            this.ProductBrandTxt.TabIndex = 8;
            // 
            // ProductSizeTxt
            // 
            this.ProductSizeTxt.Location = new System.Drawing.Point(350, 17);
            this.ProductSizeTxt.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ProductSizeTxt.Name = "ProductSizeTxt";
            this.ProductSizeTxt.Size = new System.Drawing.Size(142, 20);
            this.ProductSizeTxt.TabIndex = 7;
            // 
            // ProductIDTxt
            // 
            this.ProductIDTxt.Location = new System.Drawing.Point(82, 17);
            this.ProductIDTxt.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ProductIDTxt.Name = "ProductIDTxt";
            this.ProductIDTxt.Size = new System.Drawing.Size(156, 20);
            this.ProductIDTxt.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(280, 42);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Brand";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(607, 20);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Quantity";
            // 
            // AddProductBtn
            // 
            this.AddProductBtn.Location = new System.Drawing.Point(82, 17);
            this.AddProductBtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.AddProductBtn.Name = "AddProductBtn";
            this.AddProductBtn.Size = new System.Drawing.Size(87, 25);
            this.AddProductBtn.TabIndex = 0;
            this.AddProductBtn.Text = "Add product";
            this.AddProductBtn.UseVisualStyleBackColor = true;
            this.AddProductBtn.Click += new System.EventHandler(this.AddProductBtn_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(607, 43);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Price";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.CreateWarehouseReceiptBtn);
            this.groupBox1.Controls.Add(this.CancelBtn);
            this.groupBox1.Controls.Add(this.SaveProductBtn);
            this.groupBox1.Controls.Add(this.DeleteProductBtn);
            this.groupBox1.Controls.Add(this.EditProductBtn);
            this.groupBox1.Controls.Add(this.AddProductBtn);
            this.groupBox1.Location = new System.Drawing.Point(9, 83);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Size = new System.Drawing.Size(782, 47);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Product functions";
            // 
            // CreateWarehouseReceiptBtn
            // 
            this.CreateWarehouseReceiptBtn.Location = new System.Drawing.Point(540, 17);
            this.CreateWarehouseReceiptBtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.CreateWarehouseReceiptBtn.Name = "CreateWarehouseReceiptBtn";
            this.CreateWarehouseReceiptBtn.Size = new System.Drawing.Size(87, 25);
            this.CreateWarehouseReceiptBtn.TabIndex = 5;
            this.CreateWarehouseReceiptBtn.Text = "Create receipt";
            this.CreateWarehouseReceiptBtn.UseVisualStyleBackColor = true;
            this.CreateWarehouseReceiptBtn.Click += new System.EventHandler(this.CreateWarehouseReceiptBtn_Click);
            // 
            // CancelBtn
            // 
            this.CancelBtn.Location = new System.Drawing.Point(448, 17);
            this.CancelBtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.CancelBtn.Name = "CancelBtn";
            this.CancelBtn.Size = new System.Drawing.Size(87, 25);
            this.CancelBtn.TabIndex = 4;
            this.CancelBtn.Text = "Cancel";
            this.CancelBtn.UseVisualStyleBackColor = true;
            this.CancelBtn.Click += new System.EventHandler(this.CancelBtn_Click);
            // 
            // SaveProductBtn
            // 
            this.SaveProductBtn.Location = new System.Drawing.Point(357, 17);
            this.SaveProductBtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.SaveProductBtn.Name = "SaveProductBtn";
            this.SaveProductBtn.Size = new System.Drawing.Size(87, 25);
            this.SaveProductBtn.TabIndex = 3;
            this.SaveProductBtn.Text = "Save product";
            this.SaveProductBtn.UseVisualStyleBackColor = true;
            this.SaveProductBtn.Click += new System.EventHandler(this.SaveProductBtn_Click);
            // 
            // DeleteProductBtn
            // 
            this.DeleteProductBtn.Location = new System.Drawing.Point(266, 17);
            this.DeleteProductBtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.DeleteProductBtn.Name = "DeleteProductBtn";
            this.DeleteProductBtn.Size = new System.Drawing.Size(87, 25);
            this.DeleteProductBtn.TabIndex = 2;
            this.DeleteProductBtn.Text = "Delete product";
            this.DeleteProductBtn.UseVisualStyleBackColor = true;
            this.DeleteProductBtn.Click += new System.EventHandler(this.DeleteProductBtn_Click);
            // 
            // EditProductBtn
            // 
            this.EditProductBtn.Location = new System.Drawing.Point(174, 17);
            this.EditProductBtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.EditProductBtn.Name = "EditProductBtn";
            this.EditProductBtn.Size = new System.Drawing.Size(87, 25);
            this.EditProductBtn.TabIndex = 1;
            this.EditProductBtn.Text = "Edit product";
            this.EditProductBtn.UseVisualStyleBackColor = true;
            this.EditProductBtn.Click += new System.EventHandler(this.EditProductBtn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(403, 41);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Origin";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(280, 20);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Product Size";
            // 
            // productNameLbl
            // 
            this.productNameLbl.AutoSize = true;
            this.productNameLbl.Location = new System.Drawing.Point(4, 20);
            this.productNameLbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.productNameLbl.Name = "productNameLbl";
            this.productNameLbl.Size = new System.Drawing.Size(58, 13);
            this.productNameLbl.TabIndex = 0;
            this.productNameLbl.Text = "Product ID";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.ProductGrd);
            this.groupBox2.Location = new System.Drawing.Point(9, 135);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox2.Size = new System.Drawing.Size(388, 221);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Product list";
            // 
            // productInfoGroup
            // 
            this.productInfoGroup.Controls.Add(this.label7);
            this.productInfoGroup.Controls.Add(this.ProductNameTxt);
            this.productInfoGroup.Controls.Add(this.ProductOriginCB);
            this.productInfoGroup.Controls.Add(this.ProductUnitSizeCB);
            this.productInfoGroup.Controls.Add(this.ProductPriceNumInput);
            this.productInfoGroup.Controls.Add(this.label6);
            this.productInfoGroup.Controls.Add(this.ProductQuanNumInput);
            this.productInfoGroup.Controls.Add(this.ProductBrandTxt);
            this.productInfoGroup.Controls.Add(this.ProductSizeTxt);
            this.productInfoGroup.Controls.Add(this.ProductIDTxt);
            this.productInfoGroup.Controls.Add(this.label5);
            this.productInfoGroup.Controls.Add(this.label4);
            this.productInfoGroup.Controls.Add(this.label3);
            this.productInfoGroup.Controls.Add(this.label2);
            this.productInfoGroup.Controls.Add(this.label1);
            this.productInfoGroup.Controls.Add(this.productNameLbl);
            this.productInfoGroup.Location = new System.Drawing.Point(9, 10);
            this.productInfoGroup.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.productInfoGroup.Name = "productInfoGroup";
            this.productInfoGroup.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.productInfoGroup.Size = new System.Drawing.Size(782, 68);
            this.productInfoGroup.TabIndex = 3;
            this.productInfoGroup.TabStop = false;
            this.productInfoGroup.Text = "Product information";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(4, 40);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(75, 13);
            this.label7.TabIndex = 15;
            this.label7.Text = "Product Name";
            // 
            // ProductNameTxt
            // 
            this.ProductNameTxt.Location = new System.Drawing.Point(82, 40);
            this.ProductNameTxt.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ProductNameTxt.Name = "ProductNameTxt";
            this.ProductNameTxt.Size = new System.Drawing.Size(156, 20);
            this.ProductNameTxt.TabIndex = 14;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.ReceiptGrd);
            this.groupBox3.Location = new System.Drawing.Point(402, 135);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox3.Size = new System.Drawing.Size(392, 221);
            this.groupBox3.TabIndex = 6;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Warehouse receipt list";
            // 
            // ReceiptGrd
            // 
            this.ReceiptGrd.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ReceiptGrd.Location = new System.Drawing.Point(4, 17);
            this.ReceiptGrd.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ReceiptGrd.Name = "ReceiptGrd";
            this.ReceiptGrd.RowHeadersWidth = 51;
            this.ReceiptGrd.RowTemplate.Height = 24;
            this.ReceiptGrd.Size = new System.Drawing.Size(382, 199);
            this.ReceiptGrd.TabIndex = 0;
            // 
            // CreateWarehouseReceipt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(802, 366);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.productInfoGroup);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "CreateWarehouseReceipt";
            this.Text = "Create Warehouse Receipt";
            this.Load += new System.EventHandler(this.CreateWarehouseReceipt_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ProductGrd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ProductPriceNumInput)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ProductQuanNumInput)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.productInfoGroup.ResumeLayout(false);
            this.productInfoGroup.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ReceiptGrd)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView ProductGrd;
        private System.Windows.Forms.ComboBox ProductOriginCB;
        private System.Windows.Forms.ComboBox ProductUnitSizeCB;
        private System.Windows.Forms.NumericUpDown ProductPriceNumInput;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown ProductQuanNumInput;
        private System.Windows.Forms.TextBox ProductBrandTxt;
        private System.Windows.Forms.TextBox ProductSizeTxt;
        private System.Windows.Forms.TextBox ProductIDTxt;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button AddProductBtn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label productNameLbl;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox productInfoGroup;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox ProductNameTxt;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView ReceiptGrd;
        private System.Windows.Forms.Button DeleteProductBtn;
        private System.Windows.Forms.Button EditProductBtn;
        private System.Windows.Forms.Button CreateWarehouseReceiptBtn;
        private System.Windows.Forms.Button CancelBtn;
        private System.Windows.Forms.Button SaveProductBtn;
    }
}