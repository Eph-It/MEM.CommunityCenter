using System;

namespace CommunityCenter.Models.RBAC
{
    public class fn_rbac_UpdateCIs
    {
        public int CI_ID { get; set; }

        public string CI_UniqueID { get; set; }

        public int ModelId { get; set; }

        public string ModelName { get; set; }

        public int SDMPackageVersion { get; set; }

        public string SDMPackageDigest { get; set; }

        public int CIType_ID { get; set; }

        public int CIVersion { get; set; }

        public DateTime DateCreated { get; set; }

        public DateTime? DateLastModified { get; set; }

        public string LastModifiedBy { get; set; }

        public string CreatedBy { get; set; }

        public int PermittedUses { get; set; }

        public bool IsBundle { get; set; }

        public bool IsHidden { get; set; }

        public bool IsTombstoned { get; set; }

        public bool IsUserDefined { get; set; }

        public bool IsEnabled { get; set; }

        public bool IsExpired { get; set; }

        public string SourceSite { get; set; }

        public string ContentSourcePath { get; set; }

        public string ApplicabilityCondition { get; set; }

        public string CI_CRC { get; set; }

        public int? Precedence { get; set; }

        public long? ConfigurationFlags { get; set; }

        public int EULAExists { get; set; }

        public byte EULAAccepted { get; set; }

        public DateTime? EULASignoffDate { get; set; }

        public string EULASignoffUser { get; set; }

        public int IsQuarantined { get; set; }

        public int? EffectiveDate { get; set; }

        public int? ModifiedTime { get; set; }

        public int IsDeployed { get; set; }

        public int IsSuperseded { get; set; }

        public int IsChild { get; set; }

        public int InUse { get; set; }

        public bool IsLatest { get; set; }

        public int IsBroken { get; set; }

        public int PlatformType { get; set; }

        public int IsUserCI { get; set; }

        public byte[] RevisionTag { get; set; }

        public int IsSignificantRevision { get; set; }

        public string SedoObjectVersion { get; set; }

        public bool? ApplicableAtUserLogon { get; set; }

        public string BulletinID { get; set; }

        public string ArticleID { get; set; }

        public int? Severity { get; set; }

        public int? CustomSeverity { get; set; }

        public int? CMTag { get; set; }

        public DateTime? DatePosted { get; set; }

        public DateTime? DateRevised { get; set; }

        public int? RevisionNumber { get; set; }

        public int? MaxExecutionTime { get; set; }

        public bool? RequiresExclusiveHandling { get; set; }

        public int? UpdateSource_ID { get; set; }

        public int? MinSourceVersion { get; set; }

    }
}

