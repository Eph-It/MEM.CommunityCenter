using System;

namespace CommunityCenter.CM.DB.Models
{
    public class fn_rbac_ServiceWindow
    {
        public string CollectionID { get; set; }

        public string ServiceWindowID { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public DateTime StartTime { get; set; }

        public int Duration { get; set; }

        public int RecurrenceType { get; set; }

        public bool IsGMT { get; set; }

        public bool IsEnabled { get; set; }

        public int? ServiceWindowType { get; set; }

    }
}

