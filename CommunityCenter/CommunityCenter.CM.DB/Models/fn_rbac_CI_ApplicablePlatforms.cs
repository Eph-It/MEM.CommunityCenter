using System;

namespace CommunityCenter.CM.DB.Models
{
    public class fn_rbac_CI_ApplicablePlatforms
    {
        public int CI_ID { get; set; }

        public string CI_UniqueID { get; set; }

        public string OSDisplayName { get; set; }

        public string OSName { get; set; }

        public string OSMaxVersion { get; set; }

        public string OSMinVersion { get; set; }

        public string OSPlatform { get; set; }

    }
}

