using System;

namespace CommunityCenter.CM.DB.Models
{
    public class fn_rbac_GS_EMBEDDED_DEVICE_INFO
    {
        public int ResourceID { get; set; }

        public int GroupID { get; set; }

        public int RevisionID { get; set; }

        public int? AgentID { get; set; }

        public DateTime TimeStamp { get; set; }

        public string DeviceType0 { get; set; }

        public string Model0 { get; set; }

        public string OEMName0 { get; set; }

    }
}

