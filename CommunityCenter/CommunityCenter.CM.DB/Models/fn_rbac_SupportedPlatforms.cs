using System;

namespace CommunityCenter.CM.DB.Models
{
    public class fn_rbac_SupportedPlatforms
    {
        public string OSPlatform { get; set; }

        public string OSName { get; set; }

        public string OSMinVersion { get; set; }

        public string OSMaxVersion { get; set; }

        public string DisplayText { get; set; }

        public bool? ClientSupported { get; set; }

    }
}

