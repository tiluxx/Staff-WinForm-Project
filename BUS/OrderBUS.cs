using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class OrderBUS
    {
        private DAL.OrderDAL orderDAL;

        public OrderBUS(
            string OrderID,
            string AgentID,
            string OrderStatus,
            string PaymentStatus,
            string PaymentMethod,
            bool OrdertDeleted,
            decimal TotalBill,
            DateTime OrderDate,
            DateTime PaymentDate)
        {

            orderDAL = new DAL.OrderDAL(
                OrderID,
                AgentID,
                OrderStatus,
                PaymentStatus,
                PaymentMethod,
                OrdertDeleted,
                TotalBill,
                OrderDate,
                PaymentDate);
        }

        public void AddOrderQuery()
        {
            orderDAL.AddOrderQuery();
        }

        public void UpdateOrderQuery()
        {
            orderDAL.UpdateOrderQuery();
        }

        public void DeleteOrderQuery()
        {
            orderDAL.DeleteOrderQuery();
        }

        public DataTable SelectOrderQuery()
        {
            return orderDAL.SelectOrderQuery();
        }

    }
}
