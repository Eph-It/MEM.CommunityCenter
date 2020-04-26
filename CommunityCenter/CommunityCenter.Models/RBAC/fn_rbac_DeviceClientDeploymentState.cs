using System;

namespace CommunityCenter.Models.RBAC
{
    public class fn_rbac_DeviceClientDeploymentState
    {
        public string DeviceClientID { get; set; }

        public string DeviceNetBiosName { get; set; }

        public string DeviceID { get; set; }

        public int? DeviceDeploymentState { get; set; }

        public string DeviceDeploymentMessage { get; set; }

        public DateTime? DeviceDeploymentTime { get; set; }

        public string AssignedSiteCode { get; set; }

        public string DeviceClientVersion { get; set; }

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

