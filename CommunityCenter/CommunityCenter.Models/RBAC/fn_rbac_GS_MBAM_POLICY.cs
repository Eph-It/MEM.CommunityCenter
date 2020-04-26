using System;

namespace CommunityCenter.Models.RBAC
{
    public class fn_rbac_GS_MBAM_POLICY
    {
        public int ResourceID { get; set; }

        public int GroupID { get; set; }

        public int RevisionID { get; set; }

        public int? AgentID { get; set; }

        public DateTime TimeStamp { get; set; }

        public string EncodedComputerName0 { get; set; }

        public int? EncryptionMethod0 { get; set; }

        public int? FixedDataDriveAutoUnlock0 { get; set; }

        public int? FixedDataDriveEncryption0 { get; set; }

        public int? FixedDataDrivePassphrase0 { get; set; }

        public string KeyName0 { get; set; }

        public string LastConsoleUser0 { get; set; }

        public int? MBAMMachineError0 { get; set; }

        public int? MBAMPolicyEnforced0 { get; set; }

        public int? OsDriveEncryption0 { get; set; }

        public int? OsDriveProtector0 { get; set; }

        public DateTime? UserExemptionDate0 { get; set; }

    }
}

