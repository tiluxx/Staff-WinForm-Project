using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class AgentDAL
    {
        private DTO.AgentDTO agentDTO;

        public AgentDAL(
            string AgentID,
            string AgentName,
            string AgentEmail,
            string AgentPhoneNum,
            string AgentAdress,
            bool AgentDeleted)
        {
            agentDTO = new DTO.AgentDTO(
                AgentID,
                AgentName,
                AgentEmail,
                AgentPhoneNum,
                AgentAdress,
                AgentDeleted);
        }

        public void AddAgentQuery()
        {
            int isDeleted = 0;
            if (agentDTO.CheckAgentDeleted)
            {
                isDeleted = 1;
            }
            string query = "insert into _User values ('" +
                agentDTO.GetAgentID +
                "', '" + agentDTO.GetAgentName +
                "', '" + agentDTO.GetAgentEmail +
                "', '" + agentDTO.GetAgentPhoneNum +
                "', '" + agentDTO.GetAgentAddress +
                "', " + isDeleted + ")";
            Connection.ActionQuery(query);

            query = "insert into Agent values ('" + agentDTO.GetAgentID + "')";
            Connection.ActionQuery(query);
        }

        public void UpdateAgentQuery()
        {
            string query = "update _User set" +
                " UserName = '" + agentDTO.GetAgentName +
                "', UserEmail = '" + agentDTO.GetAgentEmail +
                "', UserPhone = '" + agentDTO.GetAgentPhoneNum +
                "', UserAddress = '" + agentDTO.GetAgentAddress +
                "' where UserID = '" + agentDTO.GetAgentID + "'";
            Connection.ActionQuery(query);
        }

        public void DeleteAgentQuery()
        {
            string query = "delete from Agent where AgentID = '" + agentDTO.GetAgentID + "'";
            Connection.ActionQuery(query);

            query = "delete from _User where UserID = '" + agentDTO.GetAgentID + "'";
            Connection.ActionQuery(query);
        }

        public DataTable SelectAgentQuery()
        {
            string s = "select U.UserID as 'Agent ID', U.UserName as 'Agent name', U.UserEmail as 'Agent email', U.UserPhone as 'Agent phone', U.UserAddress as 'Agent address'" +
                " from Agent A, _User U where A.AgentID = U.UserID";
            return Connection.SelectQuery(s);
        }

        private DataTable GetAgentDesc()
        {
            string s = "select top 1 AgentID from Agent order by AgentID desc";
            return Connection.SelectQuery(s);
        }

        public string GetNewAgentID()
        {
            DataTable resTable = GetAgentDesc();
            if (resTable.Rows.Count > 0)
            {
                string res = resTable.Rows[0][0].ToString();
                int order = int.Parse(res.Substring(4)) + 1;
                if (order < 10)
                {
                    res = "AGMP00000" + order.ToString();
                }
                else if (order < 100)
                {
                    res = "v0000" + order.ToString();
                }
                else if (order < 1000)
                {
                    res = "AGMP000" + order.ToString();
                }
                else if (order < 10000)
                {
                    res = "AGMP00" + order.ToString();
                }
                else if (order < 100000)
                {
                    res = "AGMP0" + order.ToString();
                }
                else
                {
                    res = "AGMP" + order.ToString();
                }
                return res;
            }
            else
            {
                return "AGMP000001";
            }
        }
    }
}
