﻿using System;

namespace CommunityCenter.Models.RBAC
{
    public class fn_rbac_HS_DEVICE_POWER
    {
        public int ResourceID { get; set; }

        public int GroupID { get; set; }

        public int RevisionID { get; set; }

        public int? AgentID { get; set; }

        public DateTime TimeStamp { get; set; }

        public int? BacklightACTimeout0 { get; set; }

        public int? BacklightBatTimeout0 { get; set; }

        public int? BackupPercent0 { get; set; }

        public int? BatteryPercent0 { get; set; }

    }
}

