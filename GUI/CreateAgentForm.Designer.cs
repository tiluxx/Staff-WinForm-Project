
namespace GUI
{
    partial class CreateAgentForm
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
            this.AgentInfoGroup = new System.Windows.Forms.GroupBox();
            this.AgentAddressTxt = new System.Windows.Forms.TextBox();
            this.AgentEmailTxt = new System.Windows.Forms.TextBox();
            this.AgentPhoneNumTxt = new System.Windows.Forms.TextBox();
            this.AgentNameTxt = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.AgentIDTxt = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.CancelBtn = new System.Windows.Forms.Button();
            this.SaveBtn = new System.Windows.Forms.Button();
            this.EditBtn = new System.Windows.Forms.Button();
            this.AddBtn = new System.Windows.Forms.Button();
            this.AccountInfoGroup = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.AccountPasswordTxt = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.AccountUserNameTxt = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.AgentGrd = new System.Windows.Forms.DataGridView();
            this.AccountActivationCB = new System.Windows.Forms.ComboBox();
            this.AgentInfoGroup.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.AccountInfoGroup.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AgentGrd)).BeginInit();
            this.SuspendLayout();
            // 
            // AgentInfoGroup
            // 
            this.AgentInfoGroup.Controls.Add(this.AgentAddressTxt);
            this.AgentInfoGroup.Controls.Add(this.AgentEmailTxt);
            this.AgentInfoGroup.Controls.Add(this.AgentPhoneNumTxt);
            this.AgentInfoGroup.Controls.Add(this.AgentNameTxt);
            this.AgentInfoGroup.Controls.Add(this.label5);
            this.AgentInfoGroup.Controls.Add(this.label4);
            this.AgentInfoGroup.Controls.Add(this.label3);
            this.AgentInfoGroup.Controls.Add(this.label2);
            this.AgentInfoGroup.Controls.Add(this.label1);
            this.AgentInfoGroup.Controls.Add(this.AgentIDTxt);
            this.AgentInfoGroup.Location = new System.Drawing.Point(12, 12);
            this.AgentInfoGroup.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.AgentInfoGroup.Name = "AgentInfoGroup";
            this.AgentInfoGroup.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.AgentInfoGroup.Size = new System.Drawing.Size(621, 111);
            this.AgentInfoGroup.TabIndex = 0;
            this.AgentInfoGroup.TabStop = false;
            this.AgentInfoGroup.Text = "Agent information";
            // 
            // AgentAddressTxt
            // 
            this.AgentAddressTxt.Location = new System.Drawing.Point(112, 78);
            this.AgentAddressTxt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.AgentAddressTxt.Name = "AgentAddressTxt";
            this.AgentAddressTxt.Size = new System.Drawing.Size(495, 22);
            this.AgentAddressTxt.TabIndex = 9;
            // 
            // AgentEmailTxt
            // 
            this.AgentEmailTxt.Location = new System.Drawing.Point(420, 49);
            this.AgentEmailTxt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.AgentEmailTxt.Name = "AgentEmailTxt";
            this.AgentEmailTxt.Size = new System.Drawing.Size(185, 22);
            this.AgentEmailTxt.TabIndex = 8;
            // 
            // AgentPhoneNumTxt
            // 
            this.AgentPhoneNumTxt.Location = new System.Drawing.Point(420, 21);
            this.AgentPhoneNumTxt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.AgentPhoneNumTxt.Name = "AgentPhoneNumTxt";
            this.AgentPhoneNumTxt.Size = new System.Drawing.Size(185, 22);
            this.AgentPhoneNumTxt.TabIndex = 7;
            // 
            // AgentNameTxt
            // 
            this.AgentNameTxt.Location = new System.Drawing.Point(112, 49);
            this.AgentNameTxt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.AgentNameTxt.Name = "AgentNameTxt";
            this.AgentNameTxt.Size = new System.Drawing.Size(185, 22);
            this.AgentNameTxt.TabIndex = 6;
            this.AgentNameTxt.TextChanged += new System.EventHandler(this.AgentNameTxt_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(5, 80);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 17);
            this.label5.TabIndex = 5;
            this.label5.Text = "Agent address";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(313, 21);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(101, 17);
            this.label4.TabIndex = 4;
            this.label4.Text = "Phone number";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(313, 52);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 17);
            this.label3.TabIndex = 3;
            this.label3.Text = "Email";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(5, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Agent name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(5, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Agent ID";
            // 
            // AgentIDTxt
            // 
            this.AgentIDTxt.Location = new System.Drawing.Point(112, 21);
            this.AgentIDTxt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.AgentIDTxt.Name = "AgentIDTxt";
            this.AgentIDTxt.Size = new System.Drawing.Size(185, 22);
            this.AgentIDTxt.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.CancelBtn);
            this.groupBox2.Controls.Add(this.SaveBtn);
            this.groupBox2.Controls.Add(this.EditBtn);
            this.groupBox2.Controls.Add(this.AddBtn);
            this.groupBox2.Location = new System.Drawing.Point(12, 128);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Size = new System.Drawing.Size(1050, 58);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Functions";
            // 
            // CancelBtn
            // 
            this.CancelBtn.Location = new System.Drawing.Point(476, 21);
            this.CancelBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.CancelBtn.Name = "CancelBtn";
            this.CancelBtn.Size = new System.Drawing.Size(116, 31);
            this.CancelBtn.TabIndex = 4;
            this.CancelBtn.Text = "Cancel";
            this.CancelBtn.UseVisualStyleBackColor = true;
            this.CancelBtn.Click += new System.EventHandler(this.CancelBtn_Click);
            // 
            // SaveBtn
            // 
            this.SaveBtn.Location = new System.Drawing.Point(354, 21);
            this.SaveBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.SaveBtn.Name = "SaveBtn";
            this.SaveBtn.Size = new System.Drawing.Size(116, 31);
            this.SaveBtn.TabIndex = 3;
            this.SaveBtn.Text = "Save";
            this.SaveBtn.UseVisualStyleBackColor = true;
            this.SaveBtn.Click += new System.EventHandler(this.SaveBtn_Click);
            // 
            // EditBtn
            // 
            this.EditBtn.Location = new System.Drawing.Point(232, 21);
            this.EditBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.EditBtn.Name = "EditBtn";
            this.EditBtn.Size = new System.Drawing.Size(116, 31);
            this.EditBtn.TabIndex = 1;
            this.EditBtn.Text = "Edit";
            this.EditBtn.UseVisualStyleBackColor = true;
            this.EditBtn.Click += new System.EventHandler(this.EditBtn_Click);
            // 
            // AddBtn
            // 
            this.AddBtn.Location = new System.Drawing.Point(109, 21);
            this.AddBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.AddBtn.Name = "AddBtn";
            this.AddBtn.Size = new System.Drawing.Size(116, 31);
            this.AddBtn.TabIndex = 0;
            this.AddBtn.Text = "Add";
            this.AddBtn.UseVisualStyleBackColor = true;
            this.AddBtn.Click += new System.EventHandler(this.AddBtn_Click);
            // 
            // AccountInfoGroup
            // 
            this.AccountInfoGroup.Controls.Add(this.AccountActivationCB);
            this.AccountInfoGroup.Controls.Add(this.label8);
            this.AccountInfoGroup.Controls.Add(this.AccountPasswordTxt);
            this.AccountInfoGroup.Controls.Add(this.label6);
            this.AccountInfoGroup.Controls.Add(this.AccountUserNameTxt);
            this.AccountInfoGroup.Controls.Add(this.label7);
            this.AccountInfoGroup.Location = new System.Drawing.Point(639, 12);
            this.AccountInfoGroup.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.AccountInfoGroup.Name = "AccountInfoGroup";
            this.AccountInfoGroup.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.AccountInfoGroup.Size = new System.Drawing.Size(423, 111);
            this.AccountInfoGroup.TabIndex = 6;
            this.AccountInfoGroup.TabStop = false;
            this.AccountInfoGroup.Text = "Account information";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(5, 82);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(69, 17);
            this.label8.TabIndex = 14;
            this.label8.Text = "Activation";
            // 
            // AccountPasswordTxt
            // 
            this.AccountPasswordTxt.Location = new System.Drawing.Point(85, 47);
            this.AccountPasswordTxt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.AccountPasswordTxt.Name = "AccountPasswordTxt";
            this.AccountPasswordTxt.Size = new System.Drawing.Size(321, 22);
            this.AccountPasswordTxt.TabIndex = 13;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(5, 52);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(69, 17);
            this.label6.TabIndex = 12;
            this.label6.Text = "Password";
            // 
            // AccountUserNameTxt
            // 
            this.AccountUserNameTxt.Location = new System.Drawing.Point(85, 18);
            this.AccountUserNameTxt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.AccountUserNameTxt.Name = "AccountUserNameTxt";
            this.AccountUserNameTxt.Size = new System.Drawing.Size(321, 22);
            this.AccountUserNameTxt.TabIndex = 10;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(5, 25);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(73, 17);
            this.label7.TabIndex = 11;
            this.label7.Text = "Username";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.AgentGrd);
            this.groupBox4.Location = new System.Drawing.Point(12, 191);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox4.Size = new System.Drawing.Size(1050, 287);
            this.groupBox4.TabIndex = 7;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Agent list";
            // 
            // AgentGrd
            // 
            this.AgentGrd.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.AgentGrd.Location = new System.Drawing.Point(5, 21);
            this.AgentGrd.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.AgentGrd.Name = "AgentGrd";
            this.AgentGrd.RowHeadersWidth = 51;
            this.AgentGrd.RowTemplate.Height = 24;
            this.AgentGrd.Size = new System.Drawing.Size(1039, 260);
            this.AgentGrd.TabIndex = 0;
            this.AgentGrd.Click += new System.EventHandler(this.AgentGrd_Click);
            // 
            // AccountActivationCB
            // 
            this.AccountActivationCB.FormattingEnabled = true;
            this.AccountActivationCB.Items.AddRange(new object[] {
            "Activated",
            "Inactivated"});
            this.AccountActivationCB.Location = new System.Drawing.Point(85, 74);
            this.AccountActivationCB.Name = "AccountActivationCB";
            this.AccountActivationCB.Size = new System.Drawing.Size(321, 24);
            this.AccountActivationCB.TabIndex = 5;
            // 
            // CreateAgentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1075, 490);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.AccountInfoGroup);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.AgentInfoGroup);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "CreateAgentForm";
            this.Text = "Create Agent Form";
            this.Load += new System.EventHandler(this.CreateAgentForm_Load);
            this.AgentInfoGroup.ResumeLayout(false);
            this.AgentInfoGroup.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.AccountInfoGroup.ResumeLayout(false);
            this.AccountInfoGroup.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.AgentGrd)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox AgentInfoGroup;
        private System.Windows.Forms.TextBox AgentPhoneNumTxt;
        private System.Windows.Forms.TextBox AgentNameTxt;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox AgentIDTxt;
        private System.Windows.Forms.TextBox AgentAddressTxt;
        private System.Windows.Forms.TextBox AgentEmailTxt;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button CancelBtn;
        private System.Windows.Forms.Button SaveBtn;
        private System.Windows.Forms.Button EditBtn;
        private System.Windows.Forms.Button AddBtn;
        private System.Windows.Forms.GroupBox AccountInfoGroup;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.DataGridView AgentGrd;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox AccountPasswordTxt;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox AccountUserNameTxt;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox AccountActivationCB;
    }
}