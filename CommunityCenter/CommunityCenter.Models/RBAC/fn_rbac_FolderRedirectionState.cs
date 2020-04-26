using System;

namespace CommunityCenter.Models.RBAC
{
    public class fn_rbac_FolderRedirectionState
    {
        public int ItemKey { get; set; }

        public string UserSID { get; set; }

        public string FolderName { get; set; }

        public int? HealthState { get; set; }

    }
}

