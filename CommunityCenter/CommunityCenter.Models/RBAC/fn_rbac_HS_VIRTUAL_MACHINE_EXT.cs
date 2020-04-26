using System;

namespace CommunityCenter.Models.RBAC
{
    public class fn_rbac_HS_VIRTUAL_MACHINE_EXT
    {
        public int ResourceID { get; set; }

        public int GroupID { get; set; }

        public int RevisionID { get; set; }

        public int? AgentID { get; set; }

        public DateTime TimeStamp { get; set; }

        public int? CpuUtilization0 { get; set; }

        public long? DiskBytesRead0 { get; set; }

        public long? DiskBytesWritten0 { get; set; }

        public long? DiskSpaceUsed0 { get; set; }

        public long? HeartbeatCount0 { get; set; }

        public int? HeartbeatInterval0 { get; set; }

        public int? HeartbeatPercentage0 { get; set; }

        public int? HeartbeatRate0 { get; set; }

        public string Name0 { get; set; }

        public long? NetworkBytesReceived0 { get; set; }

        public long? NetworkBytesSent0 { get; set; }

        public long? PhysicalMemoryAllocated0 { get; set; }

        public int? Uptime0 { get; set; }

    }
}

