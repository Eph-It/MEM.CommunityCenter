using System;

namespace CommunityCenter.CM.DB.Models
{
    public class fn_rbac_AMTMachineInfo
    {
        public int MachineID { get; set; }

        public string HostName { get; set; }

        public string FQDN { get; set; }

        public string Addn { get; set; }

        public string IP { get; set; }

        public DateTime? ProvisionTime { get; set; }

        public string AdminPassword { get; set; }

        public string AdminUserName { get; set; }

        public int? TlsMode { get; set; }

        public int? ProvisionOpType { get; set; }

        public bool? EnableKerberos { get; set; }

        public int? ConfigurationStatus { get; set; }

        public DateTime? LastMaintenanceDate { get; set; }

        public int? LastOperationStatus { get; set; }

        public DateTime? lastOperationTime { get; set; }

    }
}

