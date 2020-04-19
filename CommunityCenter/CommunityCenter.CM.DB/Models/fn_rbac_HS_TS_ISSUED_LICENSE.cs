using System;

namespace CommunityCenter.CM.DB.Models
{
    public class fn_rbac_HS_TS_ISSUED_LICENSE
    {
        public int ResourceID { get; set; }

        public int GroupID { get; set; }

        public int RevisionID { get; set; }

        public int? AgentID { get; set; }

        public DateTime TimeStamp { get; set; }

        public DateTime? ExpirationDate0 { get; set; }

        public DateTime? IssueDate0 { get; set; }

        public int? KeyPackId0 { get; set; }

        public int? LicenseId0 { get; set; }

        public int? LicenseStatus0 { get; set; }

        public string sHardwareId0 { get; set; }

        public string sIssuedToComputer0 { get; set; }

        public string sIssuedToUser0 { get; set; }

    }
}

