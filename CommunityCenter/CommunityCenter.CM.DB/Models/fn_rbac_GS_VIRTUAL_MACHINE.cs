using System;

namespace CommunityCenter.CM.DB.Models
{
    public class fn_rbac_GS_VIRTUAL_MACHINE
    {
        public int ResourceID { get; set; }

        public int GroupID { get; set; }

        public int RevisionID { get; set; }

        public int? AgentID { get; set; }

        public DateTime TimeStamp { get; set; }

        public string InstanceKey0 { get; set; }

        public string PhysicalHostName0 { get; set; }

        public string PhysicalHostNameFullyQualifi0 { get; set; }

    }
}

