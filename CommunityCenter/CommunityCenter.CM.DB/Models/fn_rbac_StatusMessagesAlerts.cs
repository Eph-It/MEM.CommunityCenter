using System;

namespace CommunityCenter.CM.DB.Models
{
    public class fn_rbac_StatusMessagesAlerts
    {
        public long RecordID { get; set; }

        public int? MachineID { get; set; }

        public string MachineName { get; set; }

        public string ModuleName { get; set; }

        public int? Win32Error { get; set; }

        public DateTime Time { get; set; }

        public string SiteCode { get; set; }

        public string TopLevelSiteCode { get; set; }

        public string Component { get; set; }

        public int? ProcessID { get; set; }

        public int? ThreadID { get; set; }

        public int? Severity { get; set; }

        public int MessageID { get; set; }

        public int? ReportFunction { get; set; }

        public int? SuccessfulTransaction { get; set; }

        public int? PartOfTransaction { get; set; }

        public int? PerClient { get; set; }

        public int? MessageType { get; set; }

        public string Username { get; set; }

        public int AlertID { get; set; }

        public string TypeID { get; set; }

        public string FeatureArea { get; set; }

        public string TypeInstanceID { get; set; }

        public string Name { get; set; }

        public int? AlertSeverity { get; set; }

    }
}

