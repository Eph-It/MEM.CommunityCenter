using System;

namespace CommunityCenter.Models.RBAC
{
    public class fn_rbac_HS_SYSTEM_CONSOLE_USER
    {
        public int ResourceID { get; set; }

        public int GroupID { get; set; }

        public int RevisionID { get; set; }

        public int? AgentID { get; set; }

        public DateTime TimeStamp { get; set; }

        public DateTime? LastConsoleUse0 { get; set; }

        public int? NumberOfConsoleLogons0 { get; set; }

        public string SystemConsoleUser0 { get; set; }

        public int? TotalUserConsoleMinutes0 { get; set; }

    }
}

