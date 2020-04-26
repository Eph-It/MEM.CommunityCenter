using System;

namespace CommunityCenter.Models.RBAC
{
    public class fn_rbac_AssignmentStatePerTopic
    {
        public int AssignmentID { get; set; }

        public int ResourceID { get; set; }

        public int TopicType { get; set; }

        public int StateID { get; set; }

        public DateTime? StateTime { get; set; }

        public int? LastStatusMessageID { get; set; }

        public int? LastErrorCode { get; set; }

    }
}

