using System;

namespace CommunityCenter.Models.RBAC
{
    public class fn_rbac_StatusMessage
    {
        public long RecordID { get; set; }

        public string ModuleName { get; set; }

        public int? Severity { get; set; }

        public int MessageID { get; set; }

        public int? ReportFunction { get; set; }

        public int? SuccessfulTransaction { get; set; }

        public int? PartOfTransaction { get; set; }

        public int? PerClient { get; set; }

        public int? MessageType { get; set; }

        public int? Win32Error { get; set; }

        public DateTime Time { get; set; }

        public string SiteCode { get; set; }

        public string TopLevelSiteCode { get; set; }

        public string MachineName { get; set; }

        public string Component { get; set; }

        public int? ProcessID { get; set; }

        public int? ThreadID { get; set; }

    }
}

