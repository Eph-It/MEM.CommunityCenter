using System;

namespace CommunityCenter.Models.RBAC
{
    public class fn_rbac_MeteredProductRule
    {
        public int RuleID { get; set; }

        public string SecurityKey { get; set; }

        public string ProductName { get; set; }

        public string OriginalFileName { get; set; }

        public string FileName { get; set; }

        public string FileVersion { get; set; }

        public int LanguageID { get; set; }

        public bool Enabled { get; set; }

        public string SiteCode { get; set; }

        public bool ApplyToChildSites { get; set; }

        public DateTime LastUpdateTime { get; set; }

        public string Comment { get; set; }

        public string SourceSite { get; set; }

    }
}

