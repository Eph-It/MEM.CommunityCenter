using System;

namespace CommunityCenter.CM.DB.Models
{
    public class fn_rbac_GS_SoftwareProduct
    {
        public int ResourceID { get; set; }

        public int? ProductID { get; set; }

        public string CompanyName { get; set; }

        public string ProductName { get; set; }

        public string ProductVersion { get; set; }

        public int? ProductLanguage { get; set; }

    }
}

