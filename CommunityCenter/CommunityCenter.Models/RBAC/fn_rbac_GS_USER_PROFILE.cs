using System;

namespace CommunityCenter.Models.RBAC
{
    public class fn_rbac_GS_USER_PROFILE
    {
        public int ResourceID { get; set; }

        public int GroupID { get; set; }

        public int RevisionID { get; set; }

        public int? AgentID { get; set; }

        public DateTime TimeStamp { get; set; }

        public int? HealthStatus0 { get; set; }

        public string LastAttemptedProfileDownload0 { get; set; }

        public string LastAttemptedProfileUploadTi0 { get; set; }

        public string LastBackgroundRegistryUpload0 { get; set; }

        public DateTime? LastDownloadTime0 { get; set; }

        public DateTime? LastUploadTime0 { get; set; }

        public DateTime? LastUseTime0 { get; set; }

        public int? Loaded0 { get; set; }

        public string LocalPath0 { get; set; }

        public int? RefCount0 { get; set; }

        public int? RoamingConfigured0 { get; set; }

        public string RoamingPath0 { get; set; }

        public int? RoamingPreference0 { get; set; }

        public string SID0 { get; set; }

        public int? Special0 { get; set; }

        public int? Status0 { get; set; }

    }
}

