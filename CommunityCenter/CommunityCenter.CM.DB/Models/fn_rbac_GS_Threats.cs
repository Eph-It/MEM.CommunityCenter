using System;

namespace CommunityCenter.CM.DB.Models
{
    public class fn_rbac_GS_Threats
    {
        public int ResourceID { get; set; }

        public DateTime? DetectionTime { get; set; }

        public DateTime? ActionTime { get; set; }

        public string ProductVersion { get; set; }

        public string DetectionID { get; set; }

        public byte? DetectionSource { get; set; }

        public int? PendingActions { get; set; }

        public string Process { get; set; }

        public string UserName { get; set; }

        public string ThreatName { get; set; }

        public long? ThreatID { get; set; }

        public byte SeverityID { get; set; }

        public byte CategoryID { get; set; }

        public string Path { get; set; }

        public byte? CleaningAction { get; set; }

        public byte? ExecutionStatus { get; set; }

        public bool? ActionSuccess { get; set; }

        public int? ErrorCode { get; set; }

    }
}

