using System;

namespace CommunityCenter.Models.RBAC
{
    public class fn_rbac_HS_DEVICE_EMAIL
    {
        public int ResourceID { get; set; }

        public int GroupID { get; set; }

        public int RevisionID { get; set; }

        public int? AgentID { get; set; }

        public DateTime TimeStamp { get; set; }

        public string OwnerEmailAddress0 { get; set; }

        public string SyncDomain0 { get; set; }

        public string SyncServer0 { get; set; }

        public string SyncUser0 { get; set; }

        public string Type0 { get; set; }

    }
}

