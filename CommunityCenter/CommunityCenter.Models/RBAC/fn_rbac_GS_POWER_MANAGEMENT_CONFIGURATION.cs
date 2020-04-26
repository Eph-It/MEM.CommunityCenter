using System;

namespace CommunityCenter.Models.RBAC
{
    public class fn_rbac_GS_POWER_MANAGEMENT_CONFIGURATION
    {
        public int ResourceID { get; set; }

        public int GroupID { get; set; }

        public int RevisionID { get; set; }

        public int? AgentID { get; set; }

        public DateTime TimeStamp { get; set; }

        public int? DurationInSec0 { get; set; }

        public string NonPeakPowerPlan0 { get; set; }

        public string NonPeakPowerPlanName0 { get; set; }

        public string PeakPowerPlan0 { get; set; }

        public string PeakPowerPlanName0 { get; set; }

        public string PeakStartTimeHoursMin0 { get; set; }

        public string PowerConfigID0 { get; set; }

        public string WakeUpTimeHoursMin0 { get; set; }

    }
}

