using System;

namespace CommunityCenter.Models.RBAC
{
    public class fn_rbac_WOLGetPendingObjectSchedules
    {
        public int ObjectType { get; set; }

        public string Object { get; set; }

        public string TargetCollection { get; set; }

        public int ApplyToSubTargets { get; set; }

        public DateTime NextScheduleTime { get; set; }

        public int? Timezone { get; set; }

    }
}

