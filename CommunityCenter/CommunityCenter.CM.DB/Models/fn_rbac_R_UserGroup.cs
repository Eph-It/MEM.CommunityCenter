using System;

namespace CommunityCenter.CM.DB.Models
{
    public class fn_rbac_R_UserGroup
    {
        public int ResourceID { get; set; }

        public int? ResourceType { get; set; }

        public Guid? AADGroupID { get; set; }

        public Guid? AADTenantID { get; set; }

        public string AD_Domain_Name0 { get; set; }

        public DateTime? Creation_Date0 { get; set; }

        public int? Group_Type0 { get; set; }

        public string Name0 { get; set; }

        public string Network_Operating_System0 { get; set; }

        public byte[] Object_GUID0 { get; set; }

        public string SID0 { get; set; }

        public string Unique_Usergroup_Name0 { get; set; }

        public string Usergroup_Name0 { get; set; }

        public string Windows_NT_Domain0 { get; set; }

    }
}

