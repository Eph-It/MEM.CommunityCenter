using System;

namespace CommunityCenter.Models.RBAC
{
    public class fn_rbac_GS_SYSTEM_CONSOLE_USAGE
    {
        public int ResourceID { get; set; }

        public int GroupID { get; set; }

        public int RevisionID { get; set; }

        public int? AgentID { get; set; }

        public DateTime TimeStamp { get; set; }

        public DateTime? SecurityLogStartDate0 { get; set; }

        public string TopConsoleUser0 { get; set; }

        public int? TotalConsoleTime0 { get; set; }

        public int? TotalConsoleUsers0 { get; set; }

        public int? TotalSecurityLogTime0 { get; set; }

    }
}

