using System;

namespace CommunityCenter.CM.DB.Models
{
    public class fn_rbac_GS_WORKSTATION_STATUS
    {
        public int ResourceID { get; set; }

        public int GroupID { get; set; }

        public int? RevisionID { get; set; }

        public int? AgentID { get; set; }

        public DateTime TimeStamp { get; set; }

        public DateTime? LastHWScan { get; set; }

        public string LastReportVersion { get; set; }

        public int? SystemDefaultLCID { get; set; }

        public int? TimezoneOffset { get; set; }

    }
}

