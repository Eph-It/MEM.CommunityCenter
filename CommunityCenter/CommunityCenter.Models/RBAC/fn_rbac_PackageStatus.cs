using System;

namespace CommunityCenter.Models.RBAC
{
    public class fn_rbac_PackageStatus
    {
        public string PackageID { get; set; }

        public int Type { get; set; }

        public string SiteCode { get; set; }

        public string PkgServer { get; set; }

        public int Personality { get; set; }

        public int? Status { get; set; }

        public DateTime? UpdateTime { get; set; }

        public string Location { get; set; }

        public string ShareName { get; set; }

        public string InstallStatus { get; set; }

    }
}

