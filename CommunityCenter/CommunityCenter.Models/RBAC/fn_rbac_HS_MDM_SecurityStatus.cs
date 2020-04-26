using System;

namespace CommunityCenter.Models.RBAC
{
    public class fn_rbac_HS_MDM_SecurityStatus
    {
        public int ResourceID { get; set; }

        public int GroupID { get; set; }

        public int RevisionID { get; set; }

        public int? AgentID { get; set; }

        public DateTime TimeStamp { get; set; }

        public int? HardwareEncryptionCaps0 { get; set; }

        public int? PasscodeCompliant0 { get; set; }

        public int? PasscodeCompliantWithProfile0 { get; set; }

        public int? PasscodePresent0 { get; set; }

        public int? RequireEncryption0 { get; set; }

    }
}

