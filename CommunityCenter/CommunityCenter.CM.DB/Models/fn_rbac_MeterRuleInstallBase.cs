﻿using System;

namespace CommunityCenter.CM.DB.Models
{
    public class fn_rbac_MeterRuleInstallBase
    {
        public int RuleID { get; set; }

        public string ProductName { get; set; }

        public long MeteredFileID { get; set; }

        public int ResourceID { get; set; }

    }
}

