using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class WarehouseReceiptDetailDAL
    {
        private DTO.WarehouseReceiptDetailDTO warehouseReceiptDetailDTO;

        public WarehouseReceiptDetailDAL(
            string WarehouseReceiptID,
            string ProductID,
            int ProductQuantity)
        {
            warehouseReceiptDetailDTO = new DTO.WarehouseReceiptDetailDTO(
                WarehouseReceiptID,
                ProductID,
                ProductQuantity);
        }

        public void AddWarehouseReceiptDetailQuery()
        {
            string query = "insert into WarehouseReceiptDetail values ('" +
                warehouseReceiptDetailDTO.GetWarehouseReceiptID +
                "', '" + warehouseReceiptDetailDTO.GetProductID +
                "', " + warehouseReceiptDetailDTO.GetProductQuantity + ")";
            Connection.ActionQuery(query);
        }

        public void DeleteWarehouseReceiptDetailQuery()
        {
            string query = "delete from WarehouseReceiptDetail where WarehouseReceiptID = '"
                + warehouseReceiptDetailDTO.GetWarehouseReceiptID +
                "' and ProductID = '" + warehouseReceiptDetailDTO.GetProductID + "'";
            Connection.ActionQuery(query);
        }

        public DataTable SelectWarehouseReceiptDetailQuery()
        {
            string s = "select * from WarehouseReceiptDetail";
            return Connection.SelectQuery(s);
        }
    }
}
