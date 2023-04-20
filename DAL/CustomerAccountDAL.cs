using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class CustomerAccountDAL
    {
        private DTO.CustomerAccountDTO customerAccountDTO;

        public CustomerAccountDAL(
            string CustomerAcID,
            string CustomerAcName,
            string CustomerAcEmail,
            bool CustomerAcActivated,
            bool CustomerAcDeleted)
        {
            customerAccountDTO = new DTO.CustomerAccountDTO(
                CustomerAcID,
                CustomerAcName,
                CustomerAcEmail,
                CustomerAcActivated,
                CustomerAcDeleted);
        }

        public void AddCustomerAcQuery()
        {
            int isDeleted = 0;
            if (customerAccountDTO.CheckCustomerAcDeleted)
            {
                isDeleted = 1;
            }
            string query = "insert into CustomerAccount values ('" +
                customerAccountDTO.GetCustomerAcID +
                "', '" + customerAccountDTO.GetCustomerAcName +
                "', '" + customerAccountDTO.GetCustomerAcPass +
                "', '" + customerAccountDTO.CheckCustomerAcActivated +
                "', " + isDeleted + ")";
            Connection.ActionQuery(query);
        }

        public void UpdateCustomerAcQuery()
        {
            string query = "update CustomerAccount set" +
                "', UserName = '" + customerAccountDTO.GetCustomerAcName +
                "', UserPassword = '" + customerAccountDTO.GetCustomerAcPass +
                "', Activated = '" + customerAccountDTO.CheckCustomerAcActivated +
                " where UserID = '" + customerAccountDTO.GetCustomerAcID + "'";
            Connection.ActionQuery(query);
        }

        public void DeleteCustomerAcQuery()
        {
            string query = "delete from CustomerAccount where UserID = '" + customerAccountDTO.GetCustomerAcID + "'";
            Connection.ActionQuery(query);
        }

        public DataTable SelectCustomerAcQuery()
        {
            string s = "select * from CustomerAccount";
            return Connection.SelectQuery(s);
        }

        public string GetNewCustomerAcID()
        {
            return "";
        }
    }
}
