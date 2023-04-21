using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class CartDetailDAL
    {
        private DTO.CartDetailDTO cartDetailDTO;

        public CartDetailDAL(
           string CartID,
            string ProductID,
            int CartQuantity)

        {
            cartDetailDTO = new DTO.CartDetailDTO(
                CartID,
                ProductID,
                CartQuantity);
        }

        public void AddCartDetailQuery()
        {
            string query = "insert into CartDetail values ('" +
                cartDetailDTO.GetCartID +
                "', '" + cartDetailDTO.GetProductID +
                "', '" + cartDetailDTO.GetCartQuantity + ")"; 
            Connection.ActionQuery(query);
        }

        public void UpdateCartDetailQuery()
        {
            string query = "update Cart set" +
                 "', ProductID = '" + cartDetailDTO.GetProductID +
                 "', Quantity = " + cartDetailDTO.GetCartQuantity +
                 " where CartID = '" + cartDetailDTO.GetCartID + "'";
            Connection.ActionQuery(query);
        }
        public void DeleteCartDetailQuery()
        {
            string query = "delete from CartDetail where cartID = '" + cartDetailDTO.GetCartID + "'";
            Connection.ActionQuery(query);
        }

        public DataTable SelectCartDetailQuery()
        {
            string s = "select * from CartDetail";
            return Connection.SelectQuery(s);
        }

        public string GetNewCartDetailID()
        {
            return "";
        }
    }
}