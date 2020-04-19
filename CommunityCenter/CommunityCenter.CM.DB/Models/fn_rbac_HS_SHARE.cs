﻿using System;

namespace CommunityCenter.CM.DB.Models
{
    public class fn_rbac_HS_SHARE
    {
        public int ResourceID { get; set; }

        public int GroupID { get; set; }

        public int RevisionID { get; set; }

        public int? AgentID { get; set; }

        public DateTime TimeStamp { get; set; }

        public string AccessMask0 { get; set; }

        public int? AllowMaximum0 { get; set; }

        public string Caption0 { get; set; }

        public string Description0 { get; set; }

        public DateTime? InstallDate0 { get; set; }

        public int? MaximumAllowed0 { get; set; }

        public string Name0 { get; set; }

        public string Path0 { get; set; }

        public string Status0 { get; set; }

        public int? Type0 { get; set; }

    }
}
