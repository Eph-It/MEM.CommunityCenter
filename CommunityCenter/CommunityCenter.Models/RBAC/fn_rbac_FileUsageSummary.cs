using System;

namespace CommunityCenter.Models.RBAC
{
    public class fn_rbac_FileUsageSummary
    {
        public DateTime IntervalStart { get; set; }

        public byte IntervalWidth { get; set; }

        public long FileID { get; set; }

        public string SiteCode { get; set; }

        public int DistinctUserCount { get; set; }

    }
}

