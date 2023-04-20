﻿using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class StaffAccountDAL
    {
        private DTO.StaffAccountDTO staffAccountDTO;

        public StaffAccountDAL(
            string StaffAcID,
            string StaffAcName,
            string StaffAcEmail,
            bool StaffAcActivated,
            bool StaffAcDeleted)
        {
            staffAccountDTO = new DTO.StaffAccountDTO(
                StaffAcID,
                StaffAcName,
                StaffAcEmail,
                StaffAcActivated,
                StaffAcDeleted);
        }

        public void AddStaffAcQuery()
        {
            int isDeleted = 0;
            if (staffAccountDTO.CheckStaffAcDeleted)
            {
                isDeleted = 1;
            }
            string query = "insert into StaffAccount values ('" +
                staffAccountDTO.GetStaffAcID +
                "', '" + staffAccountDTO.GetStaffAcName +
                "', '" + staffAccountDTO.GetStaffAcPass +
                "', '" + staffAccountDTO.CheckStaffAcActivated +
                "', " + isDeleted + ")";
            Connection.ActionQuery(query);
        }

        public void UpdateStaffAcQuery()
        {
            string query = "update StaffAccount set" +
                "', UserName = '" + staffAccountDTO.GetStaffAcName +
                "', UserPassword = '" + staffAccountDTO.GetStaffAcPass +
                "', Activated = '" + staffAccountDTO.CheckStaffAcActivated +
                " where UserID = '" + staffAccountDTO.GetStaffAcID + "'";
            Connection.ActionQuery(query);
        }

        public void DeleteStaffAcQuery()
        {
            string query = "delete from StaffAccount where UserID = '" + staffAccountDTO.GetStaffAcID + "'";
            Connection.ActionQuery(query);
        }

        public DataTable SelectStaffAcQuery()
        {
            string s = "select * from StaffAccount";
            return Connection.SelectQuery(s);
        }

        public string GetNewStaffAcID()
        {
            return "";
        }
    }
}
