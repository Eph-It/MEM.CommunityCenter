using System;

namespace CommunityCenter.Models.RBAC
{
    public class fn_rbac_LU_Category_Editable
    {
        public int CategoryID { get; set; }

        public int? LanguageID { get; set; }

        public string CategoryName { get; set; }

        public string Description { get; set; }

        public byte Type { get; set; }

        public bool IsDeleted { get; set; }

        public int State { get; set; }

        public int IsLocal { get; set; }

    }
}

