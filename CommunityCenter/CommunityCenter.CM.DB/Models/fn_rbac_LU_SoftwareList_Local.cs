using System;

namespace CommunityCenter.CM.DB.Models
{
    public class fn_rbac_LU_SoftwareList_Local
    {
        public string SoftwareID { get; set; }

        public string CommonName { get; set; }

        public string CommonVersion { get; set; }

        public string CommonPublisher { get; set; }

        public int? CategoryID { get; set; }

        public int? FamilyID { get; set; }

        public int? Tag1ID { get; set; }

        public int? Tag2ID { get; set; }

        public int? Tag3ID { get; set; }

        public int? LocaleID { get; set; }

        public DateTime LastUpdated { get; set; }

        public string ParentSoftwareID { get; set; }

        public string ParentSoftwarePropertiesHash { get; set; }

    }
}

