using System;

namespace CommunityCenter.Models.RBAC
{
    public class fn_rbac_LU_CAL_ProductList
    {
        public string SoftwareCode { get; set; }

        public string SoftwareHash { get; set; }

        public string ProductCategory { get; set; }

        public int LicenseType { get; set; }

        public DateTime LastUpdated { get; set; }

        public bool IsDeleted { get; set; }

    }
}

