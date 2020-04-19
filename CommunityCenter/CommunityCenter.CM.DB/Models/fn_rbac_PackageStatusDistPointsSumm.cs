using System;

namespace CommunityCenter.CM.DB.Models
{
    public class fn_rbac_PackageStatusDistPointsSumm
    {
        public string PackageID { get; set; }

        public string SiteCode { get; set; }

        public string ServerNALPath { get; set; }

        public int? SourceVersion { get; set; }

        public int State { get; set; }

        public DateTime? LastCopied { get; set; }

        public string SourceNALPath { get; set; }

        public DateTime SummaryDate { get; set; }

        public string InstallStatus { get; set; }

        public int? SecuredTypeID { get; set; }

        public string SecureObjectID { get; set; }

    }
}

