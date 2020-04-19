using System;

namespace CommunityCenter.CM.DB.Models
{
    public class fn_rbac_CI_CurrentErrorDetails
    {
        public long RecordID { get; set; }

        public long CurrentComplianceStatusID { get; set; }

        public int? CI_ID { get; set; }

        public int ErrorType { get; set; }

        public int? SettingID { get; set; }

        public bool IsRuleOnSetting { get; set; }

        public long? ErrorCode { get; set; }

        public long rowversion { get; set; }

    }
}

