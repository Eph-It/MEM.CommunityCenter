using System;

namespace CommunityCenter.Models.RBAC
{
    public class fn_rbac_CIRulesAll
    {
        public int ID { get; set; }

        public int CI_ID { get; set; }

        public int Rule_ID { get; set; }

        public int Rule_CI_ID { get; set; }

        public int? Setting_ID { get; set; }

        public int Setting_CI_ID { get; set; }

        public string Setting_UniqueID { get; set; }

        public string Rule_UniqueID { get; set; }

        public bool IsBaselineRule { get; set; }

        public long rowversion { get; set; }

    }
}

