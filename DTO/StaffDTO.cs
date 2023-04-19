using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class StaffDTO
    {
        private string staffID, staffName, staffEmail, staffPhoneNum, staffAdress, staffPosition, staffDepartment;
        private bool staffDeleted;

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

        public string GetStaffName
        {
            get
            {
                return staffName;
            }
            set
            {
                staffName = value;
            }
        }

        public string GetStaffEmail
        {
            get
            {
                return staffEmail;
            }
            set
            {
                staffEmail = value;
            }
        }

        public string GetStaffPhoneNum
        {
            get
            {
                return staffPhoneNum;
            }
            set
            {
                staffPhoneNum = value;
            }
        }

        public string GetStaffAddress
        {
            get
            {
                return staffAdress;
            }
            set
            {
                staffAdress = value;
            }
        }

        public string GetStaffPosition
        {
            get
            {
                return staffPosition;
            }
            set
            {
                staffPosition = value;
            }
        }

        public string GetStaffDepartment
        {
            get
            {
                return staffDepartment;
            }
            set
            {
                staffDepartment = value;
            }
        }

        public bool CheckStaffDeleted
        {
            get
            {
                return staffDeleted;
            }
            set
            {
                staffDeleted = value;
            }
        }

        public StaffDTO(
            string StaffID,
            string StaffName,
            string StaffEmail,
            string StaffPhoneNum,
            string StaffAdress,
            string StaffPosition,
            string StaffDepartment,
            bool StaffDeleted)
        {
            this.staffID = StaffID;
            this.staffName = StaffName;
            this.staffEmail = StaffEmail;
            this.staffPhoneNum = StaffPhoneNum;
            this.staffAdress = StaffAdress;
            this.staffPosition = StaffPosition;
            this.staffDepartment = StaffDepartment;
            this.staffDeleted = StaffDeleted;
        }
    }
}
