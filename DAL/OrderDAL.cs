using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class OrderDAL
    {
        private DTO.OrderDTO orderDTO;

        public OrderDAL(
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
            orderDTO = new DTO.OrderDTO(
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
            int isDeleted = 0;
            if (orderDTO.CheckOrderDeleted)
            {
                isDeleted = 1;
            }
            string query = "insert into Order values ('" +
                orderDTO.GetOrderID +
                "', '" + orderDTO.GetAgentID +
                "', '" + orderDTO.GetOrderStatus +
                "', '" + orderDTO.GetPaymentStatus +
                "', '" + orderDTO.GetPaymentMethod +
                "', '" + orderDTO.GetTotalBill +
                "', " + orderDTO.GetOrderDate +
                "', " + orderDTO.GetPaymentDate +
                "', " + isDeleted + ")";
            Connection.ActionQuery(query);
        }

        public void UpdateOrderQuery()
        {
            string query = "update Order set" +
                " AgentID = '" + orderDTO.GetAgentID +
                "', OrderStatus = '" + orderDTO.GetOrderStatus +
                "', PaymentStatus = '" + orderDTO.GetPaymentStatus +
                "', PaymentMethod = '" + orderDTO.GetPaymentMethod +
                ", TotalBill = " + orderDTO.GetTotalBill +
                ", OrderDate = " + orderDTO.GetOrderDate +
                "', PaymentDate = '" + orderDTO.GetPaymentDate +
                " where OrderID  = '" + orderDTO.GetOrderID + "'";
            Connection.ActionQuery(query);
        }

        public void DeleteOrderQuery()
        {
            string query = "delete from Order where OrderID = '" + orderDTO.GetOrderID + "'";
            Connection.ActionQuery(query);
        }

        public DataTable SelectOrderQuery()
        {
            string s = "select * from Order";
            return Connection.SelectQuery(s);
        }
    }
}
