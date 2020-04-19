using System;

namespace CommunityCenter.CM.DB.Models
{
    public class fn_rbac_CICurrentComplianceStatus
    {
        public int CI_ID { get; set; }

        public string CI_UniqueID { get; set; }

        public int CIType_ID { get; set; }

        public int ResourceID { get; set; }

        public int ModelId { get; set; }

        public int UserID { get; set; }

        public string UserName { get; set; }

        public string FullName { get; set; }

        public string ModelName { get; set; }

        public int CIVersion { get; set; }

        public int SDMPackageVersion { get; set; }

        public bool? IsApplicable { get; set; }

        public bool? IsDetected { get; set; }

        public byte DesiredState { get; set; }

        public byte ComplianceState { get; set; }

        public bool? IsEnforced { get; set; }

        public short? ComplianceValidationRuleFailures { get; set; }

        public int? ErrorCount { get; set; }

        public int? ConflictCount { get; set; }

        public DateTime? LastComplianceMessageTime { get; set; }

        public byte? MaxNoncomplianceCriticality { get; set; }

        public int? ReificationCount { get; set; }

        public int? CompliantRulesCount { get; set; }

        public short? EnforcementState { get; set; }

        public DateTime? LastEnforcementMessageTime { get; set; }

        public int? LastErrorCode { get; set; }

        public long CI_CurrentComplianceStatusID { get; set; }

    }
}

