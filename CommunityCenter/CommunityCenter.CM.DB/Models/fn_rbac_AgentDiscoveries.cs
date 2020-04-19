using System;

namespace CommunityCenter.CM.DB.Models
{
    public class fn_rbac_AgentDiscoveries
    {
        public int ResourceType { get; set; }

        public int ResourceId { get; set; }

        public string AgentName { get; set; }

        public string AgentSite { get; set; }

        public DateTime? AgentTime { get; set; }

    }
}

