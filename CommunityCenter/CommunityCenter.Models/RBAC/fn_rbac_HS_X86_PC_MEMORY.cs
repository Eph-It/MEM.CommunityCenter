using System;

namespace CommunityCenter.Models.RBAC
{
    public class fn_rbac_HS_X86_PC_MEMORY
    {
        public int ResourceID { get; set; }

        public int GroupID { get; set; }

        public int RevisionID { get; set; }

        public int? AgentID { get; set; }

        public DateTime TimeStamp { get; set; }

        public long? AvailableVirtualMemory0 { get; set; }

        public string Name0 { get; set; }

        public long? TotalPageFileSpace0 { get; set; }

        public long? TotalPhysicalMemory0 { get; set; }

        public long? TotalVirtualMemory0 { get; set; }

    }
}

