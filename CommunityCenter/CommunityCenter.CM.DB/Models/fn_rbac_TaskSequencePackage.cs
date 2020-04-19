using System;

namespace CommunityCenter.CM.DB.Models
{
    public class fn_rbac_TaskSequencePackage
    {
        public string PackageID { get; set; }

        public string Name { get; set; }

        public string Version { get; set; }

        public string Language { get; set; }

        public string Manufacturer { get; set; }

        public string PreDownloadRule { get; set; }

        public string Description { get; set; }

        public string PkgSourcePath { get; set; }

        public string SourceSite { get; set; }

        public string StoredPkgPath { get; set; }

        public string RefreshSchedule { get; set; }

        public DateTime? LastRefreshTime { get; set; }

        public string ShareName { get; set; }

        public string PreferredAddressType { get; set; }

        public int StoredPkgVersion { get; set; }

        public int? PkgSourceFlag { get; set; }

        public int? ShareType { get; set; }

        public int? Permission { get; set; }

        public int? ForcedDisconnectEnabled { get; set; }

        public int? ForcedDisconnectNumRetries { get; set; }

        public int? ForcedDisconnectDelay { get; set; }

        public int? IgnoreAddressSchedule { get; set; }

        public int? Priority { get; set; }

        public int? PkgFlags { get; set; }

        public string MIFFilename { get; set; }

        public string MIFPublisher { get; set; }

        public string MIFName { get; set; }

        public string MIFVersion { get; set; }

        public int? SourceVersion { get; set; }

        public DateTime? SourceDate { get; set; }

        public int? SourceSize { get; set; }

        public int? SourceCompSize { get; set; }

        public int UpdateMask { get; set; }

        public int ActionInProgress { get; set; }

        public byte[] Icon { get; set; }

        public string Hash { get; set; }

        public byte[] ExtData { get; set; }

        public int? ImageFlags { get; set; }

        public int? PackageType { get; set; }

        public int UpdateMaskEx { get; set; }

        public byte[] ISVData { get; set; }

        public int? HashVersion { get; set; }

        public string NewHash { get; set; }

        public string Category { get; set; }

        public string DependentProgram { get; set; }

        public int? ProgramFlags { get; set; }

        public int? Duration { get; set; }

        public string ProgramName { get; set; }

        public int? TS_Type { get; set; }

        public string BootImageID { get; set; }

        public int? TS_Flags { get; set; }

        public int TS_ID { get; set; }

        public string CustomProgressMsg { get; set; }

        public string ISVString { get; set; }

        public string CustomHighImpactWarning { get; set; }

        public string CustomHighImpactHeadline { get; set; }

        public string CustomHighImpactWarningTop { get; set; }

        public string CustomHighImpactWarningInstall { get; set; }

        public string LocalizedTaskSequenceName { get; set; }

        public string LocalizedTaskSequenceDescription { get; set; }

        public int? HighImpactTaskSequence { get; set; }

        public int? CustomHighImpactSet { get; set; }

        public int? RestartRequired { get; set; }

        public int? EstimatedDownloadSizeMB { get; set; }

        public int? EstimatedRunTimeMinutes { get; set; }

    }
}

