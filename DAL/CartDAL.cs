using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class CartDAL
    {
        private DTO.CartDTO cartDTO;

        public CartDAL(
           string CartID,
            string CustomerID,
            decimal TotalBill,
            bool CartDeleted)

        {
            cartDTO = new DTO.CartDTO(
                CartID,
                CustomerID,
                TotalBill,
                CartDeleted);
        }

        public void AddCartQuery()
        {
            int isDeleted = 0;
            if (cartDTO.CheckCartDeleted)
            {
                isDeleted = 1;
            }
            string query = "insert into Cart values ('" +
                cartDTO.GetCartID +
                "', '" + cartDTO.GetCustomerID +
                "', '" + cartDTO.GetCartTotalBill +
                "', " + isDeleted + ")";
            Connection.ActionQuery(query);
        }

        public void UpdateCartQuery()
        {
            string query = "update Cart set" +
                 "', CustomerID = '" + cartDTO.GetCustomerID +
                 "', TotalBill = '" + cartDTO.GetCartTotalBill +
                 " where UserID = '" + cartDTO.GetCartID + "'";
            Connection.ActionQuery(query);
        }
        public void DeleteCartQuery()
        {
            string query = "delete from Cart where cartID = '" + cartDTO.GetCartID + "'";
            Connection.ActionQuery(query);
        }

        public DataTable SelectCartQuery()
        {
            string s = "select * from Cart";
            return Connection.SelectQuery(s);
        }

        public string GetNewCartID()
        {
            return "";
        }
    }
}