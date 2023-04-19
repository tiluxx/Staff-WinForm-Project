
namespace GUI
{
    partial class MainForm
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
            this.NavBarMainForm = new System.Windows.Forms.MenuStrip();
            this.ProductToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.CreateWarehouseReceiptToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AgentsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AgentManagementToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.orderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.orderManagementToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewOrdersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.WindowsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.horizontalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.verticalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ReportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.StaffNameLabel = new System.Windows.Forms.Label();
            this.LogoutBtn = new System.Windows.Forms.Button();
            this.NavBarMainForm.SuspendLayout();
            this.SuspendLayout();
            // 
            // NavBarMainForm
            // 
            this.NavBarMainForm.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.NavBarMainForm.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ProductToolStripMenuItem,
            this.AgentsToolStripMenuItem,
            this.orderToolStripMenuItem,
            this.ReportToolStripMenuItem,
            this.WindowsToolStripMenuItem});
            this.NavBarMainForm.Location = new System.Drawing.Point(0, 0);
            this.NavBarMainForm.Name = "NavBarMainForm";
            this.NavBarMainForm.Padding = new System.Windows.Forms.Padding(5, 2, 0, 2);
            this.NavBarMainForm.Size = new System.Drawing.Size(800, 28);
            this.NavBarMainForm.TabIndex = 2;
            this.NavBarMainForm.Text = "menuStrip1";
            // 
            // ProductToolStripMenuItem
            // 
            this.ProductToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.CreateWarehouseReceiptToolStripMenuItem});
            this.ProductToolStripMenuItem.Name = "ProductToolStripMenuItem";
            this.ProductToolStripMenuItem.Size = new System.Drawing.Size(80, 24);
            this.ProductToolStripMenuItem.Text = "Products";
            // 
            // CreateWarehouseReceiptToolStripMenuItem
            // 
            this.CreateWarehouseReceiptToolStripMenuItem.Name = "CreateWarehouseReceiptToolStripMenuItem";
            this.CreateWarehouseReceiptToolStripMenuItem.Size = new System.Drawing.Size(266, 26);
            this.CreateWarehouseReceiptToolStripMenuItem.Text = "Create Warehouse Receipt";
            this.CreateWarehouseReceiptToolStripMenuItem.Click += new System.EventHandler(this.CreateWarehouseReceiptToolStripMenuItem_Click);
            // 
            // AgentsToolStripMenuItem
            // 
            this.AgentsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AgentManagementToolStripMenuItem});
            this.AgentsToolStripMenuItem.Name = "AgentsToolStripMenuItem";
            this.AgentsToolStripMenuItem.Size = new System.Drawing.Size(69, 24);
            this.AgentsToolStripMenuItem.Text = "Agents";
            // 
            // AgentManagementToolStripMenuItem
            // 
            this.AgentManagementToolStripMenuItem.Name = "AgentManagementToolStripMenuItem";
            this.AgentManagementToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.AgentManagementToolStripMenuItem.Text = "Agent Management";
            this.AgentManagementToolStripMenuItem.Click += new System.EventHandler(this.AgentManagementToolStripMenuItem_Click);
            // 
            // orderToolStripMenuItem
            // 
            this.orderToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.orderManagementToolStripMenuItem,
            this.viewOrdersToolStripMenuItem});
            this.orderToolStripMenuItem.Name = "orderToolStripMenuItem";
            this.orderToolStripMenuItem.Size = new System.Drawing.Size(61, 24);
            this.orderToolStripMenuItem.Text = "Order";
            // 
            // orderManagementToolStripMenuItem
            // 
            this.orderManagementToolStripMenuItem.Name = "orderManagementToolStripMenuItem";
            this.orderManagementToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.orderManagementToolStripMenuItem.Text = "Order Management";
            this.orderManagementToolStripMenuItem.Click += new System.EventHandler(this.OrderManagementToolStripMenuItem_Click);
            // 
            // viewOrdersToolStripMenuItem
            // 
            this.viewOrdersToolStripMenuItem.Name = "viewOrdersToolStripMenuItem";
            this.viewOrdersToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.viewOrdersToolStripMenuItem.Text = "Orders View ";
            this.viewOrdersToolStripMenuItem.Click += new System.EventHandler(this.ViewOrdersToolStripMenuItem_Click);
            // 
            // WindowsToolStripMenuItem
            // 
            this.WindowsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.horizontalToolStripMenuItem,
            this.verticalToolStripMenuItem});
            this.WindowsToolStripMenuItem.Name = "WindowsToolStripMenuItem";
            this.WindowsToolStripMenuItem.Size = new System.Drawing.Size(84, 24);
            this.WindowsToolStripMenuItem.Text = "Windows";
            // 
            // horizontalToolStripMenuItem
            // 
            this.horizontalToolStripMenuItem.Name = "horizontalToolStripMenuItem";
            this.horizontalToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.horizontalToolStripMenuItem.Text = "Horizontal";
            this.horizontalToolStripMenuItem.Click += new System.EventHandler(this.HorizontalToolStripMenuItem_Click);
            // 
            // verticalToolStripMenuItem
            // 
            this.verticalToolStripMenuItem.Name = "verticalToolStripMenuItem";
            this.verticalToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.verticalToolStripMenuItem.Text = "Vertical";
            this.verticalToolStripMenuItem.Click += new System.EventHandler(this.VerticalToolStripMenuItem_Click);
            // 
            // ReportToolStripMenuItem
            // 
            this.ReportToolStripMenuItem.Name = "ReportToolStripMenuItem";
            this.ReportToolStripMenuItem.Size = new System.Drawing.Size(68, 24);
            this.ReportToolStripMenuItem.Text = "Report";
            this.ReportToolStripMenuItem.Click += new System.EventHandler(this.ReportToolStripMenuItem_Click);
            // 
            // StaffNameLabel
            // 
            this.StaffNameLabel.AutoSize = true;
            this.StaffNameLabel.BackColor = System.Drawing.SystemColors.Window;
            this.StaffNameLabel.Location = new System.Drawing.Point(621, 6);
            this.StaffNameLabel.Name = "StaffNameLabel";
            this.StaffNameLabel.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.StaffNameLabel.Size = new System.Drawing.Size(86, 17);
            this.StaffNameLabel.TabIndex = 4;
            this.StaffNameLabel.Text = "Staff\'s name";
            this.StaffNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // LogoutBtn
            // 
            this.LogoutBtn.Location = new System.Drawing.Point(713, 3);
            this.LogoutBtn.Name = "LogoutBtn";
            this.LogoutBtn.Size = new System.Drawing.Size(75, 23);
            this.LogoutBtn.TabIndex = 5;
            this.LogoutBtn.Text = "Logout";
            this.LogoutBtn.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.LogoutBtn);
            this.Controls.Add(this.StaffNameLabel);
            this.Controls.Add(this.NavBarMainForm);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.NavBarMainForm;
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.NavBarMainForm.ResumeLayout(false);
            this.NavBarMainForm.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip NavBarMainForm;
        private System.Windows.Forms.ToolStripMenuItem ProductToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem CreateWarehouseReceiptToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem AgentsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem AgentManagementToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem orderToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem orderManagementToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewOrdersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem WindowsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem horizontalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem verticalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ReportToolStripMenuItem;
        private System.Windows.Forms.Label StaffNameLabel;
        private System.Windows.Forms.Button LogoutBtn;
    }
}