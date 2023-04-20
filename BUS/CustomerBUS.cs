using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class CustomerBUS
    {
        private DAL.CustomerDAL customerDAL;

        public CustomerBUS(
            string CustomerID,
            string CustomerName,
            string CustomerEmail,
            string CustomerPhoneNum,
            string CustomerAdress,
            bool CustomerDeleted)
        {
            customerDAL = new DAL.CustomerDAL(
                CustomerID,
                CustomerName,
                CustomerEmail,
                CustomerPhoneNum,
                CustomerAdress,
                CustomerDeleted);
        }

        public void AddCustomerQuery()
        {
            customerDAL.AddCustomerQuery();
        }

        public void UpdateCustomerQuery()
        {
            customerDAL.UpdateCustomerQuery();
        }

        public void DeleteCustomerQuery()
        {
            customerDAL.DeleteCustomerQuery();
        }

        public DataTable SelectCustomerQuery()
        {
            return customerDAL.SelectCustomerQuery();
        }

        public string GetNewCustomerID()
        {
            return customerDAL.GetNewCustomerID();
        }
    }
}
