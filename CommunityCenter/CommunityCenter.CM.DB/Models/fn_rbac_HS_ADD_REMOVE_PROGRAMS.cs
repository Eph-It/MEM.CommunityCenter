using System;

namespace CommunityCenter.CM.DB.Models
{
    public class fn_rbac_HS_ADD_REMOVE_PROGRAMS
    {
        public int ResourceID { get; set; }

        public int GroupID { get; set; }

        public int RevisionID { get; set; }

        public int? AgentID { get; set; }

        public DateTime TimeStamp { get; set; }

        public string DisplayName0 { get; set; }

        public string InstallDate0 { get; set; }

        public string ProdID0 { get; set; }

        public string Publisher0 { get; set; }

        public string Version0 { get; set; }

    }
}

