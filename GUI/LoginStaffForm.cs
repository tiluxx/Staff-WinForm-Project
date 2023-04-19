using BUS;
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
    public partial class LoginStaffForm : Form
    {
        private BUS.ProductBUS productBUS;

        public LoginStaffForm()
        {
            InitializeComponent();
        }

        private void LoginStaffForm_Load(object sender, EventArgs e)
        {
            productBUS = new BUS.ProductBUS("", "", "", "", "", "", 0, false, 0);
        }

        private void LoginBtn_Click(object sender, EventArgs e)
        {
            string username = UsernameTxt.Text;
            string password = PasswordTxt.Text;

            if (username == null || username == "")
            {
                MessageBox.Show("Please enter your username", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (password == null || password == "")
            {
                MessageBox.Show("Please enter your password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (username == "admin" && password == "123456")
            {
                MessageBox.Show("Login successfully!");
                GlobalVariable.UserID = username;
                MainForm formMain = new MainForm();
                formMain.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Invalid account", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void CancelBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
