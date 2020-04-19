using System;

namespace CommunityCenter.CM.DB.Models
{
    public class fn_rbac_SecuredCategories
    {
        public string CategoryID { get; set; }

        public string CategoryDescription { get; set; }

        public int CategoryTypeID { get; set; }

        public string CategoryName { get; set; }

        public DateTime? ModifiedDate { get; set; }

        public string ModifiedBy { get; set; }

    }
}

