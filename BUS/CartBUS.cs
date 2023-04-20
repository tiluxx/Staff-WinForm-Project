using DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class CartBUS
    {
        private DAL.CartDAL cartDAL;
        public CartBUS(
            string CartID,
            string CustomerID,
            decimal TotalBill,
            bool CartDeleted)

        {
            cartDAL = new DAL.CartDAL(
                CartID,
                CustomerID,
                TotalBill,
                CartDeleted);
        }
        public void AddCartQuery()
        {
            cartDAL.AddCartQuery();
        }

        public void UpdateCartQuery()
        {
            cartDAL.UpdateCartQuery();
        }

        public void DeleteCartQuery()
        {
            cartDAL.DeleteCartQuery();
        }

        public DataTable SelectCartQuery()
        {
            return cartDAL.SelectCartQuery();
        }

        public string GetNewCartID()
        {
            return cartDAL.GetNewCartID();
        }
    }
}