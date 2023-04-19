using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
     public class DeliverySlipDTO
    {
        private string slipID, orderID;
        private DateTime deliveryDate;
        private decimal totalBill;
        private bool deliverySlipDeleted;


        public string GetSlipID
        {
            get
            {
                return slipID;
            }
            set
            {
                slipID = value;
            }
        }

        public string GetOrderID
        {
            get
            {
                return orderID;
            }
            set
            {
                orderID = value;
            }
        }
        public DateTime GetDeliveryDate
        {
            get
            {
                return deliveryDate;
            }
            set
            {
                deliveryDate = value;
            }
        }
        public decimal GetDeliverySlipTotalBill
        {
            get
            {
                return totalBill;
            }
            set
            {
                totalBill = value;
            }
        }

        public bool CheckDeliverySlipDeleted
        {
            get
            {
                return deliverySlipDeleted;
            }
            set
            {
                deliverySlipDeleted = value;
            }
        }


        public DeliverySlipDTO(
            string SlipID,
            string OrderID,       
            DateTime DeliveryDate,
            bool DeliverySlipDeleted,
            decimal TotalBill)
        {
            this.slipID = SlipID;
            this.orderID = OrderID;
            this.deliveryDate = DeliveryDate;
            this.deliverySlipDeleted = DeliverySlipDeleted;
            this.totalBill = TotalBill; 
        }
    }
}
