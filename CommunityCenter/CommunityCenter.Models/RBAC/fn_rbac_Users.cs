using System;

namespace CommunityCenter.Models.RBAC
{
    public class fn_rbac_Users
    {
        public int UserID { get; set; }

        public string FullName { get; set; }

        public string Domain { get; set; }

        public string UserName { get; set; }

        public string UserSID { get; set; }

        public int SiteNumber { get; set; }

    }
}

