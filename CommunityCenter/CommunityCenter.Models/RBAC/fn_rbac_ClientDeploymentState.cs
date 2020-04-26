using System;

namespace CommunityCenter.Models.RBAC
{
    public class fn_rbac_ClientDeploymentState
    {
        public string SMSID { get; set; }

        public string FQDN { get; set; }

        public string NetBiosName { get; set; }

        public DateTime? LastMessageTime { get; set; }

        public int? LastMessageStateID { get; set; }

        public string LastMessageParam { get; set; }

        public DateTime? DeploymentBeginTime { get; set; }

        public DateTime? DeploymentEndTime { get; set; }

        public DateTime? AssignmentBeginTime { get; set; }

        public DateTime? AssignmentEndTime { get; set; }

        public string AssignedSiteCode { get; set; }

        public string ClientVersion { get; set; }

        public string StateDescription { get; set; }

        public string RebootNeeded { get; set; }

    }
}

