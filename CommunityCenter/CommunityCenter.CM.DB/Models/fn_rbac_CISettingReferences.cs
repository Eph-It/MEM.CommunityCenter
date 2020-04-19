using System;

namespace CommunityCenter.CM.DB.Models
{
    public class fn_rbac_CISettingReferences
    {
        public int Rule_ID { get; set; }

        public int CI_ID { get; set; }

        public int Setting_ID { get; set; }

        public string SettingName { get; set; }

        public string CI_UniqueID { get; set; }

        public bool IsBroken { get; set; }

    }
}

