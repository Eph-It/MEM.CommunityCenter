using System;

namespace CommunityCenter.Models.RBAC
{
    public class fn_rbac_ClientCollectionMembers
    {
        public string CollectionID { get; set; }

        public int ResourceID { get; set; }

        public string Name { get; set; }

        public string Domain { get; set; }

        public string SiteCode { get; set; }

        public bool IsClient { get; set; }

    }
}

