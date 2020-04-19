using System;

namespace CommunityCenter.CM.DB.Models
{
    public class fn_rbac_EndpointProtectionStatus
    {
        public int ResourceID { get; set; }

        public int EpProtected { get; set; }

        public int EpAtRisk { get; set; }

        public int EpNotYetInstalled { get; set; }

        public int EpUnsupported { get; set; }

        public int Inactive { get; set; }

        public int NotClient { get; set; }

        public int AmRemediationFailed { get; set; }

        public int AmFullscanRequired { get; set; }

        public int AmRestartRequired { get; set; }

        public int AmOfflineScanRequired { get; set; }

        public int AmManualStepsRequired { get; set; }

        public int AmRecentlyCleaned { get; set; }

        public int AmThreatActivity { get; set; }

        public int EpInstallFailed { get; set; }

        public int EpEnforcementSucceeded { get; set; }

        public int EpEnforcementFailed { get; set; }

        public int EpPendingReboot { get; set; }

        public int Unhealthy { get; set; }

        public int SignatureUpTo1DayOld { get; set; }

        public int SignatureUpTo3DaysOld { get; set; }

        public int SignatureUpTo7DaysOld { get; set; }

        public int SignatureOlderThan7Days { get; set; }

        public int NoSignature { get; set; }

        public int AmPending { get; set; }

        public int LastScanUpTo2DaysOld { get; set; }

        public int LastScanUpTo8DaysOld { get; set; }

        public int LastScanUpTo31DaysOld { get; set; }

        public int LastScanOver31DaysOld { get; set; }

        public int Healthy { get; set; }

        public int Active { get; set; }

        public int EpUnmanaged { get; set; }

        public int EpToBeInstalled { get; set; }

        public int EpManaged { get; set; }

        public int EpInstalled { get; set; }

        public int EpEnforced { get; set; }

        public int EpEnabled { get; set; }

    }
}

