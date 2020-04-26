using System;

namespace CommunityCenter.Models.RBAC
{
    public class fn_rbac_CH_EvalResults
    {
        public int ResourceID { get; set; }

        public string NetBiosName { get; set; }

        public DateTime EvalTime { get; set; }

        public string HealthCheckGUID { get; set; }

        public short Result { get; set; }

        public string HealthCheckDescription { get; set; }

        public string ResultDetail { get; set; }

        public int ResultCode { get; set; }

        public int ResultType { get; set; }

    }
}

