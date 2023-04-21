using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class StaffAccountBUS
    {
        private DAL.StaffAccountDAL staffAccountDAL;

        public StaffAccountBUS(
            string StaffAcID,
            string StaffAcName,
            string StaffAcPass,
            bool StaffAcActivated,
            bool StaffAcDeleted)
        {
            staffAccountDAL = new DAL.StaffAccountDAL(
                StaffAcID,
                StaffAcName,
                StaffAcPass,
                StaffAcActivated,
                StaffAcDeleted);
        }

        public void AddStaffAcQuery()
        {
            staffAccountDAL.AddStaffAcQuery();
        }

        public void UpdateStaffAcQuery()
        {
            staffAccountDAL.UpdateStaffAcQuery();
        }

        public void DeleteStaffAcQuery()
        {
            staffAccountDAL.DeleteStaffAcQuery();
        }

        public DataTable SelectStaffAcQuery()
        {
            return staffAccountDAL.SelectStaffAcQuery();
        }

        public List<String> CheckStaffLogin(string username, string password)
        {
            return staffAccountDAL.CheckStaffLogin(username, password);
        }

        public string GetNewStaffAcID()
        {
            return staffAccountDAL.GetNewStaffAcID();
        }
    }
}
