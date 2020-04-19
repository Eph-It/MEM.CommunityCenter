using System;

namespace CommunityCenter.CM.DB.Models
{
    public class fn_rbac_HS_DEVICE_WLAN
    {
        public int ResourceID { get; set; }

        public int GroupID { get; set; }

        public int RevisionID { get; set; }

        public int? AgentID { get; set; }

        public DateTime TimeStamp { get; set; }

        public int? Enabled0 { get; set; }

        public string EthernetMAC0 { get; set; }

        public string WiFiMAC0 { get; set; }

    }
}

