using System;

namespace CommunityCenter.CM.DB.Models
{
    public class fn_rbac_CIComplianceSummary
    {
        public string CI_UniqueID { get; set; }

        public int CI_ID { get; set; }

        public int? CountTargeted { get; set; }

        public int? CountCompliant { get; set; }

        public int? FailureCount { get; set; }

        public int? ActivatedCount { get; set; }

        public int? CountNoncompliant { get; set; }

        public int? EnforcedCount { get; set; }

        public int? Severity { get; set; }

        public DateTime? LastSummaryTime { get; set; }

        public string ModelName { get; set; }

    }
}

