using System;

namespace CommunityCenter.CM.DB.Models
{
    public class fn_rbac_CategoryPermissions
    {
        public int AdminID { get; set; }

        public byte[] AdminSID { get; set; }

        public string ObjectTypeName { get; set; }

        public byte ObjectTypeID { get; set; }

        public int? GrantedOperations { get; set; }

        public string CategoryID { get; set; }

        public byte CategoryTypeID { get; set; }

    }
}

