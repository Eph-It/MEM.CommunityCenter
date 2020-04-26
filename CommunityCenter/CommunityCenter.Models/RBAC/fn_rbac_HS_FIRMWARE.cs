using System;

namespace CommunityCenter.Models.RBAC
{
    public class fn_rbac_HS_FIRMWARE
    {
        public int ResourceID { get; set; }

        public int GroupID { get; set; }

        public int RevisionID { get; set; }

        public int? AgentID { get; set; }

        public DateTime TimeStamp { get; set; }

        public int? SecureBoot0 { get; set; }

        public int? UEFI0 { get; set; }

    }
}

