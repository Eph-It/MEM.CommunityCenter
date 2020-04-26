using System;

namespace CommunityCenter.Models.RBAC
{
    public class fn_rbac_CISettings
    {
        public int Setting_ID { get; set; }

        public int CI_ID { get; set; }

        public string Setting_UniqueID { get; set; }

        public string SettingName { get; set; }

        public string SettingNameRID { get; set; }

        public string SettingDescription { get; set; }

        public string SettingDescriptionRID { get; set; }

        public int SourceType { get; set; }

        public int DataType { get; set; }

        public int ExecutionContext { get; set; }

        public bool? ApplicableAtUserLogon { get; set; }

        public string SettingXml { get; set; }

        public long rowversion { get; set; }

    }
}

