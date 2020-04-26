using System;

namespace CommunityCenter.Models.RBAC
{
    public class fn_rbac_SMS_CIRelation
    {
        public int FromCIID { get; set; }

        public int? ToCIID { get; set; }

        public int RelationType { get; set; }

        public bool IsVersionSpecific { get; set; }

        public int IsBroken { get; set; }

        public int? Priority { get; set; }

    }
}

