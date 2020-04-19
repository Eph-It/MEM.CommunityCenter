using System;

namespace CommunityCenter.CM.DB.Models
{
    public class fn_rbac_GS_OFFICE_DOCUMENTMETRIC
    {
        public int ResourceID { get; set; }

        public int GroupID { get; set; }

        public int RevisionID { get; set; }

        public int? AgentID { get; set; }

        public DateTime TimeStamp { get; set; }

        public string OfficeApp0 { get; set; }

        public int? TotalCloudDocs0 { get; set; }

        public int? TotalLegacyDocs0 { get; set; }

        public int? TotalLocalDocs0 { get; set; }

        public int? TotalMacroDocs0 { get; set; }

        public int? TotalNonMacroDocs0 { get; set; }

        public int? TotalUncDocs0 { get; set; }

    }
}

