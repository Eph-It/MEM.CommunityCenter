using System;

namespace CommunityCenter.CM.DB.Models
{
    public class fn_rbac_UpdateState_Combined
    {
        public int CI_ID { get; set; }

        public int ResourceID { get; set; }

        public int StateType { get; set; }

        public byte? StateID { get; set; }

        public DateTime? StateTime { get; set; }

        public byte? EnforcementSource { get; set; }

        public int? LastEnforcementStatusMsgID { get; set; }

        public int? LastErrorCode { get; set; }

    }
}

