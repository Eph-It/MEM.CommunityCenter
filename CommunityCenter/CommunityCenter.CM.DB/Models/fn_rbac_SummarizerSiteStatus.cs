using System;

namespace CommunityCenter.CM.DB.Models
{
    public class fn_rbac_SummarizerSiteStatus
    {
        public string SiteCode { get; set; }

        public int? Status { get; set; }

        public DateTime? Updated { get; set; }

        public int? AvailabilityState { get; set; }

    }
}

