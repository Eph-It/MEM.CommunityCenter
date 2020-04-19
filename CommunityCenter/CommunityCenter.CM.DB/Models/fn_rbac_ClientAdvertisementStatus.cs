using System;

namespace CommunityCenter.CM.DB.Models
{
    public class fn_rbac_ClientAdvertisementStatus
    {
        public string AdvertisementID { get; set; }

        public int ResourceID { get; set; }

        public int? LastAcceptanceMessageIDSeverity { get; set; }

        public int? LastAcceptanceMessageID { get; set; }

        public string LastAcceptanceMessageIDName { get; set; }

        public int? LastAcceptanceState { get; set; }

        public string LastAcceptanceStateName { get; set; }

        public DateTime? LastAcceptanceStatusTime { get; set; }

        public int? LastStatusMessageIDSeverity { get; set; }

        public int? LastStatusMessageID { get; set; }

        public string LastStatusMessageIDName { get; set; }

        public int? LastState { get; set; }

        public string LastStateName { get; set; }

        public DateTime? LastStatusTime { get; set; }

        public string LastExecutionResult { get; set; }

        public string LastExecutionContext { get; set; }

        public int? IsActive { get; set; }

    }
}

