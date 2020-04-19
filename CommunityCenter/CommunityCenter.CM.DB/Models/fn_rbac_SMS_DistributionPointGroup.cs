using System;

namespace CommunityCenter.CM.DB.Models
{
    public class fn_rbac_SMS_DistributionPointGroup
    {
        public string GroupID { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public string CreatedBy { get; set; }

        public DateTime CreatedOn { get; set; }

        public string ModifiedBy { get; set; }

        public DateTime ModifiedOn { get; set; }

        public string SourceSite { get; set; }

        public int MemberCount { get; set; }

        public int CollectionCount { get; set; }

        public int ContentCount { get; set; }

        public int OutOfSyncContentCount { get; set; }

        public bool? HasMember { get; set; }

        public bool? HasRelationship { get; set; }

        public bool? ContentInSync { get; set; }

    }
}

