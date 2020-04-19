using System;

namespace CommunityCenter.CM.DB.Models
{
    public class fn_rbac_GS_DEVICE_POLICY
    {
        public int ResourceID { get; set; }

        public int GroupID { get; set; }

        public int RevisionID { get; set; }

        public int? AgentID { get; set; }

        public DateTime TimeStamp { get; set; }

        public int? Enforced0 { get; set; }

        public string Name0 { get; set; }

    }
}

