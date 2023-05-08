using BUS;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class CreateAgentForm : Form
    {
        private BUS.AgentBUS agentBUS;
        private BUS.AgentAccountBUS agentAccountBUS;
        private int btnType = 0;

        public CreateAgentForm()
        {
            InitializeComponent();
        }

        private void CreateAgentForm_Load(object sender, EventArgs e)
        {
            agentBUS = new BUS.AgentBUS("", "","","","", false);
            agentAccountBUS = new BUS.AgentAccountBUS("", "","", false, false);
            ShowGRD();
            Formload();
        }

        public void ShowGRD()
        {
            AgentGrd.DataSource = agentBUS.SelectAgentQuery();
        }

        public void Formload()
        {
            EnableGRP(false, AgentInfoGroup);
            EnableGRP(false, AccountInfoGroup);
            AddBtn.Enabled = true;
            EditBtn.Enabled = false;
            SaveBtn.Enabled = false;

            AgentIDTxt.Clear();
            AgentNameTxt.Clear();
            AgentPhoneNumTxt.Clear();
            AgentEmailTxt.Clear();
            AgentAddressTxt.Clear();
            AccountUserNameTxt.Clear();
            AccountPasswordTxt.Clear();
            AccountActivationCB.Text = "";
        }

        public void EnableGRP(bool b, GroupBox grp)
        {
            grp.Enabled = b;
        }

        private string GenerateAccountUsername(string agentName)
        {
            Random res = new Random();
            string str = "0123456789";
            int size = 4;

            string result = "";
            for (int i = 0; i < size; i++)
            {
                int x = res.Next(str.Length);
                result += str[x];
            }

            string agentNameStandardlized = agentName.Replace(" ", "").ToUpper();
            return agentNameStandardlized + result;
        }

        private string GenerateAccountPassword(string agentID)
        {
            Random res = new Random();
            string str = "abcdefghijklmnopqrstuvwxyz0123456789";
            int size = 5;

            string result = "";
            for (int i = 0; i < size; i++)
            {
                int x = res.Next(str.Length);
                result += str[x];
            }

            return agentID + "_" + result;
        }

        private void AddBtn_Click(object sender, EventArgs e)
        { 
            btnType = 1;
            EnableGRP(true, AgentInfoGroup);
            EnableGRP(true, AccountInfoGroup);

            // Reset input
            AgentIDTxt.Clear();
            AgentNameTxt.Clear();
            AgentPhoneNumTxt.Clear();
            AgentEmailTxt.Clear();
            AgentAddressTxt.Clear();
            AccountUserNameTxt.Clear();
            AccountPasswordTxt.Clear();
            AccountActivationCB.Text = "";

            // Generate new agent ID automatically
            string newAgentID = agentBUS.GetNewAgentID();
            AgentIDTxt.Text = newAgentID;
            AgentIDTxt.Enabled = false;
            AccountPasswordTxt.Text = GenerateAccountPassword(newAgentID);
            AccountActivationCB.SelectedItem = "Activated";

            // Disable unnecessary buttons
            EditBtn.Enabled = false;
            SaveBtn.Enabled = true;
        }

        private void EditBtn_Click(object sender, EventArgs e)
        {
            btnType = 2;
            EnableGRP(true, AgentInfoGroup);
            EnableGRP(true, AccountInfoGroup);

            AgentIDTxt.Enabled = false;
            AccountUserNameTxt.Enabled = false;
            AccountPasswordTxt.Enabled = false;
            AgentNameTxt.Focus();
            AddBtn.Enabled = false;
            SaveBtn.Enabled = true;
        }

        private void SaveBtn_Click(object sender, EventArgs e)
        {
            string agentID = AgentIDTxt.Text;
            string agentName = AgentNameTxt.Text;
            string agentEmail = AgentEmailTxt.Text;
            string agentPhoneNum = AgentPhoneNumTxt.Text;
            string agentAdress = AgentAddressTxt.Text;
            bool isActivated = AccountActivationCB.SelectedItem.ToString() == "Activated";

            if (agentID.Equals(""))
            {
                MessageBox.Show("An error orcurred", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (agentName.Equals(""))
            {
                MessageBox.Show("Please enter an agent name", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (agentEmail.Equals(""))
            {
                MessageBox.Show("Please enter an agent email", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (agentPhoneNum.Equals(""))
            {
                MessageBox.Show("Please enter an agent phone number", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (agentAdress.Equals(""))
            {
                MessageBox.Show("Please enter an agent address", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (btnType == 1)
            {
                string newAgentID = agentBUS.GetNewAgentID();
                agentBUS = new BUS.AgentBUS(newAgentID, agentName, agentEmail, agentPhoneNum, agentAdress, false);
                agentBUS.AddAgentQuery();

                agentAccountBUS = new BUS.AgentAccountBUS(newAgentID, AccountUserNameTxt.Text, AccountPasswordTxt.Text, isActivated, false);
                agentAccountBUS.AddAgentAcQuery();

                string distributorEmail = "lethanhtienhqv@gmail.com";

                MailMessage createAccountMail = new MailMessage();
                createAccountMail.To.Add(agentEmail);
                createAccountMail.From = new MailAddress(distributorEmail);
                createAccountMail.Subject = "Your Agent Account";
                createAccountMail.Body = "Dear Customer,<br /><br />This is your agent account to access our distributor system: <br />Username: <strong>" + AccountUserNameTxt.Text + "</strong><br />Password: <strong>" + AccountPasswordTxt.Text + "</strong><br /><br />Sincerely,<br />Distributor";
                createAccountMail.IsBodyHtml = true;
                SmtpClient smtp = new SmtpClient
                {
                    Host = "smtp.gmail.com",
                    Port = 587,
                    UseDefaultCredentials = false,
                    Credentials = new NetworkCredential(distributorEmail, "nhqpbctsxsoqfdxi"),
                    EnableSsl = true
                };
                smtp.Send(createAccountMail);
                MessageBox.Show("A mail is sent to our new agent", "Info");
            }
            else if (btnType == 2)
            {
                if (AgentIDTxt == null || AgentIDTxt.Text.Equals(""))
                {
                    MessageBox.Show("An error occurred", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                agentBUS = new BUS.AgentBUS(agentID, agentName, agentEmail, agentPhoneNum, agentAdress, false);
                agentBUS.UpdateAgentQuery();

                agentAccountBUS = new BUS.AgentAccountBUS(AgentIDTxt.Text, AccountUserNameTxt.Text, AccountPasswordTxt.Text, isActivated, false);
                agentAccountBUS.UpdateAgentAcQuery();
            }

            ShowGRD();
            Formload();
        }

        private void CancelBtn_Click(object sender, EventArgs e)
        {
            Formload();
        }

        private void AgentNameTxt_TextChanged(object sender, EventArgs e)
        {
            if (btnType != 2)
            {
                AccountUserNameTxt.Text = GenerateAccountUsername(AgentNameTxt.Text);
            }
        }

        private void AgentGrd_Click(object sender, EventArgs e)
        {
            if (AgentGrd.CurrentRow == null)
            {
                return;
            }

            AgentIDTxt.Text = AgentGrd.CurrentRow.Cells[0].Value.ToString();
            AgentNameTxt.Text = AgentGrd.CurrentRow.Cells[1].Value.ToString();
            AgentEmailTxt.Text = AgentGrd.CurrentRow.Cells[2].Value.ToString();
            AgentPhoneNumTxt.Text = AgentGrd.CurrentRow.Cells[3].Value.ToString();
            AgentAddressTxt.Text = AgentGrd.CurrentRow.Cells[4].Value.ToString();

            DataTable currAccountInfo = agentAccountBUS.SelectAgentAcByIDQuery(AgentGrd.CurrentRow.Cells[0].Value.ToString());
            if (currAccountInfo.Rows.Count > 0)
            {
                AccountUserNameTxt.Text = currAccountInfo.Rows[0][0].ToString();
                AccountPasswordTxt.Text = currAccountInfo.Rows[0][1].ToString();
                AccountActivationCB.Text = currAccountInfo.Rows[0][2].ToString() == "True" ? "Activated" : "Inactivated";
            }

            EnableGRP(false, AgentInfoGroup);
            AddBtn.Enabled = false;
            EditBtn.Enabled = true;
            SaveBtn.Enabled = false;
            
        }
    }
}
