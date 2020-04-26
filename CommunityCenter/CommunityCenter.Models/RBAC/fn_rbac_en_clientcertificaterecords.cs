using System;

namespace CommunityCenter.Models.RBAC
{
    public class fn_rbac_en_clientcertificaterecords
    {
        public string DeviceName { get; set; }

        public string RequesterName { get; set; }

        public DateTime? CertExpiryTime { get; set; }

        public DateTime? LastCertRenAttempt { get; set; }

        public DateTime? EnrollmentTime { get; set; }

        public int? EnrollmentRecordId { get; set; }

        public string Name { get; set; }

        public string ManagementSiteCode { get; set; }

        public string EnrollmentSiteCode { get; set; }

        public DateTime? RenewStartTime { get; set; }

        public int Status { get; set; }

        public string SMSID { get; set; }

        public byte[] Thumbprint { get; set; }

    }
}

