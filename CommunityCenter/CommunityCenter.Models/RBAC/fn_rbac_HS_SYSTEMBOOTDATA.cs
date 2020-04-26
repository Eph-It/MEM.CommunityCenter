using System;

namespace CommunityCenter.Models.RBAC
{
    public class fn_rbac_HS_SYSTEMBOOTDATA
    {
        public int ResourceID { get; set; }

        public int GroupID { get; set; }

        public int RevisionID { get; set; }

        public int? AgentID { get; set; }

        public DateTime TimeStamp { get; set; }

        public int? BiosDuration0 { get; set; }

        public int? BootDiskMediaType0 { get; set; }

        public int? BootDuration0 { get; set; }

        public int? EventLogStart0 { get; set; }

        public int? GPDuration0 { get; set; }

        public string OSVersion0 { get; set; }

        public long? SystemStartTime0 { get; set; }

        public int? UpdateDuration0 { get; set; }

    }
}

