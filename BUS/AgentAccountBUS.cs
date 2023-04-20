using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class AgentAccountBUS
    {
        private DAL.AgentAccountDAL agentAccountDAL;

        public AgentAccountBUS(
            string AgentAcID,
            string AgentAcName,
            string AgentAcPass,
            bool AgentAcActivated,
            bool AgentAcDeleted)
        {
            agentAccountDAL = new DAL.AgentAccountDAL(
                AgentAcID,
                AgentAcName,
                AgentAcPass,
                AgentAcActivated,
                AgentAcDeleted);
        }

        public void AddAgentAcQuery()
        {
            agentAccountDAL.AddAgentAcQuery();
        }

        public void UpdateAgentAcQuery()
        {
            agentAccountDAL.UpdateAgentAcQuery();
        }

        public void DeleteAgentAcQuery()
        {
            agentAccountDAL.DeleteAgentAcQuery();
        }

        public DataTable SelectAgentAcQuery()
        {
            return agentAccountDAL.SelectAgentAcQuery();
        }

        public string GetNewAgentAcID()
        {
            return agentAccountDAL.GetNewAgentAcID();
        }
    }
}
