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
            agentGrd.DataSource = agentBUS.SelectAgentQuery();
        }

        public void Formload()
        {
            AddBtn.Enabled = true;
            DeleteBtn.Enabled = false;
            EditBtn.Enabled = false;
            SaveBtn.Enabled = false;

            AgentIDTxt.Clear();
            AgentNameTxt.Clear();
            AgentPhoneNumTxt.Clear();
            AgentEmailTxt.Clear();
            AgentAddressTxt.Clear();
        }


        private void AddBtn_Click(object sender, EventArgs e)
        { 
            btnType = 1;

            // Reset input
            AgentIDTxt.Clear();
            AgentNameTxt.Clear();
            AgentPhoneNumTxt.Clear();
            AgentEmailTxt.Clear();
            AgentAddressTxt.Clear();

            // Generate new product ID automatically
            AgentIDTxt.Text = agentBUS.GetNewAgentID();
            AgentIDTxt.Enabled = false;

            // Disable unnecessary buttons
            DeleteBtn.Enabled = false;
            EditBtn.Enabled = false;
            SaveBtn.Enabled = true;
        }

        private void EditBtn_Click(object sender, EventArgs e)
        {
            btnType = 2;
            AgentIDTxt.Enabled = false;
            AgentNameTxt.Focus();
            AddBtn.Enabled = false;
            SaveBtn.Enabled = true;
        }

        private void DeleteBtn_Click(object sender, EventArgs e)
        {

        }

        private void SaveBtn_Click(object sender, EventArgs e)
        {

        }

        private void CancelBtn_Click(object sender, EventArgs e)
        {
            Formload();
        }
    }
}
