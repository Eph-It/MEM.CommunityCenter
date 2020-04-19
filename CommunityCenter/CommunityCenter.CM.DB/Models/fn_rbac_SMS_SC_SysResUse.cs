using System;

namespace CommunityCenter.CM.DB.Models
{
    public class fn_rbac_SMS_SC_SysResUse
    {
        public long ID { get; set; }

        public int SiteNumber { get; set; }

        public string SiteCode { get; set; }

        public string NALResType { get; set; }

        public string NALPath { get; set; }

        public short RoleTypeID { get; set; }

        public string RoleName { get; set; }

        public int? SslState { get; set; }

        public string ServerName { get; set; }

        public int SiteSystemStatus { get; set; }

        public int? ServerState { get; set; }

    }
}

