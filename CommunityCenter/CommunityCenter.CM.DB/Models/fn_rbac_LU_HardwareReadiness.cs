using System;

namespace CommunityCenter.CM.DB.Models
{
    public class fn_rbac_LU_HardwareReadiness
    {
        public string Product { get; set; }

        public int? MinCPU { get; set; }

        public long? MinRAM { get; set; }

        public long? MinDiskSize { get; set; }

        public long? MinDiskFree { get; set; }

        public int State { get; set; }

        public int IsLocal { get; set; }

        public int IsDeleted { get; set; }

    }
}

