using System;

namespace CommunityCenter.Models.RBAC
{
    public class fn_rbac_GS_POWER_MANAGEMENT_CLIENTOPTOUT_SETTINGS
    {
        public int ResourceID { get; set; }

        public int GroupID { get; set; }

        public int RevisionID { get; set; }

        public int? AgentID { get; set; }

        public DateTime TimeStamp { get; set; }

        public int? AdminAllowOptout0 { get; set; }

        public int? EffectiveClientOptOut0 { get; set; }

        public int? IsClientOptOut0 { get; set; }

    }
}

