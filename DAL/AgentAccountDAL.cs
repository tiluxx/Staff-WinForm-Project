using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class AgentAccountDAL
    {
        private DTO.AgentAccountDTO agentAccountDTO;

        public AgentAccountDAL(
            string AgentAcID,
            string AgentAcName,
            string AgentAcEmail,
            bool AgentAcActivated,
            bool AgentAcDeleted)
        {
            agentAccountDTO = new DTO.AgentAccountDTO(
                AgentAcID,
                AgentAcName,
                AgentAcEmail,
                AgentAcActivated,
                AgentAcDeleted);
        }

        public void AddAgentAcQuery()
        {
            int isDeleted = 0;
            if (agentAccountDTO.CheckAgentAcDeleted)
            {
                isDeleted = 1;
            }
            string query = "insert into AgentAccount values ('" +
                agentAccountDTO.GetAgentAcID +
                "', '" + agentAccountDTO.GetAgentAcName +
                "', '" + agentAccountDTO.GetAgentAcPass +
                "', '" + agentAccountDTO.CheckAgentAcActivated +
                "', " + isDeleted + ")";
            Connection.ActionQuery(query);
        }

        public void UpdateAgentAcQuery()
        {
            string query = "update AgentAccount set" +
                "', UserName = '" + agentAccountDTO.GetAgentAcName +
                "', UserPassword = '" + agentAccountDTO.GetAgentAcPass +
                "', Activated = '" + agentAccountDTO.CheckAgentAcActivated +
                " where UserID = '" + agentAccountDTO.GetAgentAcID + "'";
            Connection.ActionQuery(query);
        }

        public void DeleteAgentAcQuery()
        {
            string query = "delete from AgentAccount where UserID = '" + agentAccountDTO.GetAgentAcID + "'";
            Connection.ActionQuery(query);
        }

        public DataTable SelectAgentAcQuery()
        {
            string s = "select * from AgentAccount";
            return Connection.SelectQuery(s);
        }

        public string GetNewAgentAcID()
        {
            return "";
        }
    }
}
