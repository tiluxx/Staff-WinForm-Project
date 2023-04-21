using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DeliveryCustomerReceiptDAL
    {
        private DTO.DeliveryCustomerReceiptDTO deliveryCustomerReceiptDTO;

        public DeliveryCustomerReceiptDAL(
            string ReceiptID,
            string CartID,
            string CustomerName,
            string CustomerPhone,
            string CustomerAddress,
            string PaymentMethod,
            DateTime PaymentDate)
        {
            deliveryCustomerReceiptDTO = new DTO.DeliveryCustomerReceiptDTO(
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
            string query = "insert into DeliveryCustomerReceipt values ('" +
                deliveryCustomerReceiptDTO.GetDeliveryCustomerReceiptID +
                "', '" + deliveryCustomerReceiptDTO.GetDeliveryCustomerCartID +
                "', '" + deliveryCustomerReceiptDTO.GetDeliveryCustomerName +
                "', '" + deliveryCustomerReceiptDTO.GetDeliveryCustomerPhone +
                "', '" + deliveryCustomerReceiptDTO.GetDeliveryCustomerAddress +
                "', '" + deliveryCustomerReceiptDTO.GetDeliveryCustomerPaymentMethod +
                "', " + deliveryCustomerReceiptDTO.GetDeliveryCustomerPaymentDate + ")";
            Connection.ActionQuery(query);
        }

        public void UpdateDeliveryCustomerReceiptQuery()
        {
            string query = "update Order set" +
                " CartID = '" + deliveryCustomerReceiptDTO.GetDeliveryCustomerCartID +
                "', CustomerName = '" + deliveryCustomerReceiptDTO.GetDeliveryCustomerName +
                "', CustomerPhone = '" + deliveryCustomerReceiptDTO.GetDeliveryCustomerPhone +
                "', CustomerAddress = '" + deliveryCustomerReceiptDTO.GetDeliveryCustomerAddress +
                ", PaymentMethod = " + deliveryCustomerReceiptDTO.GetDeliveryCustomerPaymentMethod +
                "', PaymentDate = '" + deliveryCustomerReceiptDTO.GetDeliveryCustomerPaymentDate +
                " where ReceiptID  = '" + deliveryCustomerReceiptDTO.GetDeliveryCustomerReceiptID + "'";
            Connection.ActionQuery(query);
        }

        public void DeleteDeliveryCustomerReceiptQuery()
        {
            string query = "delete from DeliveryCustomerReceipt where ReceiptID = '" + deliveryCustomerReceiptDTO.GetDeliveryCustomerReceiptID + "'";
            Connection.ActionQuery(query);
        }

        public DataTable SelectDeliveryCustomerReceiptQuery()
        {
            string s = "select * from DeliveryCustomerReceipt";
            return Connection.SelectQuery(s);
        }

        public string GetNewDeliveryCustomerReceiptID()
        {
            return "";
        }
    }
}
