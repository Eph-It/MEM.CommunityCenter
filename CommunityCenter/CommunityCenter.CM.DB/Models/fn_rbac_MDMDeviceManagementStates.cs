using System;

namespace CommunityCenter.CM.DB.Models
{
    public class fn_rbac_MDMDeviceManagementStates
    {
        public Guid DeviceID { get; set; }

        public byte? Wipe { get; set; }

        public byte? Retire { get; set; }

        public DateTime? InvResync { get; set; }

        public DateTime? StateResync { get; set; }

        public DateTime LastUpdateTime { get; set; }

        public int SiteNumber { get; set; }

        public int? SourceType { get; set; }

        public string UnSignedBlob { get; set; }

        public string SignedBlob { get; set; }

        public DateTime? LastSyncNowTime { get; set; }

        public bool? PersistProvisionedData { get; set; }

    }
}

