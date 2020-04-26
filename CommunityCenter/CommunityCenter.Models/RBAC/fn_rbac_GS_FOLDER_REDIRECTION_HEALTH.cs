using System;

namespace CommunityCenter.Models.RBAC
{
    public class fn_rbac_GS_FOLDER_REDIRECTION_HEALTH
    {
        public int ResourceID { get; set; }

        public int GroupID { get; set; }

        public int RevisionID { get; set; }

        public int? AgentID { get; set; }

        public DateTime TimeStamp { get; set; }

        public string FolderName0 { get; set; }

        public int? HealthStatus0 { get; set; }

        public DateTime? LastSuccessfulSyncTime0 { get; set; }

        public int? LastSyncStatus0 { get; set; }

        public DateTime? LastSyncTime0 { get; set; }

        public int? OfflineAccessEnabled0 { get; set; }

        public string OfflineFileNameFolderGUID0 { get; set; }

        public int? Redirected0 { get; set; }

        public string SID0 { get; set; }

    }
}

