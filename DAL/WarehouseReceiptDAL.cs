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
                "', WarehouseTotalBill = " + warehouseReceiptDTO.GetWarehouseReceiptTotalBill +
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

        private DataTable GetProjectDesc()
        {
            string s = "select top 1 WarehouseReceiptID from WarehouseReceipt order by WarehouseReceiptID desc";
            return Connection.SelectQuery(s);
        }

        public string GetNewWarehouseReceiptID()
        {
            DataTable resTable = GetProjectDesc();
            if (resTable.Rows.Count > 0)
            {
                string res = resTable.Rows[0][0].ToString();
                int order = int.Parse(res.Substring(4)) + 1;
                if (order < 10)
                {
                    res = "WHMP00000" + order.ToString();
                }
                else if (order < 100)
                {
                    res = "WHMP0000" + order.ToString();
                }
                else if (order < 1000)
                {
                    res = "WHMP000" + order.ToString();
                }
                else if (order < 10000)
                {
                    res = "WHMP00" + order.ToString();
                }
                else if (order < 100000)
                {
                    res = "WHMP0" + order.ToString();
                }
                else
                {
                    res = "WHMP" + order.ToString();
                }
                return res;
            }
            else
            {
                return "WHMP000001";
            }
        }

        public DataTable GetImportProductByMonth(int month, int year)
        {
            string s = "select P.ProductID, P.ProductName, P.ProductSize, P.ProductUnitSize, P.ProductBrand, P.ProductOrigin, P.ProductPrice, WD.Quantity" +
                        " from WareHouseReceiptDetail WD, Product P" +
                        " where WD.WareHouseReceiptID IN(" +
                            " select W.WarehouseReceiptID" +
                            " from WareHouseReceipt W" +
                            " where Month(W.ImportDate) = " + month +
                            " and Year(W.ImportDate) = " + year +
                        " ) and WD.ProductID = P.ProductID";
            return Connection.SelectQuery(s);
        }

        public DataTable GetExportProductByMonth(int month, int year)
        {
            string s = "select P.ProductID, P.ProductName, P.ProductSize, P.ProductUnitSize, P.ProductBrand, P.ProductOrigin, P.ProductPrice, O.Quantity" +
                        " from OrderDetail O, Product P" +
                        " where O.OrderID IN (" +
                            " select D.OrderID" +
                            " from DeliverySlip D" +
                            " where Month(D.DeliveryDate) = " + month +
                            " and Year(D.DeliveryDate) = " + year +
                        " ) and O.ProductID = P.ProductID";
            return Connection.SelectQuery(s);
        }

        public DataTable GetBestSellingProduct(int month, int year)
        {
            string s = "select top(3) P.ProductID, P.ProductName, P.ProductSize, P.ProductUnitSize, P.ProductBrand, P.ProductOrigin, P.ProductPrice, SUM(O.Quantity) AS TotalQuantity" +
                        " from OrderDetail O, Product P" +
                        " where O.OrderID IN ( select D.OrderID from DeliverySlip D where Month(D.DeliveryDate) = " + month + " and Year(D.DeliveryDate) = " + year + ") and O.ProductID = P.ProductID" +
                        " group by P.ProductID, P.ProductName, P.ProductSize, P.ProductUnitSize, P.ProductBrand, P.ProductOrigin, P.ProductPrice" +
                        " order by SUM(O.Quantity) DESC";
            return Connection.SelectQuery(s);
        }

        public DataTable GetRevenueByMonth(int month, int year)
        {
            string s = "select M.MonthName AS 'Month', Year(D.DeliveryDate) AS 'Year', SUM(D.TotalBill) AS 'Revenue'" +
                       " from DeliverySlip D, __Months M" +
                       " where Month(D.DeliveryDate) = " + month + " and Month(D.DeliveryDate) = M.MonthNumber" +
                       " and Year(D.DeliveryDate) = " + year +
                       " group by M.MonthName, Year(D.DeliveryDate)";
            return Connection.SelectQuery(s);
        }

        public DataTable GetRevenueMonthly()
        {
            string s = "select M.MonthName AS 'Month', ISNULL(SUM(D.TotalBill), 0) AS 'Revenue'" +
                       " from __Months M LEFT JOIN DeliverySlip D ON Month(D.DeliveryDate) = M.MonthNumber" +
                       " group by M.MonthName";
            return Connection.SelectQuery(s);
        }
    }
}
