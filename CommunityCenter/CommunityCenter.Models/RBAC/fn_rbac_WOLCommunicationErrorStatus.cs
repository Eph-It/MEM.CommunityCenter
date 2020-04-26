using System;

namespace CommunityCenter.Models.RBAC
{
    public class fn_rbac_WOLCommunicationErrorStatus
    {
        public string MessageDescription { get; set; }

        public DateTime ErrorTime { get; set; }

        public string BatchID { get; set; }

        public string ObjectType { get; set; }

        public string ID { get; set; }

        public int? ErrorCode { get; set; }

    }
}

