using System;

namespace CommunityCenter.Models.RBAC
{
    public class fn_rbac_TaskExecutionStatus
    {
        public string AdvertisementID { get; set; }

        public int ResourceID { get; set; }

        public DateTime ExecutionTime { get; set; }

        public int Step { get; set; }

        public string ActionName { get; set; }

        public string GroupName { get; set; }

        public int? LastStatusMessageID { get; set; }

        public string LastStatusMessageIDName { get; set; }

        public int ExitCode { get; set; }

        public string ActionOutput { get; set; }

    }
}

