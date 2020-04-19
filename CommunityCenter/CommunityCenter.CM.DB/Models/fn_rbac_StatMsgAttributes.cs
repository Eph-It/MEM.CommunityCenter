using System;

namespace CommunityCenter.CM.DB.Models
{
    public class fn_rbac_StatMsgAttributes
    {
        public long RecordID { get; set; }

        public short AttributeID { get; set; }

        public string AttributeValue { get; set; }

        public DateTime? AttributeTime { get; set; }

    }
}

