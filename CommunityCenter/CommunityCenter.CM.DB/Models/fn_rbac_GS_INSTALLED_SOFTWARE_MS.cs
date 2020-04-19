using System;

namespace CommunityCenter.CM.DB.Models
{
    public class fn_rbac_GS_INSTALLED_SOFTWARE_MS
    {
        public int ResourceID { get; set; }

        public int GroupID { get; set; }

        public int RevisionID { get; set; }

        public int? AgentID { get; set; }

        public DateTime TimeStamp { get; set; }

        public string ChannelCode0 { get; set; }

        public string ChannelID0 { get; set; }

        public string MPC0 { get; set; }

        public string SoftwareCode0 { get; set; }

    }
}

