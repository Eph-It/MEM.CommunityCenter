using System;

namespace CommunityCenter.CM.DB.Models
{
    public class fn_rbac_DM_WipeRecords
    {
        public string DeviceName { get; set; }

        public string DeviceOwner { get; set; }

        public string WipeRequestor { get; set; }

        public DateTime RequestTime { get; set; }

        public DateTime? SuccessTime { get; set; }

        public int? WipeChannel { get; set; }

        public string SiteCode { get; set; }

    }
}

