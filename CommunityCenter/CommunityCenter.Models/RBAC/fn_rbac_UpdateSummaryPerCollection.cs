using System;

namespace CommunityCenter.Models.RBAC
{
    public class fn_rbac_UpdateSummaryPerCollection
    {
        public int LocalCollectionID { get; set; }

        public string CollectionID { get; set; }

        public string CollectionName { get; set; }

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

