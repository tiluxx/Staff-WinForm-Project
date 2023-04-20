using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DeliveryCustomerReceiptDTO
    {
        private string receiptID, cartID, customerName, customerPhone, customerAddress, paymentMethod;
        private DateTime paymentDate;

        public string GetDeliveryCustomerReceiptID
        {
            get
            {
                return receiptID;
            }
            set
            {
                receiptID = value;
            }
        }

        public string GetDeliveryCustomerCartID
        {
            get
            {
                return cartID;
            }
            set
            {
                cartID = value;
            }
        }

        public string GetDeliveryCustomerName
        {
            get
            {
                return customerName;
            }
            set
            {
                customerName = value;
            }
        }

        public string GetDeliveryCustomerPhone
        {
            get
            {
                return customerPhone;
            }
            set
            {
                customerPhone = value;
            }
        }

        public string GetDeliveryCustomerAddress
        {
            get
            {
                return customerAddress;
            }
            set
            {
                customerAddress = value;
            }
        }

        public string GetDeliveryCustomerPaymentMethod
        {
            get
            {
                return paymentMethod;
            }
            set
            {
                paymentMethod = value;
            }
        }

        public DateTime GetDeliveryCustomerPaymentDate
        {
            get
            {
                return paymentDate;
            }
            set
            {
                paymentDate = value;
            }
        }

        public DeliveryCustomerReceiptDTO(
          string ReceiptID,
          string CartID,
          string CustomerName,
          string CustomerPhone,
          string CustomerAddress,
          string PaymentMethod,
          DateTime PaymentDate
          )
        {
            this.receiptID = ReceiptID;
            this.cartID = CartID;
            this.customerName = CustomerName;
            this.customerPhone = CustomerPhone;
            this.customerAddress = CustomerAddress;
            this.paymentMethod = PaymentMethod;
            this.paymentDate = PaymentDate;
        }
    }
}

