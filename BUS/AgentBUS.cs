using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class AgentBUS
    {
        private DAL.AgentDAL agentDAL;

        public AgentBUS(
            string AgentID,
            string AgentName,
            string AgentEmail,
            string AgentPhoneNum,
            string AgentAdress,
            bool AgentDeleted)
        {
            agentDAL = new DAL.AgentDAL(
                AgentID,
                AgentName,
                AgentEmail,
                AgentPhoneNum,
                AgentAdress,
                AgentDeleted);
        }

        public void AddAgentQuery()
        {
            agentDAL.AddAgentQuery();
        }

        public void UpdateAgentQuery()
        {
            agentDAL.UpdateAgentQuery();
        }

        public void DeleteAgentQuery()
        {
            agentDAL.DeleteAgentQuery();
        }

        public DataTable SelectAgentQuery()
        {
            return agentDAL.SelectAgentQuery();
        }

        public string GetNewStaffID()
        {
            return agentDAL.GetNewAgentID();
        }
    }
}
