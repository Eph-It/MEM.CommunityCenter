using System;

namespace CommunityCenter.Models.RBAC
{
    public class fn_rbac_usermachinerelation
    {
        public int RelationshipResourceID { get; set; }

        public string UniqueUserName { get; set; }

        public int MachineResourceID { get; set; }

        public int RelationActive { get; set; }

        public DateTime CreationTime { get; set; }

        public DateTime? InactivationTime { get; set; }

        public long rowversion { get; set; }

    }
}

