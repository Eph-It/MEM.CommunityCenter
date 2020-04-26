using System;

namespace CommunityCenter.Models.RBAC
{
    public class fn_rbac_HS_BROWSER_USAGE
    {
        public int ResourceID { get; set; }

        public int GroupID { get; set; }

        public int RevisionID { get; set; }

        public int? AgentID { get; set; }

        public DateTime TimeStamp { get; set; }

        public string BrowserName0 { get; set; }

        public int? UsagePercentage0 { get; set; }

    }
}

