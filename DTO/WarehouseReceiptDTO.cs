using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class WarehouseReceiptDTO
    {
        private string warehouseReceiptID, staffID;
        private DateTime importDate;
        private decimal warehouseReceiptTotalBill;
        private bool warehouseReceiptDeleted;

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

        public string GetStaffID
        {
            get
            {
                return staffID;
            }
            set
            {
                staffID = value;
            }
        }

        public DateTime GetImportDate
        {
            get
            {
                return importDate;
            }
            set
            {
                importDate = value;
            }
        }

        public bool CheckWarehouseReceiptDeleted
        {
            get
            {
                return warehouseReceiptDeleted;
            }
            set
            {
                warehouseReceiptDeleted = value;
            }
        }

        public decimal GetWarehouseReceiptTotalBill
        {
            get
            {
                return warehouseReceiptTotalBill;
            }
            set
            {
                warehouseReceiptTotalBill = value;
            }
        }

        public WarehouseReceiptDTO(
            string WarehouseReceiptID,
            string StaffID,
            DateTime ImportDate,
            bool WarehouseReceiptDeleted,
            decimal WarehouseReceiptTotalBill)
        {
            this.warehouseReceiptID = WarehouseReceiptID;
            this.staffID = StaffID;
            this.importDate = ImportDate;
            this.warehouseReceiptTotalBill = WarehouseReceiptTotalBill;
            this.warehouseReceiptDeleted = WarehouseReceiptDeleted;
        }
    }
}
