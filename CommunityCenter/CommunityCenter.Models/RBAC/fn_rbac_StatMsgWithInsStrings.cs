using System;

namespace CommunityCenter.Models.RBAC
{
    public class fn_rbac_StatMsgWithInsStrings
    {
        public long RecordID { get; set; }

        public int? ResourceID { get; set; }

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

        public string InsString1 { get; set; }

        public string InsString2 { get; set; }

        public string InsString3 { get; set; }

        public string InsString4 { get; set; }

        public string InsString5 { get; set; }

        public string InsString6 { get; set; }

        public string InsString7 { get; set; }

        public string InsString8 { get; set; }

        public string InsString9 { get; set; }

        public string InsString10 { get; set; }

    }
}

