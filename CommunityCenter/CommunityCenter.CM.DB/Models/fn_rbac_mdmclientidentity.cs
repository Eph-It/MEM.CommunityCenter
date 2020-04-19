using System;

namespace CommunityCenter.CM.DB.Models
{
    public class fn_rbac_mdmclientidentity
    {
        public Guid DeviceID { get; set; }

        public int? ClientState { get; set; }

        public int? DeviceType { get; set; }

        public string SiteCode { get; set; }

        public DateTime LastUpdateTime { get; set; }

        public string NetBiosName { get; set; }

        public string DeviceOperatingSystem { get; set; }

        public string Model { get; set; }

        public string Manufacturer { get; set; }

        public string DeviceHWId { get; set; }

        public int SiteNumber { get; set; }

        public string DeviceName { get; set; }

        public int? DeviceOwner { get; set; }

        public string SerialNumber { get; set; }

        public string Imei { get; set; }

    }
}

