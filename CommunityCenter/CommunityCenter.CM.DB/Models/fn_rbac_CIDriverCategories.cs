﻿using System;

namespace CommunityCenter.CM.DB.Models
{
    public class fn_rbac_CIDriverCategories
    {
        public int CI_ID { get; set; }

        public int CategoryInstanceID { get; set; }

        public string CategoryInstance_UniqueID { get; set; }

        public string CategoryTypeName { get; set; }

        public DateTime? DateLastModified { get; set; }

        public string SourceSite { get; set; }

        public int? ParentCategoryInstanceID { get; set; }

        public bool IsDeleted { get; set; }

        public long rowversion { get; set; }

    }
}

