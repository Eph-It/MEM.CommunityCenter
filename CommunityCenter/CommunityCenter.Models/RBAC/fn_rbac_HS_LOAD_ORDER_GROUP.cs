using System;

namespace CommunityCenter.Models.RBAC
{
    public class fn_rbac_HS_LOAD_ORDER_GROUP
    {
        public int ResourceID { get; set; }

        public int GroupID { get; set; }

        public int RevisionID { get; set; }

        public int? AgentID { get; set; }

        public DateTime TimeStamp { get; set; }

        public string Caption0 { get; set; }

        public string Description0 { get; set; }

        public int? DriverEnabled0 { get; set; }

        public int? GroupOrder0 { get; set; }

        public DateTime? InstallDate0 { get; set; }

        public string Name0 { get; set; }

        public string Status0 { get; set; }

    }
}

