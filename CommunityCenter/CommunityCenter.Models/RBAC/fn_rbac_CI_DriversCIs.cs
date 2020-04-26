using System;

namespace CommunityCenter.Models.RBAC
{
    public class fn_rbac_CI_DriversCIs
    {
        public int CI_ID { get; set; }

        public string CI_UniqueID { get; set; }

        public string DriverType { get; set; }

        public string DriverINFFile { get; set; }

        public DateTime? DriverDate { get; set; }

        public string DriverVersion { get; set; }

        public string DriverClass { get; set; }

        public string DriverProvider { get; set; }

        public bool? DriverSigned { get; set; }

        public string DriverSigner { get; set; }

        public bool? DriverBootCritical { get; set; }

    }
}

