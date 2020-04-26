using System;

namespace CommunityCenter.Models.RBAC
{
    public class fn_rbac_GS_TPM_STATUS
    {
        public int ResourceID { get; set; }

        public int GroupID { get; set; }

        public int RevisionID { get; set; }

        public int? AgentID { get; set; }

        public DateTime TimeStamp { get; set; }

        public int? Information0 { get; set; }

        public int? IsApplicable0 { get; set; }

        public int? IsReady0 { get; set; }

    }
}

