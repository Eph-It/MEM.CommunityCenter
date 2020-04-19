using System;

namespace CommunityCenter.CM.DB.Models
{
    public class fn_rbac_HS_DEVICE_MEMORY
    {
        public int ResourceID { get; set; }

        public int GroupID { get; set; }

        public int RevisionID { get; set; }

        public int? AgentID { get; set; }

        public DateTime TimeStamp { get; set; }

        public long? ProgramFree0 { get; set; }

        public long? ProgramTotal0 { get; set; }

        public long? RemovableStorageFree0 { get; set; }

        public long? RemovableStorageTotal0 { get; set; }

        public long? StorageFree0 { get; set; }

        public long? StorageTotal0 { get; set; }

    }
}

