using System;

namespace CommunityCenter.Models.RBAC
{
    public class fn_rbac_AI_MVLS
    {
        public string MLSProductPool { get; set; }

        public string MLSFamilyName { get; set; }

        public string VersionCode { get; set; }

        public int? EffectiveQuantity { get; set; }

        public int? UnresolvedQuantity { get; set; }

        public int? UpgradeQuantity { get; set; }

        public int? UpgradeMaintenanceQuantity { get; set; }

        public int? ActiveSAQuantity { get; set; }

    }
}

