using System;

namespace CommunityCenter.Models.RBAC
{
    public class fn_rbac_DistributionPointInfo
    {
        public string ServerName { get; set; }

        public string ShareName { get; set; }

        public string Drive { get; set; }

        public string NALPath { get; set; }

        public string SiteCode { get; set; }

        public int? Priority { get; set; }

        public int? TransferRate { get; set; }

        public int IsPeerDP { get; set; }

        public int IsPullDP { get; set; }

        public int BitsEnabled { get; set; }

        public int IsMulticast { get; set; }

        public bool? IsProtected { get; set; }

        public int PreStagingAllowed { get; set; }

        public string ResourceType { get; set; }

        public string SiteName { get; set; }

        public int? DPFlags { get; set; }

        public string Name { get; set; }

        public int ID { get; set; }

        public int? Action { get; set; }

        public int RemoveWDS { get; set; }

        public int IsPXE { get; set; }

        public int SccmPXE { get; set; }

        public int IsActive { get; set; }

        public int ResponseDelay { get; set; }

        public int UdaSetting { get; set; }

        public int BindPolicy { get; set; }

        public int SupportUnknownMachines { get; set; }

        public string PXEPassword { get; set; }

        public string IdentityGUID { get; set; }

        public string BindExcept { get; set; }

        public int CertificateType { get; set; }

        public string OperatingSystem { get; set; }

        public int Communication { get; set; }

        public int GroupCount { get; set; }

        public bool? HasRelationship { get; set; }

        public int InternetFacing { get; set; }

        public int HealthCheckEnabled { get; set; }

        public int HealthCheckPriority { get; set; }

        public string HealthCheckSchedule { get; set; }

        public bool? AddressScheduleEnabled { get; set; }

        public int? RateLimitsEnabled { get; set; }

        public int EnableLEDBAT { get; set; }

        public int ServiceType { get; set; }

        public string Region { get; set; }

        public string Description { get; set; }

        public string Version { get; set; }

        public int MaintenanceMode { get; set; }

        public DateTime? MaintenanceModeLastStartTime { get; set; }

    }
}

