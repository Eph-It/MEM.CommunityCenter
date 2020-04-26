using System;

namespace CommunityCenter.Models.RBAC
{
    public class fn_rbac_CIToContent
    {
        public int CI_ID { get; set; }

        public string SDMMethodType { get; set; }

        public int ContentID { get; set; }

        public string Content_UniqueID { get; set; }

        public int ContentVersion { get; set; }

        public string ContentHash { get; set; }

        public int? ContentHashVersion { get; set; }

        public string ContentDescription { get; set; }

        public int ContentDownloaded { get; set; }

        public string CI_UniqueID { get; set; }

        public int? SecuredTypeID { get; set; }

        public string ModelName { get; set; }

        public string SecuredModelName { get; set; }

    }
}

