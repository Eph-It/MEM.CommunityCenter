using System;

namespace CommunityCenter.Models.RBAC
{
    public class fn_rbac_CIComplianceStatusComplianceDetail
    {
        public int CI_ID { get; set; }

        public int ModelId { get; set; }

        public string CI_UniqueID { get; set; }

        public int ResourceID { get; set; }

        public int CIVersion { get; set; }

        public byte ComplianceState { get; set; }

        public int? Setting_ID { get; set; }

        public int Rule_ID { get; set; }

        public int Setting_CI_ID { get; set; }

        public int Rule_CI_ID { get; set; }

        public int UserID { get; set; }

        public string PreReifiedValue { get; set; }

        public int SubRuleState { get; set; }

    }
}

