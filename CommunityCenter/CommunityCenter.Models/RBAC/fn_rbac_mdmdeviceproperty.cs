﻿using System;

namespace CommunityCenter.Models.RBAC
{
    public class fn_rbac_mdmdeviceproperty
    {
        public Guid DeviceID { get; set; }

        public string PropertyName { get; set; }

        public string PropertyValue { get; set; }

        public DateTime LastUpdateTime { get; set; }

        public int SiteNumber { get; set; }

    }
}

