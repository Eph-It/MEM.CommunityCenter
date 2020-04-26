using System;

namespace CommunityCenter.Models.RBAC
{
    public class fn_rbac_MIG_Entities
    {
        public int? EntityState { get; set; }

        public int? DashboardState { get; set; }

        public string StateName { get; set; }

        public int? NextRunJobID { get; set; }

        public DateTime? NextRunTime { get; set; }

        public int EntityID { get; set; }

        public string EntityName { get; set; }

        public int? Status { get; set; }

        public int SourceSiteID { get; set; }

        public string ExcludedBy { get; set; }

        public int? ObjectTypeID { get; set; }

        public string ObjectKey { get; set; }

        public string WMIObjectPath { get; set; }

        public bool? IsExcluded { get; set; }

        public string UniqueID { get; set; }

        public byte[] SourceSiteRowVersion { get; set; }

        public byte[] MigratedRowVersion { get; set; }

        public int? IsActive { get; set; }

        public int? ChangedAffinity { get; set; }

        public int? Type { get; set; }

    }
}

