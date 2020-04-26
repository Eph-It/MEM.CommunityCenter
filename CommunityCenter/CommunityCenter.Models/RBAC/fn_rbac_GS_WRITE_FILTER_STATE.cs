using System;

namespace CommunityCenter.Models.RBAC
{
    public class fn_rbac_GS_WRITE_FILTER_STATE
    {
        public int ResourceID { get; set; }

        public int GroupID { get; set; }

        public int RevisionID { get; set; }

        public int? AgentID { get; set; }

        public DateTime TimeStamp { get; set; }

        public int? WriteFilterEnabled0 { get; set; }

    }
}

