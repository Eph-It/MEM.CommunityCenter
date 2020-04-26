using System;

namespace CommunityCenter.Models.RBAC
{
    public class fn_rbac_GS_DEVICE_INFO
    {
        public int ResourceID { get; set; }

        public int GroupID { get; set; }

        public int RevisionID { get; set; }

        public int? AgentID { get; set; }

        public DateTime TimeStamp { get; set; }

        public string CertExpiry0 { get; set; }

        public string DeviceName0 { get; set; }

        public string Manufacturer0 { get; set; }

        public string Model0 { get; set; }

        public string OS0 { get; set; }

    }
}

