using System;

namespace CommunityCenter.Models.RBAC
{
    public class fn_rbac_CP_Machine
    {
        public int MachineID { get; set; }

        public string Name { get; set; }

        public DateTime? LatestProcessingAttempt { get; set; }

        public int? LastErrorCode { get; set; }

        public string PushSiteCode { get; set; }

        public string AssignedSiteCode { get; set; }

        public DateTime InitialRequestDate { get; set; }

        public string Description { get; set; }

        public int? NumProcessAttempts { get; set; }

        public string ErrorEventCreated { get; set; }

        public int Status { get; set; }

    }
}

