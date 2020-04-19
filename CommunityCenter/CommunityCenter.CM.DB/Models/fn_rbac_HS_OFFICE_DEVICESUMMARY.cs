using System;

namespace CommunityCenter.CM.DB.Models
{
    public class fn_rbac_HS_OFFICE_DEVICESUMMARY
    {
        public int ResourceID { get; set; }

        public int GroupID { get; set; }

        public int RevisionID { get; set; }

        public int? AgentID { get; set; }

        public DateTime TimeStamp { get; set; }

        public bool? IsProPlusInstalled0 { get; set; }

        public bool? IsTelemetryEnabled0 { get; set; }

    }
}

