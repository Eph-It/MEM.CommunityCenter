using System;

namespace CommunityCenter.Models.RBAC
{
    public class fn_rbac_GS_SoftwareFile
    {
        public int ResourceID { get; set; }

        public long FileID { get; set; }

        public int ProductId { get; set; }

        public string FileName { get; set; }

        public string FileDescription { get; set; }

        public string FileVersion { get; set; }

        public long? FileSize { get; set; }

        public int FileCount { get; set; }

        public DateTime? ModifiedDate { get; set; }

        public int? CreationDate { get; set; }

        public string FilePath { get; set; }

        public DateTime? FileModifiedDate { get; set; }

    }
}

