﻿using System;

namespace CommunityCenter.Models.RBAC
{
    public class fn_rbac_MIG_EntityReference
    {
        public int EntityID { get; set; }

        public int ReferencedEntityID { get; set; }

        public int ReferenceType { get; set; }

        public bool? ReferenceDirection { get; set; }

    }
}

