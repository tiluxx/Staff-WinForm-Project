using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class WarehouseReceiptDetailDTO
    {
        private string warehouseReceiptID, productID;
        private int productQuantity;

        public string GetWarehouseReceiptID
        {
            get
            {
                return warehouseReceiptID;
            }
            set
            {
                warehouseReceiptID = value;
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

        public WarehouseReceiptDetailDTO(
            string WarehouseReceiptID,
            string ProductID,
            int ProductQuantity)
        {
            this.warehouseReceiptID = WarehouseReceiptID;
            this.productID = ProductID;
            this.productQuantity = ProductQuantity;
        }
    }
}
