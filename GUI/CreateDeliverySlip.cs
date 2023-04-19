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
    public partial class CreateDeliverySlip : Form
    {
        private BUS.DeliverySlipBUS deliverySlipBUS;
        private BUS.OrderBUS orderBUS;
        private BUS.ProductBUS productBUS;
        private int btnType = 0;

        public CreateDeliverySlip()
        {
            InitializeComponent();
        }

        private void CreateDeliverySlip_Load(object sender, EventArgs e)
        {
            deliverySlipBUS = new BUS.DeliverySlipBUS("", "", DateTime.Now, false, 0);
            orderBUS = new BUS.OrderBUS("","","","","",false,0, DateTime.Now, DateTime.Now);
            productBUS = new BUS.ProductBUS("", "", "", "", "", "", 0, false, 0);
            DeliverySlipGRD.DataSource = orderBUS.SelectOrderQuery();
        }
 
    }
        

}
