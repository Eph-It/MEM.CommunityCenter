using System;

namespace CommunityCenter.CM.DB.Models
{
    public class fn_rbac_MIG_Clients
    {
        public int SourceSiteID { get; set; }

        public int SourceSiteItemKey { get; set; }

        public int? ArchitectureKey { get; set; }

        public string ClientName { get; set; }

        public string SMSID { get; set; }

        public int? ResourceID { get; set; }

        public int ClientState { get; set; }

        public int DashboardState { get; set; }

        public string StateName { get; set; }

        public bool? IsDeleted { get; set; }

        public bool? IsActive { get; set; }

        public bool? IsApproved { get; set; }

        public bool? IsBlocked { get; set; }

        public bool? IsClient { get; set; }

        public string ClientVersion { get; set; }

        public string OperatingSystem { get; set; }

        public string HardwareID { get; set; }

        public byte[] SourceSiteRowVersion { get; set; }

        public int? MigrationState { get; set; }

        public DateTime? DateMigrated { get; set; }

    }
}

