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
        private BUS.StaffAccountBUS staffAccountBUS;

        public LoginStaffForm()
        {
            InitializeComponent();
        }

        private void LoginStaffForm_Load(object sender, EventArgs e)
        {
            staffAccountBUS = new BUS.StaffAccountBUS("", "", "", false, false);
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

            List<String> res = staffAccountBUS.CheckStaffLogin(username, password);
            if (!res[1].Equals(""))
            {
                MessageBox.Show("Login successfully!");
                GlobalVariable.UserID = res[1];
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
