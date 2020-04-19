using System;

namespace CommunityCenter.CM.DB.Models
{
    public class fn_rbac_UpdateScanStatus
    {
        public int ResourceID { get; set; }

        public int UpdateSource_ID { get; set; }

        public DateTime? ScanTime { get; set; }

        public int? ScanPackageVersion { get; set; }

        public int? LastScanState { get; set; }

        public DateTime? LastScanTime { get; set; }

        public int? LastStatusMessageID { get; set; }

        public int? LastErrorCode { get; set; }

        public string LastScanPackageLocation { get; set; }

        public int? LastScanPackageVersion { get; set; }

        public string LastWUAVersion { get; set; }

        public DateTime? LastLocalChangeTime { get; set; }

    }
}

