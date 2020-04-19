using System;

namespace CommunityCenter.CM.DB.Models
{
    public class fn_rbac_CIErrorDetails
    {
        public int UserID { get; set; }

        public int ResourceID { get; set; }

        public int CI_ID { get; set; }

        public int? CIVersion { get; set; }

        public int? SettingID { get; set; }

        public int? RuleID { get; set; }

        public int? RuleCIID { get; set; }

        public int? SettingCIID { get; set; }

        public bool? IsRuleValue { get; set; }

        public int? ConflictCode { get; set; }

        public int? ContributionRulesCount { get; set; }

        public long? ErrorCode { get; set; }

        public int Errortype { get; set; }

        public int ConfigPointType { get; set; }

    }
}

