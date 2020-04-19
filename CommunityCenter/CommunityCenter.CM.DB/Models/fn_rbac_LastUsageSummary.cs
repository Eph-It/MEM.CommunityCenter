using System;

namespace CommunityCenter.CM.DB.Models
{
    public class fn_rbac_LastUsageSummary
    {
        public string SiteCode { get; set; }

        public DateTime? FileUsageLastSummaryTime { get; set; }

        public DateTime? MonthlyUsageLastSummaryTime { get; set; }

    }
}

