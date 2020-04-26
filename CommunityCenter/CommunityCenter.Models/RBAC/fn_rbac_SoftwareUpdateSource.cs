using System;

namespace CommunityCenter.Models.RBAC
{
    public class fn_rbac_SoftwareUpdateSource
    {
        public int UpdateSource_ID { get; set; }

        public string UpdateSource_UniqueID { get; set; }

        public string UpdateSourceName { get; set; }

        public string UpdateSourceDescription { get; set; }

        public string UpdateSourceVersion { get; set; }

        public int? ScanType { get; set; }

        public string ScanMethod { get; set; }

        public string ScanMethodParameters { get; set; }

        public int? SourceContentType { get; set; }

        public string ApplicabilityCondition { get; set; }

        public DateTime? DateCreated { get; set; }

        public DateTime? DateModified { get; set; }

        public string SourceSite { get; set; }

        public string UpdateType { get; set; }

        public string ScanTool_PkgID { get; set; }

        public byte[] PublicKeys { get; set; }

        public bool IsTombstoned { get; set; }

        public bool IsExpired { get; set; }

        public bool IsPublishingEnabled { get; set; }

        public long rowversion { get; set; }

    }
}

