using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class StaffAccountDTO
    {
        private string staffAcID, staffAcName, staffAcPass;
        private bool staffAcDeleted, staffAcActivated;

        public string GetStaffAcID
        {
            get
            {
                return staffAcID;
            }
            set
            {
                staffAcID = value;
            }
        }

        public string GetStaffAcName
        {
            get
            {
                return staffAcName;
            }
            set
            {
                staffAcName = value;
            }
        }

        public string GetStaffAcPass
        {
            get
            {
                return staffAcPass;
            }
            set
            {
                staffAcPass = value;
            }
        }

        public bool CheckStaffAcActivated
        {
            get
            {
                return staffAcActivated;
            }
            set
            {
                staffAcActivated = value;
            }
        }

        public bool CheckStaffAcDeleted
        {
            get
            {
                return staffAcDeleted;
            }
            set
            {
                staffAcDeleted = value;
            }
        }

        public StaffAccountDTO(
            string StaffAcID,
            string StaffAcName,
            string StaffAcPass,
            bool StaffAcActivated,
            bool StaffAcDeleted)
        {
            this.staffAcID = StaffAcID;
            this.staffAcName = StaffAcName;
            this.staffAcPass = StaffAcPass;
            this.staffAcActivated = StaffAcActivated;
            this.staffAcDeleted = StaffAcDeleted;
;
        }
    }
}
