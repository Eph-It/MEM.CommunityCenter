using System;

namespace CommunityCenter.Models.RBAC
{
    public class fn_rbac_AllowOrDenyListViolationData
    {
        public long CurrentComplianceStatusID { get; set; }

        public int MachineID { get; set; }

        public int CI_ID { get; set; }

        public string ApplicationId { get; set; }

        public byte ViolationType { get; set; }

        public DateTime MessageTime { get; set; }

    }
}

