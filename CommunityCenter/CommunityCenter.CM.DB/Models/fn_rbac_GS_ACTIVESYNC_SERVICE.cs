using System;

namespace CommunityCenter.CM.DB.Models
{
    public class fn_rbac_GS_ACTIVESYNC_SERVICE
    {
        public int ResourceID { get; set; }

        public int GroupID { get; set; }

        public int RevisionID { get; set; }

        public int? AgentID { get; set; }

        public DateTime TimeStamp { get; set; }

        public string LastSyncTime0 { get; set; }

        public int? MajorVersion0 { get; set; }

        public int? MinorVersion0 { get; set; }

    }
}

