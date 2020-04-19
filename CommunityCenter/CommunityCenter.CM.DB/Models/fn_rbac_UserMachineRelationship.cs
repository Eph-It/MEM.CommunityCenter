using System;

namespace CommunityCenter.CM.DB.Models
{
    public class fn_rbac_UserMachineRelationship
    {
        public int RelationshipResourceID { get; set; }

        public string UniqueUserName { get; set; }

        public int MachineResourceID { get; set; }

        public int RelationActive { get; set; }

        public DateTime CreationTime { get; set; }

        public string MachineResourceName { get; set; }

        public int? MachineResourceClientType { get; set; }

    }
}

