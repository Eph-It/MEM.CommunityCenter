using CommunityCenter.CM.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace CommunityCenter.Models.CM.Device
{
    public class SMS_CombinedDeviceResources : CMModelBase
    {
        public SMS_CombinedDeviceResources()
        {
            this._Endpoint = @"/wmi/SMS_CombinedDeviceResources";
        }
        public string Domain { get; set; }
        public string Name { get; set; }
        public int? ResourceID { get; set; }
        public int? ResourceType { get; set; }
        public string SMSID { get; set; }
        public string AADDeviceID { get; set; }
        public string AADTenantID { get; set; }
        public int? ActivationLockBypassState { get; set; }
        public DateTime? ActivationLockBypassStateTimeStamp { get; set; }
        public string ActivationLockState { get; set; }
        public DateTime? ADLastLogonTime { get; set; }
        public string ADSiteName { get; set; }
        public string AMTFullVersion { get; set; }
        public int? AMTStatus { get; set; }
        public DateTime? ATPLastConnected { get; set; }
        public int? ATPOnboardingState { get; set; }
        public string ATPOrgId { get; set; }
        public bool? ATPSenseIsRunning { get; set; }
        public string CAComplianceEvalTime { get; set; }
        public string CAComplianceSetTime { get; set; }
        public string CAErrorDetails { get; set; }
        public int? CAErrorLocation { get; set; }
        public bool? CAIsCompliant { get; set; }
        public int? ClientActiveStatus { get; set; }
        public int? ClientCertType { get; set; }
        public int? ClientCheckPass { get; set; }
        public int? ClientEdition { get; set; }
        public int? ClientRemediationSuccess { get; set; }
        public int? ClientState { get; set; }
        public int? ClientType { get; set; }
        public string ClientVersion { get; set; }
        public string CNAccessMP { get; set; }
        public bool? CNIsOnInternet { get; set; }
        public bool? CNIsOnline { get; set; }
        public DateTime? CNLastOfflineTime { get; set; }
        public DateTime? CNLastOnlineTime { get; set; }
        public bool? CoManaged { get; set; }
        public string CurrentLogonUser { get; set; }
        public string DeviceAccessState { get; set; }
        public string DeviceCategory { get; set; }
        public string DeviceOS { get; set; }
        public string DeviceOSBuild { get; set; }
        public int? DeviceOwner { get; set; }
        public string DeviceThreatLevel { get; set; }
        public string DeviceType { get; set; }
        public string EASDeviceID { get; set; }
        public int? EnrollmentStatus { get; set; }
        public bool? EPAntispywareEnabled { get; set; }
        public DateTime? EPAntispywareSignatureLastUpdateDateTime { get; set; }
        public string EPAntispywareSignatureLastVersion { get; set; }
        public bool? EPAntivirusEnabled { get; set; }
        public DateTime? EPAntivirusSignatureLastUpdateDateTime { get; set; }
        public string EPAntivirusSignatureLastVersion { get; set; }
        public string EPClientVersion { get; set; }
        public string EPDeploymentDescription { get; set; }
        public int? EPDeploymentErrorCode { get; set; }
        public int? EPDeploymentState { get; set; }
        public bool? EPEnabled { get; set; }
        public string EPEngineVersion { get; set; }
        public int? EPInfectionStatus { get; set; }
        public DateTime? EPLastFullScanDateTimeEnd { get; set; }
        public DateTime? EPLastFullScanDateTimeStart { get; set; }
        public DateTime? EPLastInfectionTime { get; set; }
        public DateTime? EPLastQuickScanDateTimeEnd { get; set; }
        public DateTime? EPLastQuickScanDateTimeStart { get; set; }
        public string EPLastThreatName { get; set; }
        public bool? EPPendingFullScan { get; set; }
        public bool? EPPendingManualSteps { get; set; }
        public bool? EPPendingOfflineScan { get; set; }
        public bool? EPPendingReboot { get; set; }
        public string EPPolicyApplicationDescription { get; set; }
        public int? EPPolicyApplicationErrorCode { get; set; }
        public int? EPPolicyApplicationState { get; set; }
        public int? EPProductStatus { get; set; }
        public string ExchangeOrganization { get; set; }
        public string ExchangeServer { get; set; }
        public string IMEI { get; set; }
        public bool? IsActive { get; set; }
        public bool? IsAlwaysInternet { get; set; }
        public bool? IsAOACCapable { get; set; }
        public int? IsApproved { get; set; }
        public bool? IsBlocked { get; set; }
        public bool? IsClient { get; set; }
        public bool? IsInternetEnabled { get; set; }
        public bool? IsMDMActive { get; set; }
        public bool? IsObsolete { get; set; }
        public string IsSupervised { get; set; }
        public bool? IsVirtualMachine { get; set; }
        public DateTime? LastActiveTime { get; set; }
        public DateTime? LastClientCheckTime { get; set; }
        public DateTime? LastDDR { get; set; }
        public DateTime? LastHardwareScan { get; set; }
        public int? LastInstallationError { get; set; }
        public string LastLogonUser { get; set; }
        public string LastMPServerName { get; set; }
        public DateTime? LastPolicyRequest { get; set; }
        public DateTime? LastSoftwareScan { get; set; }
        public DateTime? LastStatusMessage { get; set; }
        public DateTime? LastSuccessSyncTimeUTC { get; set; }
        public DateTime? LastSyncNowRequest { get; set; }
        public DateTime? LatestProcessingAttempt { get; set; }
        public string MACAddress { get; set; }
        public int? ManagementAuthority { get; set; }
        public int? PasscodeResetState { get; set; }
        public DateTime? PasscodeResetStateTimeStamp { get; set; }
        public string PhoneNumber { get; set; }
        public string PolicyApplicationStatus { get; set; }
        public string PrimaryUser { get; set; }
        public int? RemoteLockState { get; set; }
        public DateTime? RemoteLockStateTimeStamp { get; set; }
        public int? RetireStatus { get; set; }
        public string SenseID { get; set; }
        public string SerialNumber { get; set; }
        public string SiteCode { get; set; }
        public string SMBIOSGUID { get; set; }
        public string Status { get; set; }
        public bool? SuppressAutoProvision { get; set; }
        public int? SyncNowStatus { get; set; }
        public bool? Unknown { get; set; }
        public string UserDomainName { get; set; }
        public string UserName { get; set; }
        public int? WipeStatus { get; set; }
    }
}
