using System;

namespace CommunityCenter.Models.RBAC
{
    public class fn_rbac_GS_BITLOCKER_DETAILS
    {
        public int ResourceID { get; set; }

        public int GroupID { get; set; }

        public int RevisionID { get; set; }

        public int? AgentID { get; set; }

        public DateTime TimeStamp { get; set; }

        public string BitlockerPersistentVolumeId0 { get; set; }

        public int? Compliant0 { get; set; }

        public int? ConversionStatus0 { get; set; }

        public string DeviceId0 { get; set; }

        public string DriveLetter0 { get; set; }

        public int? EncryptionMethod0 { get; set; }

        public string EnforcePolicyDate0 { get; set; }

        public int? IsAutoUnlockEnabled0 { get; set; }

        public string KeyProtectorTypes0 { get; set; }

        public string MbamPersistentVolumeId0 { get; set; }

        public int? MbamVolumeType0 { get; set; }

        public string NoncomplianceDetectedDate0 { get; set; }

        public int? ProtectionStatus0 { get; set; }

        public string ReasonsForNonCompliance0 { get; set; }

    }
}

