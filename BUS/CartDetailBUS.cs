using DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class CartDetailBUS
    {
        private DAL.CartDetailDAL cartDetailDAL;
        public CartDetailBUS(
            string CartID,
            string ProductID,
            int CartQuantity)

        {
            cartDetailDAL = new DAL.CartDetailDAL(
                CartID,
                ProductID,
                CartQuantity);
        }
        public void AddCartDetailQuery()
        {
            cartDetailDAL.AddCartDetailQuery();
        }

        public void UpdateCartDetailQuery()
        {
            cartDetailDAL.UpdateCartDetailQuery();
        }

        public void DeleteCartDetailQuery()
        {
            cartDetailDAL.DeleteCartDetailQuery();
        }

        public DataTable SelectCartDetailQuery()
        {
            return cartDetailDAL.SelectCartDetailQuery();
        }

        public string GetNewCartDetailID()
        {
            return cartDetailDAL.GetNewCartDetailID();
        }
    }
}