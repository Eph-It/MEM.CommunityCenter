using System;

namespace CommunityCenter.CM.DB.Models
{
    public class fn_rbac_R_User
    {
        public int ResourceID { get; set; }

        public int? ResourceType { get; set; }

        public Guid? AADTenantID { get; set; }

        public Guid? AADUserID { get; set; }

        public DateTime? AD_Object_Creation_Time0 { get; set; }

        public Guid? CloudUserId { get; set; }

        public DateTime? Creation_Date0 { get; set; }

        public string Distinguished_Name0 { get; set; }

        public string Full_Domain_Name0 { get; set; }

        public string Full_User_Name0 { get; set; }

        public string Mail0 { get; set; }

        public string Name0 { get; set; }

        public string Network_Operating_System0 { get; set; }

        public byte[] Object_GUID0 { get; set; }

        public int? Primary_Group_ID0 { get; set; }

        public string SID0 { get; set; }

        public string Unique_User_Name0 { get; set; }

        public int? User_Account_Control0 { get; set; }

        public string User_Name0 { get; set; }

        public string User_Principal_Name0 { get; set; }

        public string Windows_NT_Domain0 { get; set; }

    }
}

