using System;

namespace CommunityCenter.Models.RBAC
{
    public class fn_rbac_EndpointProtectionHealthStatus_History
    {
        public string CollectionID { get; set; }

        public DateTime StatusTime { get; set; }

        public int? TotalMemberCount { get; set; }

        public int? OverallStatusProtectedCount { get; set; }

        public int? OverallStatusAtRiskCount { get; set; }

        public int? OverallStatusNotYetInstalledCount { get; set; }

        public int? OverallStatusNotSupportedCount { get; set; }

        public int? OverallStatusInactiveCount { get; set; }

        public int? OverallNotClientCount { get; set; }

        public int? InfectedCount { get; set; }

        public int? FullscanRequiredCount { get; set; }

        public int? RestartRequiredCount { get; set; }

        public int? OfflineScanRequiredCount { get; set; }

        public int? ManualStepsRequiredCount { get; set; }

        public int? RecentlyCleanedCount { get; set; }

        public int? ThreatActivityCount { get; set; }

        public int? InstallFailedCount { get; set; }

        public int? ApplyPolicySucceededCount { get; set; }

        public int? ApplyPolicyFailedCount { get; set; }

        public int? InstallRebootPendingCount { get; set; }

        public int? UnhealthyCount { get; set; }

        public int? TotalOperationalIssueCount { get; set; }

        public int? UpTo1DayOldCount { get; set; }

        public int? UpTo3DaysOldCount { get; set; }

        public int? UpTo7DaysOldCount { get; set; }

        public int? OlderThan7DaysCount { get; set; }

        public int? NoSignatureCount { get; set; }

        public int? LastScanUpTo2DaysOldCount { get; set; }

        public int? LastScanUpTo8DaysOldCount { get; set; }

        public int? LastScanUpTo31DaysOldCount { get; set; }

        public int? LastScanOver31DaysOldCount { get; set; }

    }
}

