using System;

namespace CommunityCenter.Models.RBAC
{
    public class fn_rbac_GS_POWER_MANAGEMENT_MONTH
    {
        public int ResourceID { get; set; }

        public int GroupID { get; set; }

        public int RevisionID { get; set; }

        public int? AgentID { get; set; }

        public DateTime TimeStamp { get; set; }

        public int? minutesComputerActive0 { get; set; }

        public int? minutesComputerOn0 { get; set; }

        public int? minutesComputerShutdown0 { get; set; }

        public int? minutesComputerSleep0 { get; set; }

        public int? minutesMonitorOn0 { get; set; }

        public int? minutesTotal0 { get; set; }

        public DateTime? MonthStart0 { get; set; }

        public string TypeOfEvent0 { get; set; }

    }
}

