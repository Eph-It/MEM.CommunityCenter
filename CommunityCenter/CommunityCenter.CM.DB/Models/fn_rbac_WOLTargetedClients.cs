using System;

namespace CommunityCenter.CM.DB.Models
{
    public class fn_rbac_WOLTargetedClients
    {
        public int ObjectType { get; set; }

        public string ObjectID { get; set; }

        public int ResourceID { get; set; }

        public string AssignedSite { get; set; }

        public int? CurrentTimezone { get; set; }

    }
}

