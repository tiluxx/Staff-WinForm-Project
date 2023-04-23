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
            string AgentID,
            string AgentAcName,
            string AgentAcEmail,
            bool AgentAcActivated,
            bool AgentAcDeleted)
        {
            agentAccountDTO = new DTO.AgentAccountDTO(
                AgentID,
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

            int isActivated = 1;
            if (!agentAccountDTO.CheckAgentAcActivated)
            {
                isActivated = 0;
            }

            string query = "insert into UserAccount values ('" +
                agentAccountDTO.GetAgentAcName +
                "', '" + agentAccountDTO.GetAgentAcPass +
                "', " + isActivated +
                ", " + isDeleted + ")";
            Connection.ActionQuery(query);

            query = "insert into AgentAccount values ('" +
                agentAccountDTO.GetAgentAcName +
                "', '" + agentAccountDTO.GetAgentID + "')";
            Connection.ActionQuery(query);
        }

        public void UpdateAgentAcQuery()
        {
            int isActivated = 1;
            if (!agentAccountDTO.CheckAgentAcActivated)
            {
                isActivated = 0;
            }
            string query = "update UserAccount set" +
                " UserPassword = '" + agentAccountDTO.GetAgentAcPass +
                "', Activated = " + isActivated +
                " where UserName = '" + agentAccountDTO.GetAgentAcName + "'";
            Connection.ActionQuery(query);
        }

        public void DeleteAgentAcQuery()
        {
            string query = "delete from AgentAccount where AgentACID = '" + agentAccountDTO.GetAgentAcName + "'";
            Connection.ActionQuery(query);

            query = "delete from UserAccount where UserName = '" + agentAccountDTO.GetAgentAcName + "'";
            Connection.ActionQuery(query);
        }

        public DataTable SelectAgentAcQuery()
        {
            string s = "select U.UserName as 'Agent username', U.Activated as 'Activation'" +
                " from AgentAccount A, UserAccount U where A.AgentACID = U.UserName";
            return Connection.SelectQuery(s);
        }

        public DataTable SelectAgentAcByIDQuery(string agentID)
        {
            string s = "select U.UserName as 'Agent username', U.UserPassword as 'Agent password', U.Activated as 'Activation'" +
                " from AgentAccount A, UserAccount U where A.AgentID = '" + agentID + "' and A.AgentACID = U.UserName";
            return Connection.SelectQuery(s);
        }
    }
}
