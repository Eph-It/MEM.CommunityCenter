using System;

namespace CommunityCenter.Models.RBAC
{
    public class fn_rbac_CombinedDeviceResources
    {
        public int MachineID { get; set; }

        public int ArchitectureKey { get; set; }

        public string Name { get; set; }

        public string SMSID { get; set; }

        public string SiteCode { get; set; }

        public string Domain { get; set; }

        public int? ClientEdition { get; set; }

        public int? ClientType { get; set; }

        public string ClientVersion { get; set; }

        public int IsClient { get; set; }

        public int? IsObsolete { get; set; }

        public int? IsActive { get; set; }

        public bool? IsVirtualMachine { get; set; }

        public bool? IsAOACCapable { get; set; }

        public int? DeviceOwner { get; set; }

        public string DeviceCategory { get; set; }

        public int? WipeStatus { get; set; }

        public byte? RetireStatus { get; set; }

        public int? SyncNowStatus { get; set; }

        public DateTime? LastSyncNowRequest { get; set; }

        public int? ManagementAuthority { get; set; }

        public int? AMTStatus { get; set; }

        public string AMTFullVersion { get; set; }

        public bool? SuppressAutoProvision { get; set; }

        public int? IsApproved { get; set; }

        public bool? IsBlocked { get; set; }

        public bool? IsAlwaysInternet { get; set; }

        public bool? IsInternetEnabled { get; set; }

        public int? ClientCertType { get; set; }

        public string UserName { get; set; }

        public DateTime? LastClientCheckTime { get; set; }

        public int? ClientCheckPass { get; set; }

        public string ADSiteName { get; set; }

        public string UserDomainName { get; set; }

        public DateTime? ADLastLogonTime { get; set; }

        public int? ClientRemediationSuccess { get; set; }

        public int? ClientActiveStatus { get; set; }

        public DateTime? LastStatusMessage { get; set; }

        public DateTime? LastPolicyRequest { get; set; }

        public DateTime? LastDDR { get; set; }

        public DateTime? LastHardwareScan { get; set; }

        public DateTime? LastSoftwareScan { get; set; }

        public string LastMPServerName { get; set; }

        public DateTime? LastActiveTime { get; set; }

        public string CP_Status { get; set; }

        public DateTime? CP_LatestProcessingAttempt { get; set; }

        public int? CP_LastInstallationError { get; set; }

        public string EAS_DeviceID { get; set; }

        public string DeviceOS { get; set; }

        public string DeviceOSBuild { get; set; }

        public string DeviceType { get; set; }

        public string ExchangeServer { get; set; }

        public string ExchangeOrganization { get; set; }

        public string PolicyApplicationStatus { get; set; }

        public DateTime? LastSuccessSyncTimeUTC { get; set; }

        public string PhoneNumber { get; set; }

        public string DeviceAccessState { get; set; }

        public int? EP_DeploymentState { get; set; }

        public long? EP_DeploymentErrorCode { get; set; }

        public string EP_DeploymentDescription { get; set; }

        public int? EP_PolicyApplicationState { get; set; }

        public long? EP_PolicyApplicationErrorCode { get; set; }

        public string EP_PolicyApplicationDescription { get; set; }

        public bool? EP_Enabled { get; set; }

        public string EP_ClientVersion { get; set; }

        public int? EP_ProductStatus { get; set; }

        public string EP_EngineVersion { get; set; }

        public bool? EP_AntivirusEnabled { get; set; }

        public string EP_AntivirusSignatureVersion { get; set; }

        public DateTime? EP_AntivirusSignatureUpdateDateTime { get; set; }

        public bool? EP_AntispywareEnabled { get; set; }

        public string EP_AntispywareSignatureVersion { get; set; }

        public DateTime? EP_AntispywareSignatureUpdateDateTime { get; set; }

        public DateTime? EP_LastFullScanDateTimeStart { get; set; }

        public DateTime? EP_LastFullScanDateTimeEnd { get; set; }

        public DateTime? EP_LastQuickScanDateTimeStart { get; set; }

        public DateTime? EP_LastQuickScanDateTimeEnd { get; set; }

        public byte? EP_InfectionStatus { get; set; }

        public bool? EP_PendingFullScan { get; set; }

        public bool? EP_PendingReboot { get; set; }

        public bool? EP_PendingManualSteps { get; set; }

        public bool? EP_PendingOfflineScan { get; set; }

        public DateTime? EP_LastInfectionTime { get; set; }

        public string EP_LastThreatName { get; set; }

        public bool? CNIsOnline { get; set; }

        public DateTime? CNLastOnlineTime { get; set; }

        public DateTime? CNLastOfflineTime { get; set; }

        public string CNAccessMP { get; set; }

        public bool? CNIsOnInternet { get; set; }

        public int? ClientState { get; set; }

        public bool? Unknown { get; set; }

        public DateTime? ATP_LastConnected { get; set; }

        public bool? ATP_SenseIsRunning { get; set; }

        public int? ATP_OnboardingState { get; set; }

        public string ATP_OrgId { get; set; }

        public byte? CA_IsCompliant { get; set; }

        public string CA_ComplianceSetTime { get; set; }

        public string CA_ComplianceEvalTime { get; set; }

        public string CA_ErrorDetails { get; set; }

        public byte? CA_ErrorLocation { get; set; }

        public string AADTenantID { get; set; }

        public string AADDeviceID { get; set; }

        public int? PasscodeResetState { get; set; }

        public DateTime? PasscodeResetStateTimeStamp { get; set; }

        public int? RemoteLockState { get; set; }

        public DateTime? RemoteLockStateTimeStamp { get; set; }

        public int? ActivationLockBypassState { get; set; }

        public DateTime? ActivationLockBypassStateTimeStamp { get; set; }

        public string ActivationLockState { get; set; }

        public string IsSupervised { get; set; }

        public string DeviceThreatLevel { get; set; }

        public string SerialNumber { get; set; }

        public string IMEI { get; set; }

        public string PrimaryUser { get; set; }

        public string CurrentLogonUser { get; set; }

        public string LastLogonUser { get; set; }

        public string MACAddress { get; set; }

        public string SMBIOSGUID { get; set; }

        public int? CoManaged { get; set; }

        public bool? IsMDMActive { get; set; }

        public string SenseID { get; set; }

        public string BoundaryGroups { get; set; }

    }
}

