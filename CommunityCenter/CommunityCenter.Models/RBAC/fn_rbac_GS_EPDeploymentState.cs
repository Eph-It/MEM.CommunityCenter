using System;

namespace CommunityCenter.Models.RBAC
{
    public class fn_rbac_GS_EPDeploymentState
    {
        public int ResourceID { get; set; }

        public DateTime LastMessageTime { get; set; }

        public int DeploymentState { get; set; }

        public string Error { get; set; }

        public long? ErrorCode { get; set; }

    }
}

