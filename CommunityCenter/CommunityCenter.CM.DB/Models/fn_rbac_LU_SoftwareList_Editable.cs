using System;

namespace CommunityCenter.CM.DB.Models
{
    public class fn_rbac_LU_SoftwareList_Editable
    {
        public string SoftwareKey { get; set; }

        public string CommonName { get; set; }

        public string CommonPublisher { get; set; }

        public string CommonVersion { get; set; }

        public int? Count { get; set; }

        public int CategoryID { get; set; }

        public string CategoryName { get; set; }

        public int FamilyID { get; set; }

        public string FamilyName { get; set; }

        public int OfficialCategoryID { get; set; }

        public string OfficialCategoryName { get; set; }

        public int OfficialFamilyID { get; set; }

        public string OfficialFamilyName { get; set; }

        public int? Tag1ID { get; set; }

        public string Tag1Name { get; set; }

        public int? Tag2ID { get; set; }

        public string Tag2Name { get; set; }

        public int? Tag3ID { get; set; }

        public string Tag3Name { get; set; }

        public int State { get; set; }

        public int IsDeleted { get; set; }

        public string ParentCommonName { get; set; }

        public string ParentSoftwareID { get; set; }

    }
}

