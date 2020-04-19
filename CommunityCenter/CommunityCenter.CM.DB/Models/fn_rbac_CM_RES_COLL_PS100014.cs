using System;

namespace CommunityCenter.CM.DB.Models
{
    public class fn_rbac_CM_RES_COLL_PS100014
    {
        public int ResourceID { get; set; }

        public byte ResourceType { get; set; }

        public string Name { get; set; }

        public string SMSID { get; set; }

        public string Domain { get; set; }

        public bool IsDirect { get; set; }

        public int IsClient { get; set; }

        public bool IsAssigned { get; set; }

        public int? IsObsolete { get; set; }

        public int? IsActive { get; set; }

        public int IsDecommissioned { get; set; }

        public int? IsApproved { get; set; }

        public bool? IsBlocked { get; set; }

        public bool? SuppressAutoProvision { get; set; }

    }
}

