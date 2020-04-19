using System;

namespace CommunityCenter.CM.DB.Models
{
    public class fn_rbac_LocalizedCIProperties_SiteLoc
    {
        public int CI_ID { get; set; }

        public int LocaleID { get; set; }

        public string DisplayName { get; set; }

        public string Description { get; set; }

        public string CIInformativeURL { get; set; }

        public long rowversion { get; set; }

    }
}

