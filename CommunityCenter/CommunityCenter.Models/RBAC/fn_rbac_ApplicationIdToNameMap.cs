using System;

namespace CommunityCenter.Models.RBAC
{
    public class fn_rbac_ApplicationIdToNameMap
    {
        public int CI_ID { get; set; }

        public string ApplicationId { get; set; }

        public int AgentEdition { get; set; }

        public string Name { get; set; }

        public short ViolationType { get; set; }

    }
}

