using System;

namespace CommunityCenter.Models.RBAC
{
    public class fn_rbac_CIComplianceStatusConflictsDetail
    {
        public int ModelID { get; set; }

        public int ResourceID { get; set; }

        public int UserID { get; set; }

        public int? CIVersion { get; set; }

        public int? SDMPackageVersion { get; set; }

        public DateTime? LastComplianceMessageTime { get; set; }

        public bool IsRuleOnSetting { get; set; }

        public string InstanceData { get; set; }

        public string CurrentValue { get; set; }

        public int? ContributionRulesCount { get; set; }

        public int RuleID { get; set; }

        public int? SettingID { get; set; }

        public int? Setting_CI_ID { get; set; }

        public bool IsRuleValue { get; set; }

        public string ContributingRules { get; set; }

        public int? ConflictCode { get; set; }

    }
}

