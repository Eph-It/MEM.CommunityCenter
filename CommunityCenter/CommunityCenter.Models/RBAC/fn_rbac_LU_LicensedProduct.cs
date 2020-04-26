using System;

namespace CommunityCenter.Models.RBAC
{
    public class fn_rbac_LU_LicensedProduct
    {
        public int LicensedProductID { get; set; }

        public string ProductPool { get; set; }

        public string FamilyName { get; set; }

        public string ProductName { get; set; }

        public string VersionCode { get; set; }

        public int VersionSequence { get; set; }

        public DateTime LastUpdated { get; set; }

    }
}

