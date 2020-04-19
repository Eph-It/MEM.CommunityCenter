using System;

namespace CommunityCenter.CM.DB.Models
{
    public class fn_rbac_FullCollectionMembership_Valid
    {
        public string CollectionID { get; set; }

        public int ResourceID { get; set; }

        public byte ResourceType { get; set; }

        public string Name { get; set; }

        public string Domain { get; set; }

        public string SMSID { get; set; }

        public string SiteCode { get; set; }

    }
}

