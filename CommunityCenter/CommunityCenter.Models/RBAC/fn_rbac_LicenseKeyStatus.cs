using System;

namespace CommunityCenter.Models.RBAC
{
    public class fn_rbac_LicenseKeyStatus
    {
        public int KeyId { get; set; }

        public int? UserId { get; set; }

        public int DeviceId { get; set; }

        public DateTime LastStatusChangeTime { get; set; }

        public int Status { get; set; }

    }
}

