using System;

namespace CommunityCenter.CM.DB.Models
{
    public class fn_rbac_CIComplianceStatusErrorDetail
    {
        public int CI_ID { get; set; }

        public string CI_UniqueID { get; set; }

        public int ResourceID { get; set; }

        public string UserName { get; set; }

        public string FullName { get; set; }

        public string ModelName { get; set; }

        public int CIVersion { get; set; }

        public DateTime? LastComplianceMessageTime { get; set; }

        public string Netbios_Name0 { get; set; }

        public int SettingType { get; set; }

        public int RuleSeverity { get; set; }

        public string Setting_UniqueID { get; set; }

        public string SettingNameRID { get; set; }

        public string SettingDescriptionRID { get; set; }

        public string Rule_UniqueID { get; set; }

        public string RuleNameRID { get; set; }

        public string RuleDescriptionRID { get; set; }

        public int? RuleType { get; set; }

        public string Criteria { get; set; }

        public string ContributingRules { get; set; }

    }
}

