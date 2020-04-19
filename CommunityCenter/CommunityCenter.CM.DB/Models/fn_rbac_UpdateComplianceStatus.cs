using System;

namespace CommunityCenter.CM.DB.Models
{
    public class fn_rbac_UpdateComplianceStatus
    {
        public int CI_ID { get; set; }

        public int ResourceID { get; set; }

        public byte Status { get; set; }

        public DateTime? LastStatusCheckTime { get; set; }

        public DateTime? LastStatusChangeTime { get; set; }

        public byte? EnforcementSource { get; set; }

        public byte? LastEnforcementMessageID { get; set; }

        public DateTime? LastEnforcementMessageTime { get; set; }

        public int? LastEnforcementStatusMsgID { get; set; }

        public int? LastErrorCode { get; set; }

        public DateTime? LastLocalChangeTime { get; set; }

    }
}

