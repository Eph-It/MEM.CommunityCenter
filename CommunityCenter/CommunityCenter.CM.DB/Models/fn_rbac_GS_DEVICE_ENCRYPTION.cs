using System;

namespace CommunityCenter.CM.DB.Models
{
    public class fn_rbac_GS_DEVICE_ENCRYPTION
    {
        public int ResourceID { get; set; }

        public int GroupID { get; set; }

        public int RevisionID { get; set; }

        public int? AgentID { get; set; }

        public DateTime TimeStamp { get; set; }

        public int? EmailEncryptionAlgorithm0 { get; set; }

        public int? EmailEncryptionNegotiation0 { get; set; }

        public int? EmailEncryptionRequired0 { get; set; }

        public int? EmailSigningAlgorithm0 { get; set; }

        public int? EmailSigningRequired0 { get; set; }

        public int? EncryptionCompliance0 { get; set; }

        public int? PhoneMemoryEncrypted0 { get; set; }

        public int? StorageCardEncrypted0 { get; set; }

    }
}

