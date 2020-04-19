using System;

namespace CommunityCenter.CM.DB.Models
{
    public class fn_rbac_FullCollectionMembership
    {
        public string CollectionID { get; set; }

        public int ResourceID { get; set; }

        public byte ResourceType { get; set; }

        public string Name { get; set; }

        public string Domain { get; set; }

        public string SMSID { get; set; }

        public string SiteCode { get; set; }

        public bool IsDirect { get; set; }

        public bool IsAssigned { get; set; }

        public int IsClient { get; set; }

        public int? ClientType { get; set; }

        public int? IsObsolete { get; set; }

        public int? IsActive { get; set; }

        public int IsDecommissioned { get; set; }

        public bool? IsVirtualMachine { get; set; }

        public int? AMTStatus { get; set; }

        public int? DeviceOwner { get; set; }

        public string DeviceCategory { get; set; }

        public string AMTFullVersion { get; set; }

        public bool? SuppressAutoProvision { get; set; }

        public int? IsApproved { get; set; }

        public bool? IsBlocked { get; set; }

        public bool? IsAlwaysInternet { get; set; }

        public bool? IsInternetEnabled { get; set; }

        public int? ClientCertType { get; set; }

        public bool? IsMachineChangesPersisted { get; set; }

        public bool? IsMachineAssignedToUser { get; set; }

        public string VMHostName { get; set; }

        public long rowversion { get; set; }

        public int? Priority { get; set; }

    }
}

