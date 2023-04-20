using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class CustomerDAL
    {
        private DTO.CustomerDTO customerDTO;

        public CustomerDAL(
            string CustomerID,
            string CustomerName,
            string CustomerEmail,
            string CustomerPhoneNum,
            string CustomerAdress,
            bool CustomerfDeleted)
        {
            customerDTO = new DTO.CustomerDTO(
                CustomerID,
                CustomerName,
                CustomerEmail,
                CustomerPhoneNum,
                CustomerAdress,
                CustomerfDeleted);
        }

        public void AddCustomerQuery()
        {
            int isDeleted = 0;
            if (customerDTO.CheckCustomerDeleted)
            {
                isDeleted = 1;
            }
            string query = "insert into Agent values ('" +
                customerDTO.GetCustomerID +
                "', '" + customerDTO.GetCustomerName +
                "', '" + customerDTO.GetCustomerEmail +
                "', '" + customerDTO.GetCustomerPhoneNum +
                "', '" + customerDTO.GetCustomerAddress +
                "', " + isDeleted + ")";
            Connection.ActionQuery(query);
        }

        public void UpdateCustomerQuery()
        {
            string query = "update Agent set" +
                "', UserName = '" + customerDTO.GetCustomerName +
                "', UserEmail = '" + customerDTO.GetCustomerEmail +
                "', UserPhoneNumber = '" + customerDTO.GetCustomerPhoneNum +
                "', UserAddress = '" + customerDTO.GetCustomerAddress +
                " where UserID = '" + customerDTO.GetCustomerID + "'";
            Connection.ActionQuery(query);
        }

        public void DeleteCustomerQuery()
        {
            string query = "delete from Customer where UserID = '" + customerDTO.GetCustomerID + "'";
            Connection.ActionQuery(query);
        }

        public DataTable SelectCustomerQuery()
        {
            string s = "select * from Customer";
            return Connection.SelectQuery(s);
        }

        public string GetNewCustomerID()
        {
            return "";
        }
    }
}
