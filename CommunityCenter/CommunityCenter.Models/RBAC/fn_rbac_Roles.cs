using System;

namespace CommunityCenter.Models.RBAC
{
    public class fn_rbac_Roles
    {
        public string CopiedFromID { get; set; }

        public string CreatedBy { get; set; }

        public DateTime CreatedDate { get; set; }

        public bool IsBuiltIn { get; set; }

        public string ModifiedBy { get; set; }

        public DateTime ModifiedDate { get; set; }

        public string RoleDescription { get; set; }

        public string RoleID { get; set; }

        public string RoleName { get; set; }

        public string SourceSite { get; set; }

        public int NumberOfAdmins { get; set; }

        public int IsSecAdminRole { get; set; }

        public int IsDelAdminRole { get; set; }

    }
}

