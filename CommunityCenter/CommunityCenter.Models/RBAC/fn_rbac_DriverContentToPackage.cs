using System;

namespace CommunityCenter.Models.RBAC
{
    public class fn_rbac_DriverContentToPackage
    {
        public string PkgID { get; set; }

        public string Name { get; set; }

        public int Content_ID { get; set; }

        public string Content_UniqueID { get; set; }

        public int CI_ID { get; set; }

        public int? ImageFlags { get; set; }

        public int? PackageType { get; set; }

    }
}

