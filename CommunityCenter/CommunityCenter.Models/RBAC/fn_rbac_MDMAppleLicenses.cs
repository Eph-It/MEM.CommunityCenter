using System;

namespace CommunityCenter.Models.RBAC
{
    public class fn_rbac_MDMAppleLicenses
    {
        public int? TotalLicenses { get; set; }

        public int? AvailableLicenses { get; set; }

        public DateTime? LastUpdateTime { get; set; }

        public string Title { get; set; }

        public string Publisher { get; set; }

        public string Version { get; set; }

        public DateTime? ReleaseDate { get; set; }

        public string InfoLink { get; set; }

    }
}

