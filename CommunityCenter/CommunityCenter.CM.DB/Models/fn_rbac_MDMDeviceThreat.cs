using System;

namespace CommunityCenter.CM.DB.Models
{
    public class fn_rbac_MDMDeviceThreat
    {
        public long MDMDeviceThreatID { get; set; }

        public Guid ThreatID { get; set; }

        public Guid DeviceId { get; set; }

        public Guid AadAccountId { get; set; }

        public int ThreatSeverity { get; set; }

        public int EntityType { get; set; }

        public int ThreatStatus { get; set; }

        public int ThreatType { get; set; }

        public int Classification { get; set; }

        public string Description { get; set; }

        public string DeepLinkUrl { get; set; }

        public DateTime LastUpdateTime { get; set; }

        public int ThreatSource { get; set; }

        public string PartnerFriendlyName { get; set; }

        public int SiteNumber { get; set; }

        public int ItemKey { get; set; }

    }
}

