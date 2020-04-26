using System;

namespace CommunityCenter.Models.RBAC
{
    public class fn_rbac_vSMS_DistributionDPStatus
    {
        public long ID { get; set; }

        public int DPID { get; set; }

        public string Name { get; set; }

        public string NALPath { get; set; }

        public string ResourceType { get; set; }

        public int IsPeerDP { get; set; }

        public int GroupCount { get; set; }

        public string PackageID { get; set; }

        public int MessageID { get; set; }

        public int MessageCategory { get; set; }

        public int MessageState { get; set; }

        public long LastStatusID { get; set; }

        public DateTime LastUpdateDate { get; set; }

        public string SiteCode { get; set; }

        public int? MessageSeverity { get; set; }

        public int? MessageFullID { get; set; }

        public string ObjectID { get; set; }

        public int? ObjectTypeID { get; set; }

        public string InsString1 { get; set; }

        public string InsString2 { get; set; }

        public string InsString3 { get; set; }

        public string InsString4 { get; set; }

        public string InsString5 { get; set; }

        public string InsString6 { get; set; }

        public string InsString7 { get; set; }

        public string InsString8 { get; set; }

        public string InsString9 { get; set; }

        public string InsString10 { get; set; }

    }
}

