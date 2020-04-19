using System;

namespace CommunityCenter.CM.DB.Models
{
    public class fn_rbac_Update_ComplianceSummary_Live
    {
        public int? CI_ID { get; set; }

        public DateTime LastSummaryTime { get; set; }

        public int NumTotal { get; set; }

        public int? NumNotApplicable { get; set; }

        public int NumMissing { get; set; }

        public int NumPresent { get; set; }

        public int NumInstalled { get; set; }

        public int NumFailed { get; set; }

        public int? NumPending { get; set; }

        public int? NumUnknown { get; set; }

    }
}

