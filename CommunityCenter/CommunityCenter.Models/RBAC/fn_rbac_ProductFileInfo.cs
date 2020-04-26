using System;

namespace CommunityCenter.Models.RBAC
{
    public class fn_rbac_ProductFileInfo
    {
        public long FileID { get; set; }

        public string FileName { get; set; }

        public string FileDescription { get; set; }

        public string FileVersion { get; set; }

        public long? FileSize { get; set; }

        public string CompanyName { get; set; }

        public string ProductName { get; set; }

        public string ProductVersion { get; set; }

        public int? ProductLanguage { get; set; }

    }
}

