using System;

namespace CommunityCenter.CM.DB.Models
{
    public class fn_rbac_ClientHealthState
    {
        public string SMSID { get; set; }

        public string FQDN { get; set; }

        public string NetBiosName { get; set; }

        public string AssignedSiteCode { get; set; }

        public int HealthType { get; set; }

        public int HealthState { get; set; }

        public string HealthStateName { get; set; }

        public int ErrorCode { get; set; }

        public int ExtendedErrorCode { get; set; }

        public DateTime LastHealthReportDate { get; set; }

    }
}

