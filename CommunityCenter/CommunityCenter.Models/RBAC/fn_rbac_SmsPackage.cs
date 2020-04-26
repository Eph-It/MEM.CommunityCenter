using System;

namespace CommunityCenter.Models.RBAC
{
    public class fn_rbac_SmsPackage
    {
        public string PkgID { get; set; }

        public string Name { get; set; }

        public string Version { get; set; }

        public string Language { get; set; }

        public string Manufacturer { get; set; }

        public string PreDownloadRule { get; set; }

        public string DriverManufacturer { get; set; }

        public string DriverModel { get; set; }

        public string DriverOSVersion { get; set; }

        public string BaseBoardProductID { get; set; }

        public string DriverPkgVersion { get; set; }

        public string Description { get; set; }

        public string Source { get; set; }

        public string SourceSite { get; set; }

        public string StoredPkgPath { get; set; }

        public string RefreshSchedule { get; set; }

        public DateTime? LastRefresh { get; set; }

        public string ShareName { get; set; }

        public string PreferredAddress { get; set; }

        public int StoredPkgVersion { get; set; }

        public int? StorePkgFlag { get; set; }

        public int? ShareType { get; set; }

        public int? Permission { get; set; }

        public int? UseForcedDisconnect { get; set; }

        public int? ForcedRetryDelay { get; set; }

        public int? DisconnectDelay { get; set; }

        public int? IgnoreSchedule { get; set; }

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

        public int Action { get; set; }

        public byte[] Icon { get; set; }

        public string Hash { get; set; }

        public byte[] ExtData { get; set; }

        public int? ImageFlags { get; set; }

        public int UpdateMaskEx { get; set; }

        public byte[] ISVData { get; set; }

        public int? HashVersion { get; set; }

        public string NewHash { get; set; }

        public string ImagePath { get; set; }

        public string Architecture { get; set; }

        public int? PackageType { get; set; }

        public string AlternateContentProviders { get; set; }

        public int? DefaultImage { get; set; }

        public int? SourceLocaleID { get; set; }

        public string SEDOComponentID { get; set; }

        public int? TransformReadiness { get; set; }

        public DateTime TransformAnalysisDate { get; set; }

        public string SedoObjectVersion { get; set; }

        public string EncryptionKey { get; set; }

        public int? EncryptionAlgorithm { get; set; }

        public string CryptoExtInfo { get; set; }

        public long rowversion { get; set; }

        public int? MinRequiredVersion { get; set; }

        public string ISVString { get; set; }

        public int NumOfPrograms { get; set; }

        public int IsPredefinedPackage { get; set; }

    }
}

