﻿using System;

namespace CommunityCenter.Models.RBAC
{
    public class fn_rbac_UserMachineSourceRelation
    {
        public int RelationshipResourceID { get; set; }

        public int SourceID { get; set; }

        public DateTime CreationTime { get; set; }

        public string CreatedBy { get; set; }

    }
}

