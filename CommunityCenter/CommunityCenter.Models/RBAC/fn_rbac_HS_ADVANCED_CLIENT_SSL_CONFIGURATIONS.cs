using System;

namespace CommunityCenter.Models.RBAC
{
    public class fn_rbac_HS_ADVANCED_CLIENT_SSL_CONFIGURATIONS
    {
        public int ResourceID { get; set; }

        public int GroupID { get; set; }

        public int RevisionID { get; set; }

        public int? AgentID { get; set; }

        public DateTime TimeStamp { get; set; }

        public string CertificateSelectionCriteria0 { get; set; }

        public string CertificateStore0 { get; set; }

        public int? ClientAlwaysOnInternet0 { get; set; }

        public int? HttpsStateFlags0 { get; set; }

        public string InstanceKey0 { get; set; }

        public string InternetMPHostName0 { get; set; }

        public int? SelectFirstCertificate0 { get; set; }

    }
}

