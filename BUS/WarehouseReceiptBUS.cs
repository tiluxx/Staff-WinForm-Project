using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class WarehouseReceiptBUS
    {
        private DAL.WarehouseReceiptDAL warehouseReceiptDAL;

        public WarehouseReceiptBUS(
            string WarehouseReceiptID,
            string StaffID,
            DateTime ImportDate,
            bool WarehouseReceiptDeleted,
            decimal WarehouseReceiptTotalBill)
        {
            warehouseReceiptDAL = new DAL.WarehouseReceiptDAL(
                WarehouseReceiptID,
                StaffID,
                ImportDate,
                WarehouseReceiptDeleted,
                WarehouseReceiptTotalBill);
        }

        public void AddWarehouseReceiptQuery()
        {
            warehouseReceiptDAL.AddWarehouseReceiptQuery();
        }

        public void UpdateWarehouseReceiptQuery()
        {
            warehouseReceiptDAL.UpdateWarehouseReceiptQuery();
        }

        public void DeleteWarehouseReceiptQuery()
        {
            warehouseReceiptDAL.DeleteWarehouseReceiptQuery();
        }

        public DataTable SelectWarehouseReceiptQuery()
        {
            return warehouseReceiptDAL.SelectWarehouseReceiptQuery();
        }

        public string GetNewWarehouseReceiptID()
        {
            return warehouseReceiptDAL.GetNewWarehouseReceiptID();
        }
    }
}
