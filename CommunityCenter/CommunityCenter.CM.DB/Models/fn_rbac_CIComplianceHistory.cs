using System;

namespace CommunityCenter.CM.DB.Models
{
    public class fn_rbac_CIComplianceHistory
    {
        public string CI_UniqueID { get; set; }

        public int CI_ID { get; set; }

        public int CIVersion { get; set; }

        public int SDMPackageVersion { get; set; }

        public int ResourceID { get; set; }

        public string UserName { get; set; }

        public string FullName { get; set; }

        public int UserID { get; set; }

        public DateTime ComplianceStartDate { get; set; }

        public DateTime? ComplianceEndDate { get; set; }

        public bool? IsApplicable { get; set; }

        public bool IsDetected { get; set; }

        public bool IsCompliant { get; set; }

        public bool? IsError { get; set; }

        public byte DesiredState { get; set; }

        public short ComplianceValidationRuleFailures { get; set; }

        public int? ReificationCount { get; set; }

        public int? ErrorCount { get; set; }

        public byte MaxNoncomplianceCriticality { get; set; }

        public string ModelName { get; set; }

    }
}

