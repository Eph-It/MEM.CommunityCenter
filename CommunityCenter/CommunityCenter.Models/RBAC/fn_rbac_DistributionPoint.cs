using System;

namespace CommunityCenter.Models.RBAC
{
    public class fn_rbac_DistributionPoint
    {
        public string PackageID { get; set; }

        public string SecureObjectID { get; set; }

        public string ServerNALPath { get; set; }

        public string SiteCode { get; set; }

        public int? RefreshNow { get; set; }

        public string SiteName { get; set; }

        public string SourceSite { get; set; }

        public DateTime? LastRefreshTime { get; set; }

        public int? Status { get; set; }

        public int? IsPeerDP { get; set; }

        public int? BitsEnabled { get; set; }

        public int? IsMulticast { get; set; }

        public int IsProtected { get; set; }

        public int? PreStagingAllowed { get; set; }

        public string ResourceType { get; set; }

        public int? PackageType { get; set; }

        public bool? RemoveWDS { get; set; }

        public bool? IsPXE { get; set; }

        public bool? SccmPXE { get; set; }

        public bool? IsActive { get; set; }

        public int? ResponseDelay { get; set; }

        public bool? UdaSetting { get; set; }

        public int? BindPolicy { get; set; }

        public bool? SupportUnknownMachines { get; set; }

        public string PXEPassword { get; set; }

        public string IdentityGUID { get; set; }

        public string BindExcept { get; set; }

        public int? CertificateType { get; set; }

        public string ISVString { get; set; }

        public int? ObjectTypeID { get; set; }

        public int IsCloud { get; set; }

    }
}

