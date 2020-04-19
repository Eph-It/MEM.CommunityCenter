using System;

namespace CommunityCenter.CM.DB.Models
{
    public class fn_rbac_CIRelation_All
    {
        public int CI_ID { get; set; }

        public int ReferencedCI_ID { get; set; }

        public int RelationType { get; set; }

        public int Level { get; set; }

        public bool IsVersionSpecific { get; set; }

    }
}

