using System;

namespace CommunityCenter.CM.DB.Models
{
    public class fn_rbac_EAS_Property_S
    {
        public int ItemKey { get; set; }

        public string DeviceID { get; set; }

        public string EAS_Identity { get; set; }

        public string FriendlyName { get; set; }

        public string UserName { get; set; }

        public string UserDomain { get; set; }

        public string DeviceImei { get; set; }

        public string DeviceOS { get; set; }

        public string DeviceOSLanguage { get; set; }

        public string DevicePhoneNumber { get; set; }

        public string DeviceMobileOperator { get; set; }

        public string DeviceType { get; set; }

        public string DeviceModel { get; set; }

        public string DeviceUserAgent { get; set; }

        public string DeviceAccessState { get; set; }

        public string DeviceAccessStateReason { get; set; }

        public string DeviceAccessControlRule { get; set; }

        public string ExchangeServer { get; set; }

        public string DeviceStatus { get; set; }

        public string StatusNote { get; set; }

        public string DevicePolicyApplied { get; set; }

        public string DevicePolicyApplicationStatus { get; set; }

        public bool? IsRemoteWipeSupported { get; set; }

        public DateTime? FirstSyncTimeUTC { get; set; }

        public int? SMSWipeStatus { get; set; }

        public DateTime? LastPolicyUpdateTimeUTC { get; set; }

        public DateTime? LastSyncAttemptTimeUTC { get; set; }

        public DateTime? LastSuccessSyncTimeUTC { get; set; }

        public DateTime? DeviceWipeSentTimeUTC { get; set; }

        public DateTime? DeviceWipeRequestTimeUTC { get; set; }

        public DateTime? DeviceWipeAckTimeUTC { get; set; }

        public int? Client_Type0 { get; set; }

    }
}

