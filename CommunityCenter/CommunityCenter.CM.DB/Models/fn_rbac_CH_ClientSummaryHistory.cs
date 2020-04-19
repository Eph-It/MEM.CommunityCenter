using System;

namespace CommunityCenter.CM.DB.Models
{
    public class fn_rbac_CH_ClientSummaryHistory
    {
        public DateTime Date { get; set; }

        public string CollectionID { get; set; }

        public string SiteCode { get; set; }

        public int ClientsTotal { get; set; }

        public int ClientsActive { get; set; }

        public int ClientsInactive { get; set; }

        public int ClientsActiveDDR { get; set; }

        public int ClientsActiveHW { get; set; }

        public int ClientsActiveSW { get; set; }

        public int ClientsActivePolicyRequest { get; set; }

        public int ClientsActiveStatusMessage { get; set; }

        public int ClientsHealthy { get; set; }

        public int ClientsUnhealthy { get; set; }

        public int ClientsHealthUnknown { get; set; }

        public int ClientsRemediationSuccess { get; set; }

        public int ClientsRemediationTotal { get; set; }

        public int ClientsActiveHealthyOrActiveNoResults { get; set; }

        public int? ClientsInactiveUsingIntune { get; set; }

    }
}

