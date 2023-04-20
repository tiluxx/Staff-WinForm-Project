using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class CustomerDTO
    {
        private string customerID, customerName, customerEmail, customerPhoneNum, customerAddress;
        private bool customerDeleted;

        public string GetCustomerID
        {
            get
            {
                return customerID;
            }
            set
            {
                customerID = value;
            }
        }

        public string GetCustomerName
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

        public string GetCustomerEmail
        {
            get
            {
                return customerEmail;
            }
            set
            {
                customerEmail = value;
            }
        }

        public string GetCustomerPhoneNum
        {
            get
            {
                return customerPhoneNum;
            }
            set
            {
                customerPhoneNum = value;
            }
        }

        public string GetCustomerAddress
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


        public bool CheckCustomerDeleted
        {
            get
            {
                return customerDeleted;
            }
            set
            {
                customerDeleted = value;
            }
        }

        public CustomerDTO(
            string CustomerID,
            string CustomerName,
            string CustomerEmail,
            string CustomerPhoneNum,
            string CustomerAdress,
            bool CustomerDeleted)
        {
            this.customerID = CustomerID;
            this.customerName = CustomerName;
            this.customerEmail = CustomerEmail;
            this.customerPhoneNum = CustomerPhoneNum;
            this.customerAddress = CustomerAdress;
            this.customerDeleted = CustomerDeleted;
        }
    }
}
