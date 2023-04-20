using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class CustomerAccountBUS
    {
        private DAL.CustomerAccountDAL customerAccountDAL;

        public CustomerAccountBUS(
            string CustomerAcID,
            string CustomerAcName,
            string CustomerAcPass,
            bool CustomerAcActivated,
            bool CustomerAcDeleted)
        {
            customerAccountDAL = new DAL.CustomerAccountDAL(
                CustomerAcID,
                CustomerAcName,
                CustomerAcPass,
                CustomerAcActivated,
                CustomerAcDeleted);
        }

        public void AddCustomerAcQuery()
        {
            customerAccountDAL.AddCustomerAcQuery();
        }

        public void UpdateCustomerAcQuery()
        {
            customerAccountDAL.UpdateCustomerAcQuery();
        }

        public void DeleteCustomerAcQuery()
        {
            customerAccountDAL.DeleteCustomerAcQuery();
        }

        public DataTable SelectCustomerAcQuery()
        {
            return customerAccountDAL.SelectCustomerAcQuery();
        }

        public string GetNewCustomerAcID()
        {
            return customerAccountDAL.GetNewCustomerAcID();
        }
    }
}
