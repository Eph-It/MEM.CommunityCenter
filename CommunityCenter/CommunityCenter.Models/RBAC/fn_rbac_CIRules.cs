using System;

namespace CommunityCenter.Models.RBAC
{
    public class fn_rbac_CIRules
    {
        public int Rule_ID { get; set; }

        public int RuleType { get; set; }

        public int CI_ID { get; set; }

        public string Rule_UniqueID { get; set; }

        public string RuleName { get; set; }

        public string RuleNameRID { get; set; }

        public string RuleDescription { get; set; }

        public string RuleDescriptionRID { get; set; }

        public string Expression { get; set; }

        public string Criteria { get; set; }

        public int Severity { get; set; }

        public long rowversion { get; set; }

    }
}

