using System;

namespace CommunityCenter.CM.DB.Models
{
    public class fn_rbac_Permissions
    {
        public int AdminID { get; set; }

        public string CategoryID { get; set; }

        public string RoleID { get; set; }

        public string RoleName { get; set; }

        public string CategoryName { get; set; }

        public string LogonName { get; set; }

        public byte CategoryTypeID { get; set; }

    }
}

