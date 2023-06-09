﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class AgentAccountDTO
    {
        private string agentID, agentAcName, agentAcPass;
        private bool agentAcDeleted, agentAcActivated;

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

        public string GetAgentAcName
        {
            get
            {
                return agentAcName;
            }
            set
            {
                agentAcName = value;
            }
        }

        public string GetAgentAcPass
        {
            get
            {
                return agentAcPass;
            }
            set
            {
                agentAcPass = value;
            }
        }

        public bool CheckAgentAcActivated
        {
            get
            {
                return agentAcActivated;
            }
            set
            {
                agentAcActivated = value;
            }
        }

        public bool CheckAgentAcDeleted
        {
            get
            {
                return agentAcDeleted;
            }
            set
            {
                agentAcDeleted = value;
            }
        }

        public AgentAccountDTO(
            string AgentID,
            string AgentAcName,
            string AgentAcPass,
            bool AgentAcActivated,
            bool AgentAcDeleted)
        {
            this.agentID = AgentID;
            this.agentAcName = AgentAcName;
            this.agentAcPass = AgentAcPass;
            this.agentAcActivated = AgentAcActivated;
            this.agentAcDeleted = AgentAcDeleted;
        }
    }
}
