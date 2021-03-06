﻿using System;

namespace CommunityCenter.Models.RBAC
{
    public class fn_rbac_GS_ENCRYPTABLE_VOLUME
    {
        public int ResourceID { get; set; }

        public int GroupID { get; set; }

        public int RevisionID { get; set; }

        public int? AgentID { get; set; }

        public DateTime TimeStamp { get; set; }

        public string DeviceID0 { get; set; }

        public string DriveLetter0 { get; set; }

        public string PersistentVolumeID0 { get; set; }

        public int? ProtectionStatus0 { get; set; }

    }
}

