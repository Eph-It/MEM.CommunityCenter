using System;

namespace CommunityCenter.CM.DB.Models
{
    public class fn_rbac_HS_WINDOWSUPDATE
    {
        public int ResourceID { get; set; }

        public int GroupID { get; set; }

        public int RevisionID { get; set; }

        public int? AgentID { get; set; }

        public DateTime TimeStamp { get; set; }

        public int? AUOptions0 { get; set; }

        public string InstanceKey0 { get; set; }

        public int? NoAutoUpdate0 { get; set; }

        public int? UseWUServer0 { get; set; }

    }
}

