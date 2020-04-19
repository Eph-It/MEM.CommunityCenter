using System;

namespace CommunityCenter.CM.DB.Models
{
    public class fn_rbac_DeviceClientHealthState
    {
        public string DeviceClientID { get; set; }

        public string DeviceNetBiosName { get; set; }

        public string DeviceID { get; set; }

        public string AssignedSiteCode { get; set; }

        public int HealthType { get; set; }

        public int HealthState { get; set; }

        public string Error { get; set; }

        public string ExtendedError { get; set; }

        public DateTime LastHealthReportDate { get; set; }

        public string PhoneNumber { get; set; }

        public string IMEINumber { get; set; }

        public string IPAddress { get; set; }

        public string IPSubnet { get; set; }

        public string OwnerName { get; set; }

        public string OwnerTelephone { get; set; }

        public string OwnerEmail { get; set; }

        public string OwnerNotes { get; set; }

    }
}

