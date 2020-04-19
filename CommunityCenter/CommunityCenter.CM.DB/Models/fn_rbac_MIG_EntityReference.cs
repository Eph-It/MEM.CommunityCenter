using System;

namespace CommunityCenter.CM.DB.Models
{
    public class fn_rbac_MIG_EntityReference
    {
        public int EntityID { get; set; }

        public int ReferencedEntityID { get; set; }

        public int ReferenceType { get; set; }

        public bool? ReferenceDirection { get; set; }

    }
}

