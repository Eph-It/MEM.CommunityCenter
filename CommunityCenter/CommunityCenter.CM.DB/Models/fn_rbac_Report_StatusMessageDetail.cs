using System;

namespace CommunityCenter.CM.DB.Models
{
    public class fn_rbac_Report_StatusMessageDetail
    {
        public long RecordID { get; set; }

        public DateTime Timestamp { get; set; }

        public string SiteCode { get; set; }

        public int MessageID { get; set; }

        public int? ProcessID { get; set; }

        public string System { get; set; }

        public string Source { get; set; }

        public string Component { get; set; }

        public int? Severity { get; set; }

        public string MsgDllName { get; set; }

        public string InsStrValue1 { get; set; }

        public string InsStrValue2 { get; set; }

        public string InsStrValue3 { get; set; }

        public string InsStrValue4 { get; set; }

        public string InsStrValue5 { get; set; }

        public string InsStrValue6 { get; set; }

        public string InsStrValue7 { get; set; }

        public string InsStrValue8 { get; set; }

        public string InsStrValue9 { get; set; }

        public string InsStrValue10 { get; set; }

        public string SeverityString { get; set; }

        public string MessageTypeString { get; set; }

    }
}

