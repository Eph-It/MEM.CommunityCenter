using System;

namespace CommunityCenter.CM.DB.Models
{
    public class fn_rbac_HS_DEVICE_CERTIFICATES
    {
        public int ResourceID { get; set; }

        public int GroupID { get; set; }

        public int RevisionID { get; set; }

        public int? AgentID { get; set; }

        public DateTime TimeStamp { get; set; }

        public string IssuedBy0 { get; set; }

        public string IssuedTo0 { get; set; }

        public string Thumbprint0 { get; set; }

        public string Type0 { get; set; }

        public DateTime? ValidFrom0 { get; set; }

        public DateTime? ValidTo0 { get; set; }

    }
}

