using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class OrderDTO
    {
        private string orderID, agentID, orderStatus, paymentStatus, paymentMethod;
        private decimal totalBill;
        private DateTime orderDate, paymentDate;
        private bool orderDeleted;

        public string GetOrderID
        {
            get
            {
                return orderID;
            }
            set
            {
                orderID = value;
            }
        }

        public string GetAgentID
        {
            get
            {
                return agentID;
            }
            set
            {
                agentID = value;
            }
        }

        public string GetOrderStatus
        {
            get
            {
                return orderStatus;
            }
            set
            {
                orderStatus = value;
            }
        }

        public string GetPaymentStatus
        {
            get
            {
                return paymentStatus;
            }
            set
            {
                paymentStatus = value;
            }
        }

        public string GetPaymentMethod
        {
            get
            {
                return paymentMethod;
            }
            set
            {
                paymentMethod = value;
            }
        }

        public decimal GetTotalBill
        {
            get
            {
                return totalBill;
            }
            set
            {
                totalBill = value;
            }
        }

        public bool CheckOrderDeleted
        {
            get
            {
                return orderDeleted;
            }
            set
            {
                orderDeleted = value;
            }
        }
        public DateTime GetOrderDate
        {
            get 
            {
                return orderDate;
            }
            set
            {
                orderDate = value;
            }
        }
        public DateTime GetPaymentDate
        {
            get
            {
                return paymentDate;
            }
            set
            {
                paymentDate = value;
            }
        }

        public OrderDTO(
          string OrderID,
          string AgentID,
          string OrderStatus,
          string PaymentStatus,
          string PaymentMethod,
          bool OrdertDeleted,
          decimal TotalBill,
          DateTime OrderDate,
          DateTime PaymentDate
          )
        {
            this.orderID = OrderID;
            this.agentID = AgentID;
            this.orderStatus = OrderStatus;
            this.paymentStatus = PaymentStatus;
            this.paymentMethod = PaymentMethod;
            this.totalBill = TotalBill;
            this.orderDate = OrderDate;
            this.paymentDate = PaymentDate;
            this.orderDeleted = OrdertDeleted;
        }
    }
}

