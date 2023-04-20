using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class OrderDetailBUS
    {
        private DAL.OrderDetailDAL orderDetailDAL;

        public OrderDetailBUS(
          string OrderID,
          string ProductID,
          int ProductQuantity)
        {
            orderDetailDAL = new DAL.OrderDetailDAL(
              OrderID,
              ProductID,
              ProductQuantity);
        }

        public void AddOrderDetailQuery()
        {
            orderDetailDAL.AddOrderDetailQuery();
        }

        public void DeleteOrderDetailQuery()
        {
            orderDetailDAL.DeleteOrderDetailQuery();
        }

        public DataTable SelectOrderDetailQuery()
        {
            return orderDetailDAL.SelectOrderDetailQuery();
        }

        public DataTable GetOrderProductByOrderID()
        {
            return orderDetailDAL.GetOrderProductByOrderID();
        }
    }
}
