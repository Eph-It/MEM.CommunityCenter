using System;

namespace CommunityCenter.Models.RBAC
{
    public class fn_rbac_StateMigration
    {
        public string MigrationID { get; set; }

        public int MigrationType { get; set; }

        public int MigrationStatus { get; set; }

        public int MigrationBehavior { get; set; }

        public string SourceName { get; set; }

        public int SourceClientResourceID { get; set; }

        public string SourceLastLogonUserName { get; set; }

        public string SourceLastLogonUserDomain { get; set; }

        public DateTime? StoreCreationDate { get; set; }

        public DateTime? StoreDeletionDate { get; set; }

        public string StorePath { get; set; }

        public long? StoreSize { get; set; }

        public string SMPServerName { get; set; }

        public string SiteCode { get; set; }

        public string SourceMACAddresses { get; set; }

        public DateTime? StoreReleaseDate { get; set; }

        public string RestoreName { get; set; }

        public int RestoreClientResourceID { get; set; }

        public string RestoreLastLogonUserName { get; set; }

        public string RestoreLastLogonUserDomain { get; set; }

        public string RestoreMACAddresses { get; set; }

    }
}

