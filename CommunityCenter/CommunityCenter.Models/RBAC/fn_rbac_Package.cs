using System;

namespace CommunityCenter.Models.RBAC
{
    public class fn_rbac_Package
    {
        public string PackageID { get; set; }

        public string Name { get; set; }

        public string Version { get; set; }

        public string Language { get; set; }

        public string Manufacturer { get; set; }

        public string PreDownloadRule { get; set; }

        public string Description { get; set; }

        public int? PkgSourceFlag { get; set; }

        public string PkgSourcePath { get; set; }

        public string StoredPkgPath { get; set; }

        public int? SourceVersion { get; set; }

        public DateTime? SourceDate { get; set; }

        public int? ShareType { get; set; }

        public string ShareName { get; set; }

        public string SourceSite { get; set; }

        public int? ForcedDisconnectEnabled { get; set; }

        public int? ForcedDisconnectNumRetries { get; set; }

        public int? ForcedDisconnectDelay { get; set; }

        public int? Priority { get; set; }

        public string PreferredAddressType { get; set; }

        public int? IgnoreAddressSchedule { get; set; }

        public DateTime? LastRefreshTime { get; set; }

        public int? PkgFlags { get; set; }

        public string MIFFilename { get; set; }

        public string MIFPublisher { get; set; }

        public string MIFName { get; set; }

        public string MIFVersion { get; set; }

        public int ActionInProgress { get; set; }

        public int? ImageFlags { get; set; }

        public int? PackageType { get; set; }

        public string SecurityKey { get; set; }

        public int ObjectTypeID { get; set; }

        public int? TransformReadiness { get; set; }

        public DateTime TransformAnalysisDate { get; set; }

    }
}

