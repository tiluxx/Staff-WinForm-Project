using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class WarehouseReceiptDAL
    {
        private DTO.WarehouseReceiptDTO warehouseReceiptDTO;

        public WarehouseReceiptDAL(
            string WarehouseReceiptID,
            string StaffID,
            DateTime ImportDate,
            bool WarehouseReceiptDeleted,
            decimal WarehouseReceiptTotalBill)
        {
            warehouseReceiptDTO = new DTO.WarehouseReceiptDTO(
                WarehouseReceiptID,
                StaffID,
                ImportDate,
                WarehouseReceiptDeleted,
                WarehouseReceiptTotalBill);
        }

        public void AddWarehouseReceiptQuery()
        {
            int isDeleted = 0;
            if (warehouseReceiptDTO.CheckWarehouseReceiptDeleted)
            {
                isDeleted = 1;
            }
            string inportDate = warehouseReceiptDTO.GetImportDate.ToString("yyyy-MM-dd HH:mm:ss");
            string query = "insert into WarehouseReceipt values ('" +
                warehouseReceiptDTO.GetWarehouseReceiptID +
                "', '" + warehouseReceiptDTO.GetStaffID +
                "', '" + inportDate +
                "', " + warehouseReceiptDTO.GetWarehouseReceiptTotalBill +
                ", " + isDeleted + ")";
            Connection.ActionQuery(query);
        }

        public void UpdateWarehouseReceiptQuery()
        {
            string importDate = warehouseReceiptDTO.GetImportDate.ToString("yyyy-MM-dd HH:mm:ss");
            string query = "update WarehouseReceipt set" +
                " StaffID = '" + warehouseReceiptDTO.GetStaffID +
                "', ImportDate = '" + importDate +
                "', TotalBill = " + warehouseReceiptDTO.GetWarehouseReceiptTotalBill +
                " where WarehouseReceiptID = '" + warehouseReceiptDTO.GetWarehouseReceiptID + "'";
            Connection.ActionQuery(query);
        }

        public void DeleteWarehouseReceiptQuery()
        {
            string query = "delete from WarehouseReceipt where WarehouseReceiptID = '" + warehouseReceiptDTO.GetWarehouseReceiptID + "'";
            Connection.ActionQuery(query);
        }

        public DataTable SelectWarehouseReceiptQuery()
        {
            string s = "select * from WarehouseReceipt";
            return Connection.SelectQuery(s);
        }

        public string GetNewWarehouseReceiptID()
        {
            return "";
        }
    }
}
