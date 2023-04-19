using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class StaffDAL
    {
        private DTO.StaffDTO staffDTO;

        public StaffDAL(
            string StaffID,
            string StaffName,
            string StaffEmail,
            string StaffPhoneNum,
            string StaffAdress,
            string StaffPosition,
            string StaffDepartment,
            bool StaffDeleted)
        {
            staffDTO = new DTO.StaffDTO(
                StaffID,
                StaffName,
                StaffEmail,
                StaffPhoneNum,
                StaffAdress,
                StaffPosition,
                StaffDepartment,
                StaffDeleted);
        }

        public void AddStaffQuery()
        {
            int isDeleted = 0;
            if (staffDTO.CheckStaffDeleted)
            {
                isDeleted = 1;
            }
            string query = "insert into Staff values ('" +
                staffDTO.GetStaffID +
                "', '" + staffDTO.GetStaffName +
                "', '" + staffDTO.GetStaffEmail +
                "', '" + staffDTO.GetStaffPhoneNum +
                "', '" + staffDTO.GetStaffAddress +
                "', " + isDeleted + ")";
            Connection.ActionQuery(query);
        }

        public void UpdateStaffQuery()
        {
            string query = "update Staff set" +
                "', UserName = '" + staffDTO.GetStaffName +
                "', UserEmail = '" + staffDTO.GetStaffEmail +
                "', UserPhoneNumber = '" + staffDTO.GetStaffPhoneNum +
                "', UserAddress = '" + staffDTO.GetStaffAddress +
                " where UserID = '" + staffDTO.GetStaffID + "'";
            Connection.ActionQuery(query);
        }

        public void DeleteStaffQuery()
        {
            string query = "delete from Staff where UserID = '" + staffDTO.GetStaffID + "'";
            Connection.ActionQuery(query);
        }

        public DataTable SelectStaffQuery()
        {
            string s = "select * from Staff";
            return Connection.SelectQuery(s);
        }

        public string GetNewStaffID()
        {
            return "";
        }
    }
}
