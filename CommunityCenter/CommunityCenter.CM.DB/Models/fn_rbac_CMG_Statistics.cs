using System;

namespace CommunityCenter.CM.DB.Models
{
    public class fn_rbac_CMG_Statistics
    {
        public int ID { get; set; }

        public int AzureServiceId { get; set; }

        public DateTime TimeStamp { get; set; }

        public int? NetworkOut14Days { get; set; }

        public int? PKIIdentities14Days { get; set; }

        public int? AADIdentities14Days { get; set; }

        public int? AADDeviceIdentities14Days { get; set; }

        public int? AADUserIdentities14Days { get; set; }

        public int? SCCMIdentities14Days { get; set; }

        public long? Requests14Days { get; set; }

        public long? RequestSize14Days { get; set; }

        public long? ResponseSize14Days { get; set; }

        public int? TotalIdentities { get; set; }

        public int? TotalDeviceIdentity { get; set; }

        public int? TotalUserIdentity { get; set; }

        public long? TotalRequests { get; set; }

        public long? TotalRequestSize { get; set; }

        public long? TotalResponseSize { get; set; }

    }
}

