using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class WarehouseReceiptDetailBUS
    {
        private DAL.WarehouseReceiptDetailDAL warehouseReceiptDetailDAL;

        public WarehouseReceiptDetailBUS(
            string WarehouseReceiptID,
            string ProductID,
            int ProductQuantity)
        {
            warehouseReceiptDetailDAL = new DAL.WarehouseReceiptDetailDAL(
                WarehouseReceiptID,
                ProductID,
                ProductQuantity);
        }

        public void AddWarehouseReceiptDetailQuery()
        {
            warehouseReceiptDetailDAL.AddWarehouseReceiptDetailQuery();
        }

        public void DeleteWarehouseReceiptQuery()
        {
            warehouseReceiptDetailDAL.DeleteWarehouseReceiptDetailQuery();
        }

        public DataTable SelectWarehouseReceiptQuery()
        {
            return warehouseReceiptDetailDAL.SelectWarehouseReceiptDetailQuery();
        }
    }
}
