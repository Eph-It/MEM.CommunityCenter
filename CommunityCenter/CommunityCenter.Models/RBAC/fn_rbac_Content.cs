using System;

namespace CommunityCenter.Models.RBAC
{
    public class fn_rbac_Content
    {
        public string PkgID { get; set; }

        public int Content_ID { get; set; }

        public string Content_UniqueID { get; set; }

        public int ContentVersion { get; set; }

        public long? SourceSize { get; set; }

        public string ContentHash { get; set; }

        public int? ContentHashVersion { get; set; }

        public string ContentDescription { get; set; }

        public string SourceSite { get; set; }

        public int? ContentFlags { get; set; }

        public string ContentSource { get; set; }

        public int? ContentType { get; set; }

        public string RelatedContentID { get; set; }

        public long rowversion { get; set; }

        public string ModelName { get; set; }

        public string SecurityKey { get; set; }

        public int? ObjectTypeID { get; set; }

    }
}

