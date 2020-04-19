using System;

namespace CommunityCenter.CM.DB.Models
{
    public class fn_rbac_UserMachineIntelligence
    {
        public int MachineResourceID { get; set; }

        public string UniqueUserName { get; set; }

        public string MachineResourceName { get; set; }

        public int? MachineResourceClientType { get; set; }

        public int? NumberOfLogins { get; set; }

        public DateTime? LastLoginTime { get; set; }

        public int? ConsoleMinutes { get; set; }

    }
}

