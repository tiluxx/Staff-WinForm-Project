using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class AgentDTO
    {
        private string agentID, agentName, agentEmail, agentPhoneNum, agentAddress;
        private bool agentDeleted;

        public string GetAgentID
        {
            get
            {
                return agentID;
            }
            set
            {
                agentID = value;
            }
        }

        public string GetAgentName
        {
            get
            {
                return agentName;
            }
            set
            {
                agentName = value;
            }
        }

        public string GetAgentEmail
        {
            get
            {
                return agentEmail;
            }
            set
            {
                agentEmail = value;
            }
        }

        public string GetAgentPhoneNum
        {
            get
            {
                return agentPhoneNum;
            }
            set
            {
                agentPhoneNum = value;
            }
        }

        public string GetAgentAddress
        {
            get
            {
                return agentAddress;
            }
            set
            {
                agentAddress = value;
            }
        }
 

        public bool CheckAgentDeleted
        {
            get
            {
                return agentDeleted;
            }
            set
            {
                agentDeleted = value;
            }
        }

        public AgentDTO(
            string AgentID,
            string AgentName,
            string AgentEmail,
            string AgentPhoneNum,
            string AgentAdress,
            bool AgentDeleted)
        {
            this.agentID = AgentID;
            this.agentName = AgentName;
            this.agentEmail = AgentEmail;
            this.agentPhoneNum = AgentPhoneNum;
            this.agentAddress = AgentAdress;
            this.agentDeleted = AgentDeleted;
        }
    }
}
