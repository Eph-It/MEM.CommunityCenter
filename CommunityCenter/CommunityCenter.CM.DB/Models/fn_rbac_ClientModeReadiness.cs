using System;

namespace CommunityCenter.CM.DB.Models
{
    public class fn_rbac_ClientModeReadiness
    {
        public int ResourceID { get; set; }

        public bool NativeModeCapable { get; set; }

        public int ErrorCode { get; set; }

        public DateTime LastReportDate { get; set; }

    }
}

