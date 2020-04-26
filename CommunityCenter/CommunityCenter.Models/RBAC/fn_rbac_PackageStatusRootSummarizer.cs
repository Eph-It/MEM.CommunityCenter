using System;

namespace CommunityCenter.Models.RBAC
{
    public class fn_rbac_PackageStatusRootSummarizer
    {
        public string PackageID { get; set; }

        public string Name { get; set; }

        public int? SourceVersion { get; set; }

        public DateTime? SourceDate { get; set; }

        public int Targeted { get; set; }

        public int Installed { get; set; }

        public int Retrying { get; set; }

        public int Failed { get; set; }

        public string SourceSite { get; set; }

        public int? SourceSize { get; set; }

        public int? SourceCompressedSize { get; set; }

    }
}

