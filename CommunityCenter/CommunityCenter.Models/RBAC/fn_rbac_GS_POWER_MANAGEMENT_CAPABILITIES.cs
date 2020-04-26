using System;

namespace CommunityCenter.Models.RBAC
{
    public class fn_rbac_GS_POWER_MANAGEMENT_CAPABILITIES
    {
        public int ResourceID { get; set; }

        public int GroupID { get; set; }

        public int RevisionID { get; set; }

        public int? AgentID { get; set; }

        public DateTime TimeStamp { get; set; }

        public int? ApmPresent0 { get; set; }

        public int? BatteriesAreShortTerm0 { get; set; }

        public int? FullWake0 { get; set; }

        public int? LidPresent0 { get; set; }

        public string MinDeviceWakeState0 { get; set; }

        public int? PreferredPMProfile0 { get; set; }

        public int? ProcessorThrottle0 { get; set; }

        public string RtcWake0 { get; set; }

        public int? SystemBatteriesPresent0 { get; set; }

        public int? SystemS10 { get; set; }

        public int? SystemS20 { get; set; }

        public int? SystemS30 { get; set; }

        public int? SystemS40 { get; set; }

        public int? SystemS50 { get; set; }

        public int? UpsPresent0 { get; set; }

        public int? VideoDimPresent0 { get; set; }

    }
}

