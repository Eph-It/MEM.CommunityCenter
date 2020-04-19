using System;

namespace CommunityCenter.CM.DB.Models
{
    public class fn_rbac_WOLCommunicationHistory
    {
        public string MessageDescription { get; set; }

        public DateTime StatusTime { get; set; }

        public string BatchID { get; set; }

        public string ObjectType { get; set; }

        public string ID { get; set; }

        public int? ErrorCode { get; set; }

    }
}

