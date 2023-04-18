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
    public partial class CreateWarehouseReceipt : Form
    {
        private BUS.WarehouseReceiptBUS warehouseReceiptBUS;

        public CreateWarehouseReceipt()
        {
            InitializeComponent();
        }

        private void CreateWarehouseReceipt_Load(object sender, EventArgs e)
        {
            warehouseReceiptBUS = new BUS.WarehouseReceiptBUS("", "", DateTime.Now, false, 0);
        }
    }
}
