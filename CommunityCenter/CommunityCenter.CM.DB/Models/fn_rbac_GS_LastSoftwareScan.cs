﻿using System;

namespace CommunityCenter.CM.DB.Models
{
    public class fn_rbac_GS_LastSoftwareScan
    {
        public int ResourceID { get; set; }

        public int LastScanOpCode { get; set; }

        public DateTime? LastScanDate { get; set; }

        public DateTime? LastCollectedFileScanDate { get; set; }

    }
}

