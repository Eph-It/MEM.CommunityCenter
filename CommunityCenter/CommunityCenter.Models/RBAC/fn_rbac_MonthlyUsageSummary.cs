using System;

namespace CommunityCenter.Models.RBAC
{
    public class fn_rbac_MonthlyUsageSummary
    {
        public int TimeKey { get; set; }

        public int ResourceID { get; set; }

        public long FileID { get; set; }

        public int MeteredUserID { get; set; }

        public int UsageCount { get; set; }

        public int TSUsageCount { get; set; }

        public int UsageTime { get; set; }

        public DateTime LastUsage { get; set; }

    }
}

