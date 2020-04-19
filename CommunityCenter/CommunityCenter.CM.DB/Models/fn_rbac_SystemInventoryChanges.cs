using System;

namespace CommunityCenter.CM.DB.Models
{
    public class fn_rbac_SystemInventoryChanges
    {
        public string DisplayName { get; set; }

        public string MIFClass { get; set; }

        public int ResourceID { get; set; }

        public int GroupID { get; set; }

        public int RevisionID { get; set; }

        public DateTime TimeStamp { get; set; }

        public string ChangeType { get; set; }

    }
}

