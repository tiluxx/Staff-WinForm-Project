using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class StaffBUS
    {
        private DAL.StaffDAL staffDAL;

        public StaffBUS(
            string StaffID,
            string StaffName,
            string StaffEmail,
            string StaffPhoneNum,
            string StaffAdress,
            string StaffPosition,
            string StaffDepartment,
            bool StaffDeleted)
        {
            staffDAL = new DAL.StaffDAL(
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
            staffDAL.AddStaffQuery();
        }

        public void UpdateStaffQuery()
        {
            staffDAL.UpdateStaffQuery();
        }

        public void DeleteStaffQuery()
        {
            staffDAL.DeleteStaffQuery();
        }

        public DataTable SelectStaffQuery()
        {
            return staffDAL.SelectStaffQuery();
        }

        public string GetNewStaffID()
        {
            return staffDAL.GetNewStaffID();
        }
    }
}
