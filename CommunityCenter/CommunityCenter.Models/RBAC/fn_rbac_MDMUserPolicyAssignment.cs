using System;

namespace CommunityCenter.Models.RBAC
{
    public class fn_rbac_MDMUserPolicyAssignment
    {
        public Guid UserID { get; set; }

        public int PolicyType { get; set; }

        public string PolicyID { get; set; }

        public byte[] PolicyBodyHash { get; set; }

        public DateTime LastUpdateTime { get; set; }

        public int? Reserved { get; set; }

        public int SiteNumber { get; set; }

        public int CI_ID { get; set; }

    }
}

