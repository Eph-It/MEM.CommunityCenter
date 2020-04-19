using System;

namespace CommunityCenter.CM.DB.Models
{
    public class fn_rbac_Admins
    {
        public int AdminID { get; set; }

        public string AdminSID { get; set; }

        public string LogonName { get; set; }

        public string DistinguishedName { get; set; }

        public string DisplayName { get; set; }

        public bool IsGroup { get; set; }

        public bool IsDeleted { get; set; }

        public string CreatedBy { get; set; }

        public DateTime CreatedDate { get; set; }

        public string ModifiedBy { get; set; }

        public DateTime ModifiedDate { get; set; }

        public string SourceSite { get; set; }

        public string SKey { get; set; }

        public short AccountType { get; set; }

    }
}

