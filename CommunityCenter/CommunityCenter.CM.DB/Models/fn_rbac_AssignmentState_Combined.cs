using System;

namespace CommunityCenter.CM.DB.Models
{
    public class fn_rbac_AssignmentState_Combined
    {
        public int AssignmentID { get; set; }

        public int ResourceID { get; set; }

        public int? StateType { get; set; }

        public int? StateID { get; set; }

        public DateTime StateTime { get; set; }

        public int? LastStatusMessageID { get; set; }

        public int? LastErrorCode { get; set; }

    }
}

