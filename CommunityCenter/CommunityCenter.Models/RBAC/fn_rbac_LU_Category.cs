﻿using System;

namespace CommunityCenter.Models.RBAC
{
    public class fn_rbac_LU_Category
    {
        public int CategoryID { get; set; }

        public int? LanguageID { get; set; }

        public string CategoryName { get; set; }

        public string Description { get; set; }

        public int IsLocal { get; set; }

    }
}

