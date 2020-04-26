using System;

namespace CommunityCenter.Models.RBAC
{
    public class fn_rbac_CICurrentRuleDetail
    {
        public long RecordID { get; set; }

        public long CurrentComplianceStatusID { get; set; }

        public int? SettingID { get; set; }

        public int? Setting_CI_ID { get; set; }

        public bool IsRuleOnSetting { get; set; }

        public int RuleID { get; set; }

        public string PreReifiedValue { get; set; }

        public string PostReifiedValue { get; set; }

        public int DetailType { get; set; }

        public int? ContributionRulesCount { get; set; }

        public string InstanceData { get; set; }

        public int? ConflictCode { get; set; }

        public string ContributingRules { get; set; }

        public bool IsRuleValue { get; set; }

        public long rowversion { get; set; }

    }
}

