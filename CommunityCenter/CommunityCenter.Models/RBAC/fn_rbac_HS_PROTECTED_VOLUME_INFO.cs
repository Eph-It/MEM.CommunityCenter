﻿using System;

namespace CommunityCenter.Models.RBAC
{
    public class fn_rbac_HS_PROTECTED_VOLUME_INFO
    {
        public int ResourceID { get; set; }

        public int GroupID { get; set; }

        public int RevisionID { get; set; }

        public int? AgentID { get; set; }

        public DateTime TimeStamp { get; set; }

        public string DriveLetter0 { get; set; }

        public string Name0 { get; set; }

        public int? ProtectionType0 { get; set; }

    }
}

