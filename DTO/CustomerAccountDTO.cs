using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class CustomerAccountDTO
    {
        private string customerAcID, customerAcName, customerAcPass;
        private bool customerAcDeleted, customerAcActivated;

        public string GetCustomerAcID
        {
            get
            {
                return customerAcID;
            }
            set
            {
                customerAcID = value;
            }
        }

        public string GetCustomerAcName
        {
            get
            {
                return customerAcName;
            }
            set
            {
                customerAcName = value;
            }
        }

        public string GetCustomerAcPass
        {
            get
            {
                return customerAcPass;
            }
            set
            {
                customerAcPass = value;
            }
        }

        public bool CheckCustomerAcActivated
        {
            get
            {
                return customerAcActivated;
            }
            set
            {
                customerAcActivated = value;
            }
        }

        public bool CheckCustomerAcDeleted
        {
            get
            {
                return customerAcDeleted;
            }
            set
            {
                customerAcDeleted = value;
            }
        }

        public CustomerAccountDTO(
            string CustomerAcID,
            string CustomerAcName,
            string CustomerAcPass,
            bool CustomerAcActivated,
            bool CustomerAcDeleted)
        {
            this.customerAcID = CustomerAcID;
            this.customerAcName = CustomerAcName;
            this.customerAcPass = CustomerAcPass;
            this.customerAcActivated = CustomerAcActivated;
            this.customerAcDeleted = CustomerAcDeleted;
        }
    }
}
