using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DeliverySlipDAL
    {
        private DTO.DeliverySlipDTO deliverySlipDTO;

        public DeliverySlipDAL(
           string SlipID,
           string OrderID,
           DateTime DeliveryDate,
           bool DeliverySlipDeleted,
           decimal TotalBill)

        {
            deliverySlipDTO = new DTO.DeliverySlipDTO(
                SlipID,
                OrderID,
                DeliveryDate,
                DeliverySlipDeleted,
                TotalBill);
        }

        public void AddDeliverySlipQuery()
        {
            int isDeleted = 0;
            if (deliverySlipDTO.CheckDeliverySlipDeleted)
            {
                isDeleted = 1;
            }
            string deliveryDate = deliverySlipDTO.GetDeliveryDate.ToString("yyyy-MM-dd HH:mm:ss");
            string query = "insert into DeliverySlip values ('" +
                deliverySlipDTO.GetSlipID +
                "', '" + deliverySlipDTO.GetOrderID +
                "', '" + deliveryDate +
                "', " + deliverySlipDTO.GetDeliverySlipTotalBill +
                "', " + isDeleted + ")";
            Connection.ActionQuery(query);
        }

        public void UpdateDeliverySlipQuery()
        {
            string deliveryDate = deliverySlipDTO.GetDeliveryDate.ToString("yyyy-MM-dd HH:mm:ss");
            string query = "update DeliverySlip set" +
                " OrderID = '" + deliverySlipDTO.GetOrderID +
                "', DeliveryDate = '" + deliveryDate +
                "', TotalBill = " + deliverySlipDTO.GetDeliverySlipTotalBill +
                " where SlipID = '" + deliverySlipDTO.GetSlipID + "'";
            Connection.ActionQuery(query);
        }
        public void DeleteDeliverSlipQuery()
        {
            string query = "delete from DeliverySlip where slipID = '" + deliverySlipDTO.GetSlipID + "'";
            Connection.ActionQuery(query);
        }

        public DataTable SelectDeliverySlipQuery()
        {
            string s = "select * from DeliverySlip";
            return Connection.SelectQuery(s);
        }

        private DataTable GetDeliverySlipDesc()
        {
            string s = "select top 1 SlipID from DeliverySlip order by SlipID desc";
            return Connection.SelectQuery(s);
        }

        public string GetNewDeliverySlipID()
        {
            DataTable resTable = GetDeliverySlipDesc();
            if (resTable.Rows.Count > 0)
            {
                string res = resTable.Rows[0][0].ToString();
                int order = int.Parse(res.Substring(4)) + 1;
                if (order < 10)
                {
                    res = "DSMP00000" + order.ToString();
                }
                else if (order < 100)
                {
                    res = "DSMP0000" + order.ToString();
                }
                else if (order < 1000)
                {
                    res = "DSMP000" + order.ToString();
                }
                else if (order < 10000)
                {
                    res = "DSMP00" + order.ToString();
                }
                else if (order < 100000)
                {
                    res = "DSMP0" + order.ToString();
                }
                else
                {
                    res = "DSMP" + order.ToString();
                }
                return res;
            }
            else
            {
                return "DSMP000001";
            }
        }
    }
}