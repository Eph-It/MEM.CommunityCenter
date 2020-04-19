using System;

namespace CommunityCenter.CM.DB.Models
{
    public class fn_rbac_CIAssignmentStatus
    {
        public int AssignmentID { get; set; }

        public int ResourceID { get; set; }

        public int UserID { get; set; }

        public byte? LastEnforcementMessageID { get; set; }

        public int? LastEnforcementErrorID { get; set; }

        public int? LastEnforcementErrorCode { get; set; }

        public DateTime? LastEnforcementMessageTime { get; set; }

        public string LastEnforcementBockingID { get; set; }

        public byte? LastEnforcementIsRebootSupressed { get; set; }

        public byte? LastEvaluationMessageID { get; set; }

        public int? LastEvaluationErrorID { get; set; }

        public int? LastEvaluationErrorCode { get; set; }

        public DateTime? LastEvaluationMessageTime { get; set; }

    }
}

