using System;

namespace CommunityCenter.CM.DB.Models
{
    public class fn_rbac_GS_POWER_MANAGEMENT_SETTINGS
    {
        public int ResourceID { get; set; }

        public int GroupID { get; set; }

        public int RevisionID { get; set; }

        public int? AgentID { get; set; }

        public DateTime TimeStamp { get; set; }

        public string ACSettingIndex0 { get; set; }

        public string ACValue0 { get; set; }

        public string DCSettingIndex0 { get; set; }

        public string DCValue0 { get; set; }

        public string GUID0 { get; set; }

        public string Name0 { get; set; }

        public string UnitSpecifier0 { get; set; }

    }
}

