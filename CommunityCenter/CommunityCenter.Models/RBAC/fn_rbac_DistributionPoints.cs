using System;

namespace CommunityCenter.Models.RBAC
{
    public class fn_rbac_DistributionPoints
    {
        public int DPID { get; set; }

        public string ServerName { get; set; }

        public string NALPath { get; set; }

        public string ShareName { get; set; }

        public string SMSSiteCode { get; set; }

        public int? IsPeerDP { get; set; }

        public int? IsPullDP { get; set; }

        public int? IsPullDPInstalled { get; set; }

        public int? IsFileStreaming { get; set; }

        public int? IsBITS { get; set; }

        public int? IsMulticast { get; set; }

        public int? AnonymousEnabled { get; set; }

        public int? TokenAuthEnabled { get; set; }

        public int? SslState { get; set; }

        public int? DPType { get; set; }

        public int? IsProtected { get; set; }

        public int? PreStagingAllowed { get; set; }

        public string DPDrive { get; set; }

        public int? MinFreeSpace { get; set; }

        public string Type { get; set; }

        public int? Action { get; set; }

        public int? State { get; set; }

        public int? DPFlags { get; set; }

        public string DPCRC { get; set; }

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

        public string Account { get; set; }

        public int? Priority { get; set; }

        public int? TransferRate { get; set; }

        public string Description { get; set; }

        public string ISVString { get; set; }

        public int? Flags { get; set; }

        public int? MaintenanceMode { get; set; }

        public DateTime? MaintenanceModeLastStartTime { get; set; }

        public int? IsDoincEnabled { get; set; }

        public string RoleCapabilities { get; set; }

    }
}

