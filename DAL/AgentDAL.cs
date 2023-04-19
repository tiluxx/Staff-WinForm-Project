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
            bool AgentfDeleted)
        {
            agentDTO = new DTO.AgentDTO(
                AgentID,
                AgentName,
                AgentEmail,
                AgentPhoneNum,
                AgentAdress,
                AgentfDeleted);
        }

        public void AddAgentQuery()
        {
            int isDeleted = 0;
            if (agentDTO.CheckAgentDeleted)
            {
                isDeleted = 1;
            }
            string query = "insert into Agent values ('" +
                agentDTO.GetAgentID +
                "', '" + agentDTO.GetAgentName +
                "', '" + agentDTO.GetAgentEmail +
                "', '" + agentDTO.GetAgentPhoneNum +
                "', '" + agentDTO.GetAgentAddress +
                "', " + isDeleted + ")";
            Connection.ActionQuery(query);
        }

        public void UpdateAgentQuery()
        {
            string query = "update Agent set" +
                "', UserName = '" + agentDTO.GetAgentName +
                "', UserEmail = '" + agentDTO.GetAgentEmail +
                "', UserPhoneNumber = '" + agentDTO.GetAgentPhoneNum +
                "', UserAddress = '" + agentDTO.GetAgentAddress +
                " where UserID = '" + agentDTO.GetAgentID + "'";
            Connection.ActionQuery(query);
        }

        public void DeleteAgentQuery()
        {
            string query = "delete from Agent where UserID = '" + agentDTO.GetAgentID + "'";
            Connection.ActionQuery(query);
        }

        public DataTable SelectAgentQuery()
        {
            string s = "select * from Agent";
            return Connection.SelectQuery(s);
        }

        public string GetNewAgentID()
        {
            return "";
        }
    }
}
