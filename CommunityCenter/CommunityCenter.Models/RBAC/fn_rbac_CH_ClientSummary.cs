using System;

namespace CommunityCenter.Models.RBAC
{
    public class fn_rbac_CH_ClientSummary
    {
        public int ResourceID { get; set; }

        public DateTime? LastOnline { get; set; }

        public string LastMPServerName { get; set; }

        public DateTime? LastDDR { get; set; }

        public DateTime? LastHW { get; set; }

        public DateTime? LastSW { get; set; }

        public DateTime? LastStatusMessage { get; set; }

        public DateTime? LastPolicyRequest { get; set; }

        public DateTime? LastHealthEvaluation { get; set; }

        public short? LastHealthEvaluationResult { get; set; }

        public int IsActiveDDR { get; set; }

        public int IsActiveHW { get; set; }

        public int IsActiveSW { get; set; }

        public int IsActivePolicyRequest { get; set; }

        public int IsActiveStatusMessages { get; set; }

        public int LastEvaluationHealthy { get; set; }

        public int? ClientRemediationSuccess { get; set; }

        public DateTime? LastActiveTime { get; set; }

        public int ClientActiveStatus { get; set; }

        public int? ClientState { get; set; }

        public string ClientStateDescription { get; set; }

        public DateTime? ExpectedNextPolicyRequest { get; set; }

        public Guid? AADDeviceID { get; set; }

    }
}

