﻿using System;

namespace CommunityCenter.Models.RBAC
{
    public class fn_rbac_WakeupProxyDeploymentState
    {
        public string CollectionID { get; set; }

        public int? MachineID { get; set; }

        public int DeploymentState { get; set; }

        public long? ErrorCode { get; set; }

    }
}

