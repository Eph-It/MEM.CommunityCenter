using System;

namespace CommunityCenter.Models.RBAC
{
    public class fn_rbac_securedobjecttypes
    {
        public byte ObjectTypeID { get; set; }

        public string ObjectTypeName { get; set; }

        public int AvailableOperations { get; set; }

        public bool InternalOnly { get; set; }

        public int IsTypeWideClass { get; set; }

    }
}

