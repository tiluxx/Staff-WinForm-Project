using DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class DeliveryCustomerReceiptBUS
    {
        private DAL.DeliveryCustomerReceiptDAL deliveryCustomerReceiptDAL;

        public DeliveryCustomerReceiptBUS(
            string ReceiptID,
            string CartID,
            string CustomerName,
            string CustomerPhone,
            string CustomerAddress,
            string PaymentMethod,
            DateTime PaymentDate)
        {

            deliveryCustomerReceiptDAL = new DAL.DeliveryCustomerReceiptDAL(
                ReceiptID,
                CartID,
                CustomerName,
                CustomerPhone,
                CustomerAddress,
                PaymentMethod,
                PaymentDate);
        }

        public void AddDeliveryCustomerReceiptQuery()
        {
            deliveryCustomerReceiptDAL.AddDeliveryCustomerReceiptQuery();
        }

        public void UpdateDeliveryCustomerReceiptQuery()
        {
            deliveryCustomerReceiptDAL.UpdateDeliveryCustomerReceiptQuery();
        }

        public void DeleteDeliveryCustomerReceiptQuery()
        {
            deliveryCustomerReceiptDAL.DeleteDeliveryCustomerReceiptQuery();
        }

        public DataTable SelectDeliveryCustomerReceiptQuery()
        {
            return deliveryCustomerReceiptDAL.SelectDeliveryCustomerReceiptQuery();
        }

        public string GetNewDeliveryCustomerReceiptID()
        {
            return deliveryCustomerReceiptDAL.GetNewDeliveryCustomerReceiptID();
        }
    }
}
