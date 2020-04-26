using System;

namespace CommunityCenter.Models.RBAC
{
    public class fn_rbac_CI_CurrentComplianceStatus
    {
        public long CI_CurrentComplianceStatusID { get; set; }

        public int ModelID { get; set; }

        public int ItemKey { get; set; }

        public int UserID { get; set; }

        public int? CIVersion { get; set; }

        public bool? IsApplicable { get; set; }

        public bool? IsDetected { get; set; }

        public bool? IsEnforced { get; set; }

        public byte DesiredState { get; set; }

        public byte ComplianceState { get; set; }

        public short? ComplianceValidationRuleFailures { get; set; }

        public DateTime? LastComplianceMessageTime { get; set; }

        public DateTime? LastComplianceScanTime { get; set; }

        public short? EnforcementState { get; set; }

        public DateTime? LastEnforcementMessageTime { get; set; }

        public byte? MaxNoncomplianceCriticality { get; set; }

        public int? ExtendedInfoCode { get; set; }

        public int? ReificationCount { get; set; }

        public int? ConflictCount { get; set; }

        public int? CompliantRulesCount { get; set; }

        public int? ErrorCount { get; set; }

        public short? LastLaunchStateID { get; set; }

        public DateTime? LastLaunchStateMessageTime { get; set; }

        public long rowversion { get; set; }

        public int CI_ID { get; set; }

        public string ModelName { get; set; }

    }
}

