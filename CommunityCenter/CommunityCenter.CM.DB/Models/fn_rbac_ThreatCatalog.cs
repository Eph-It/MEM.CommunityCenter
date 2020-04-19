using System;

namespace CommunityCenter.CM.DB.Models
{
    public class fn_rbac_ThreatCatalog
    {
        public long ThreatID { get; set; }

        public string Name { get; set; }

        public int SeverityID { get; set; }

        public int CategoryID { get; set; }

        public int SummaryID { get; set; }

        public int DefaultActionID { get; set; }

        public byte IsAV { get; set; }

        public long VersionFirstUpdated { get; set; }

    }
}

