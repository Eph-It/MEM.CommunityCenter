using System;

namespace CommunityCenter.CM.DB.Models
{
    public class fn_rbac_AAD_Statistics
    {
        public int ID { get; set; }

        public DateTime TimeStamp { get; set; }

        public int? TotalAADTenants { get; set; }

        public int? TotalHybridAADUsers { get; set; }

        public int? TotalAADUsers { get; set; }

        public int? TotalOnPremADUsers { get; set; }

        public int? TotalHyridAADClients { get; set; }

        public int? TotalAADClients { get; set; }

        public int? TotalOnPremADClients { get; set; }

        public int? TotalWorkgroupClients { get; set; }

        public int? TotalHyridAADApprovedClients { get; set; }

        public int? TotalAADApprovedClients { get; set; }

    }
}

