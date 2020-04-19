using System;

namespace CommunityCenter.CM.DB.Models
{
    public class fn_rbac_HS_MDM_RemoteFind
    {
        public int ResourceID { get; set; }

        public int GroupID { get; set; }

        public int RevisionID { get; set; }

        public int? AgentID { get; set; }

        public DateTime TimeStamp { get; set; }

        public string Latitude0 { get; set; }

        public string Longitude0 { get; set; }

    }
}

