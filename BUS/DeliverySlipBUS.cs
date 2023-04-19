using DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class DeliverySlipBUS
    {
        private DAL.DeliverySlipDAL deliverySlipDAL;
        public DeliverySlipBUS(
            string SlipID,
            string OrderID,
            DateTime DeliveryDate,
            bool DeliverySlipDeleted,
            decimal TotalBill)

        {
            deliverySlipDAL = new DAL.DeliverySlipDAL(
                SlipID,
                OrderID,
                DeliveryDate,
                DeliverySlipDeleted,
                TotalBill);
        }
        public void AddDeliverySlipQuery()
        {
            deliverySlipDAL.AddDeliverySlipQuery();
        }

        public void UpdateDeliverySlipQuery()
        {
            deliverySlipDAL.UpdateDeliverySlipQuery();
        }

        public void DeleteDeliverSlipQuery()
        {
            deliverySlipDAL.DeleteDeliverSlipQuery();
        }

        public DataTable SelectDeliverySlipQuery()
        {
            return deliverySlipDAL.SelectDeliverySlipQuery();
        }
    }
}
