using System;

namespace CommunityCenter.CM.DB.Models
{
    public class fn_rbac_MeteredFiles
    {
        public int RuleID { get; set; }

        public string SecurityKey { get; set; }

        public string ProductName { get; set; }

        public string Comment { get; set; }

        public string SiteCode { get; set; }

        public string SourceSite { get; set; }

        public bool ApplyToChildSites { get; set; }

        public string OriginalFileName { get; set; }

        public string FileName { get; set; }

        public string FileVersion { get; set; }

        public int LanguageID { get; set; }

        public bool Enabled { get; set; }

        public long MeteredFileID { get; set; }

        public int? MeteredProductID { get; set; }

        public string MeteredFileName { get; set; }

        public string MeteredFileVersion { get; set; }

        public int? MeteredProductLanguage { get; set; }

    }
}

