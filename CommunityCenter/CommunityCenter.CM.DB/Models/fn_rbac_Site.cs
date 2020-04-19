using System;

namespace CommunityCenter.CM.DB.Models
{
    public class fn_rbac_Site
    {
        public string SiteCode { get; set; }

        public string SiteName { get; set; }

        public string ReportingSiteCode { get; set; }

        public string Version { get; set; }

        public int? Type { get; set; }

        public int? Status { get; set; }

        public int? RequestedStatus { get; set; }

        public int? BuildNumber { get; set; }

        public string ServerName { get; set; }

        public string InstallDir { get; set; }

        public string TimeZoneInfo { get; set; }

    }
}

