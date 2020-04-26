using System;

namespace CommunityCenter.Models.RBAC
{
    public class fn_rbac_DrsSendHistorySummary
    {
        public string SourceSite { get; set; }

        public string TargetSite { get; set; }

        public int ReplicationGroupID { get; set; }

        public long? SyncDataSize { get; set; }

        public long? CompressedSize { get; set; }

        public long? UncompressedSize { get; set; }

        public DateTime? SummarizationTime { get; set; }

    }
}

