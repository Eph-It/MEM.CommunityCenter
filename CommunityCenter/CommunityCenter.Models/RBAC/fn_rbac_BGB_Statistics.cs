using System;

namespace CommunityCenter.Models.RBAC
{
    public class fn_rbac_BGB_Statistics
    {
        public int ID { get; set; }

        public int ServerID { get; set; }

        public DateTime TimeStamp { get; set; }

        public int? InternetOnlineClients { get; set; }

        public int? IntranetOnlineClients { get; set; }

        public int? CMGOnlineClients { get; set; }

    }
}

