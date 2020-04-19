using System;

namespace CommunityCenter.CM.DB.Models
{
    public class fn_rbac_HS_DEVICE_OSINFORMATION
    {
        public int ResourceID { get; set; }

        public int GroupID { get; set; }

        public int RevisionID { get; set; }

        public int? AgentID { get; set; }

        public DateTime TimeStamp { get; set; }

        public string Language0 { get; set; }

        public string Platform0 { get; set; }

        public string Version0 { get; set; }

    }
}

