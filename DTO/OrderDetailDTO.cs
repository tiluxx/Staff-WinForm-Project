using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class OrderDetailDTO
    {
        private string orderID, productID;
        private int productQuantity;

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

        public string GetProductID
        {
            get
            {
                return productID;
            }
            set
            {
                productID = value;
            }
        }

        public int GetProductQuantity
        {
            get
            {
                return productQuantity;
            }
            set
            {
                productQuantity = value;
            }
        }

        public OrderDetailDTO(
          string OrderID,
          string ProductID,
          int ProductQuantity)
        {
            this.orderID = OrderID;
            this.productID = ProductID;
            this.productQuantity = ProductQuantity;
        }
    }
}
