using System;

namespace CommunityCenter.CM.DB.Models
{
    public class fn_rbac_MIG_Job
    {
        public int JobID { get; set; }

        public string JobName { get; set; }

        public string Description { get; set; }

        public string CreatedBy { get; set; }

        public string ModifiedBy { get; set; }

        public DateTime? DateCreated { get; set; }

        public DateTime? DateStarted { get; set; }

        public DateTime? DateEnded { get; set; }

        public DateTime? DateLastUpdated { get; set; }

        public DateTime? DateNextRun { get; set; }

        public int? SourceSiteID { get; set; }

        public string DestinationSiteCode { get; set; }

        public int? Status { get; set; }

        public int Type { get; set; }

        public string ScheduleToken { get; set; }

        public string CustomBootImagePackage_x86 { get; set; }

        public string CustomBootImagePackage_x64 { get; set; }

        public bool? DisableAdvertisements { get; set; }

        public bool? MigrateWithFolders { get; set; }

        public string AdditionalConfiguration { get; set; }

        public string SourceSiteFQDN { get; set; }

        public string SourceSiteCode { get; set; }

        public string DestinationSiteFQDN { get; set; }

        public int? ResolveObjectConflictOption { get; set; }

        public int TotalObjectNumber { get; set; }

        public int MigratedObjectNumber { get; set; }

        public int FailedObjectNumber { get; set; }

        public int SkippedObjectNumber { get; set; }

    }
}

