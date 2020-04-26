using System;

namespace CommunityCenter.Models.RBAC
{
    public class fn_rbac_CIComplianceStatusReificationDetail
    {
        public int ModelID { get; set; }

        public int ItemKey { get; set; }

        public int? CIVersion { get; set; }

        public int? SDMPackageVersion { get; set; }

        public int? RuleType { get; set; }

        public string InstanceData { get; set; }

        public string PreReifiedValue { get; set; }

        public string PostReifiedValue { get; set; }

        public int RuleID { get; set; }

        public int? SettingID { get; set; }

        public int? Setting_CI_ID { get; set; }

        public bool IsRuleValue { get; set; }

        public int? ContributionRulesCount { get; set; }

        public int UserID { get; set; }

        public string ContributingRules { get; set; }

    }
}

