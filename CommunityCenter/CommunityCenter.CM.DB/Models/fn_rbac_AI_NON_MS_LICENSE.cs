using System;

namespace CommunityCenter.CM.DB.Models
{
    public class fn_rbac_AI_NON_MS_LICENSE
    {
        public string Name { get; set; }

        public string Publisher { get; set; }

        public string Version { get; set; }

        public string Language { get; set; }

        public int EffectiveQuantity { get; set; }

        public string PONumber { get; set; }

        public string ResellerName { get; set; }

        public DateTime? DateOfPurchase { get; set; }

        public bool? SupportPurchased { get; set; }

        public DateTime? SupportExpirationDate { get; set; }

        public string Comments { get; set; }

    }
}

