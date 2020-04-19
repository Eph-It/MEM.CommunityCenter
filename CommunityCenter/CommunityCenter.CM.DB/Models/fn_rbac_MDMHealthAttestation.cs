using System;

namespace CommunityCenter.CM.DB.Models
{
    public class fn_rbac_MDMHealthAttestation
    {
        public string DeviceName { get; set; }

        public string OperatingSystem { get; set; }

        public byte? CodeIntegrityEnabled { get; set; }

        public byte? EarlyLaunchAntiMalware { get; set; }

        public byte? SecureBoot { get; set; }

        public byte? AttestationIdentityKey { get; set; }

        public int? DepPolicy { get; set; }

        public byte? SafeMode { get; set; }

        public byte? WinPeEnvironment { get; set; }

        public byte? VSM { get; set; }

        public byte? BootDebugging { get; set; }

        public byte? KernelDebugging { get; set; }

        public byte? TestSigning { get; set; }

        public int? BootManagerVersion { get; set; }

        public int? CodeIntegrityVersion { get; set; }

        public string PCR0 { get; set; }

        public int DeviceItemKey { get; set; }

        public byte HASSupported { get; set; }

        public int? BitLockerStatus { get; set; }

    }
}

