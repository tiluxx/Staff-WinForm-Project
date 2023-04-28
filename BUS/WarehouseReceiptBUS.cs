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

        public DataTable GetImportProductByMonth(int month, int year)
        {
            return warehouseReceiptDAL.GetImportProductByMonth(month, year);
        }

        public DataTable GetExportProductByMonth(int month, int year)
        {
            return warehouseReceiptDAL.GetExportProductByMonth(month, year);
        }

        public DataTable GetBestSellingProduct(int month, int year)
        {
            return warehouseReceiptDAL.GetBestSellingProduct(month, year);
        }

        public DataTable GetRevenueByMonth(int month, int year)
        {
            return warehouseReceiptDAL.GetRevenueByMonth(month, year);
        }

        public DataTable GetRevenueMonthly()
        {
            return warehouseReceiptDAL.GetRevenueMonthly();
        }
    }
}
