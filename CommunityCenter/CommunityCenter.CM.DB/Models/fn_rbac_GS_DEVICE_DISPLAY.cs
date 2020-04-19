using System;

namespace CommunityCenter.CM.DB.Models
{
    public class fn_rbac_GS_DEVICE_DISPLAY
    {
        public int ResourceID { get; set; }

        public int GroupID { get; set; }

        public int RevisionID { get; set; }

        public int? AgentID { get; set; }

        public DateTime TimeStamp { get; set; }

        public int? HorizontalResolution0 { get; set; }

        public string NumberOfColors0 { get; set; }

        public int? VerticalResolution0 { get; set; }

    }
}

