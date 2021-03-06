﻿using System;

namespace CommunityCenter.Models.RBAC
{
    public class fn_rbac_CM_RES_COLL_SMS00004
    {
        public int ResourceID { get; set; }

        public byte ResourceType { get; set; }

        public string Name { get; set; }

        public string SMSID { get; set; }

        public string Domain { get; set; }

        public bool IsDirect { get; set; }

        public int? IsClient { get; set; }

        public bool IsAssigned { get; set; }

        public int? IsObsolete { get; set; }

        public int? IsActive { get; set; }

        public int IsDecommissioned { get; set; }

        public int? IsApproved { get; set; }

        public int? IsBlocked { get; set; }

        public int? SuppressAutoProvision { get; set; }

    }
}

