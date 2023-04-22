using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class OrderDetailDAL
    {
        private DTO.OrderDetailDTO orderDetailDTO;

        public OrderDetailDAL(
          string OrderID,
          string ProductID,
          int ProductQuantity)
        {
            orderDetailDTO = new DTO.OrderDetailDTO(
              OrderID,
              ProductID,
              ProductQuantity);
        }

        public void AddOrderDetailQuery()
        {
            string query = "insert into OrderDetail values ('" +
                orderDetailDTO.GetOrderID +
                "', '" + orderDetailDTO.GetProductID +
                "', " + orderDetailDTO.GetProductQuantity + ")";
            Connection.ActionQuery(query);
        }

        public void DeleteOrderDetailQuery()
        {
            string query = "delete from OrderDetail where OrderID = '" + orderDetailDTO.GetOrderID + "' and ProductID = '" + orderDetailDTO.GetProductID + "'";
            Connection.ActionQuery(query);
        }

        public DataTable SelectOrderDetailQuery()
        {
            string s = "select * from OrderDetail";
            return Connection.SelectQuery(s);
        }

        public DataTable GetOrderProductByOrderID()
        {
            string s = "select P.*, O.Quantity from OrderDetail O, Product P where O.OrderID = '" + orderDetailDTO.GetOrderID + "' and O.ProductID = P.ProductID";
            return Connection.SelectQuery(s);
        }
    }
}
