﻿using DTO;
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
            string query = "insert into _Order (OrderID, OrderDate, AgentID, OrderStatus, PaymentStatus, PaymentMethod, OrderProductTotalBill, OrderDeleted) values ('" +
                orderDTO.GetOrderID +
                "', '" + orderDTO.GetOrderDate +
                "', '" + orderDTO.GetAgentID +
                "', '" + orderDTO.GetOrderStatus +
                "', '" + orderDTO.GetPaymentStatus +
                "', '" + orderDTO.GetPaymentMethod +
                "', " + orderDTO.GetTotalBill +
                ", " + isDeleted + ")";
            Connection.ActionQuery(query);
        }

        public void UpdateOrderQuery()
        {
            string query = "update _Order set" +
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

        public void UpdateOrderStatusQuery()
        {
            string query = "update _Order set" +
                " OrderStatus = '" + orderDTO.GetOrderStatus +
                "' where OrderID  = '" + orderDTO.GetOrderID + "'";
            Connection.ActionQuery(query);
        }

        public void UpdateOrderPaymentStatusQuery(bool isPaid)
        {
            string query;
            if (isPaid)
            {
                query = "update _Order set" +
                    " PaymentStatus = '" + orderDTO.GetPaymentStatus +
                    "', PaymentDate = '" + orderDTO.GetPaymentDate +
                    "' where OrderID  = '" + orderDTO.GetOrderID + "'";
            } else
            {
                query = "update _Order set" +
                    " PaymentStatus = '" + orderDTO.GetPaymentStatus +
                    "' where OrderID  = '" + orderDTO.GetOrderID + "'";
            }
            Connection.ActionQuery(query);
        }

        public void DeleteOrderQuery()
        {
            string query = "delete from _Order where OrderID = '" + orderDTO.GetOrderID + "'";
            Connection.ActionQuery(query);
        }

        public DataTable SelectOrderQuery()
        {
            string s = "select * from _Order";
            return Connection.SelectQuery(s);
        }
    }
}
