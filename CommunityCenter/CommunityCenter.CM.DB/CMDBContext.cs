using CommunityCenter.CM.DB.Models;
using CommunityCenter.User;
using Microsoft.EntityFrameworkCore;
using System;
using System.Data;
using System.Linq;

namespace CommunityCenter.CM.DB
{
    public class CMDBContext : DbContext
    {
        private string _cmUserId = "";
        private ICCUser _user;
        public CMDBContext(DbContextOptions<CMDBContext> options, ICCUser user) : base(options)
        {
            _user = user;
        }

        public IQueryable<T> GetRBACResults<T>()
            where T : class
        {
            string className = typeof(T).Name;
            var queryString = $"SELECT * FROM {className} ({{0}})";
            return base.Set<T>().FromSqlRaw(queryString, cmUserId);
        }

        public string cmUserId
        {
            get
            {
                if (String.IsNullOrEmpty(_cmUserId))
                {
                    using (var command = base.Database.GetDbConnection().CreateCommand())
                    {
                        var userSids = _user.GetSids();
                        command.CommandText = $"select dbo.fn_rbac_GetAdminIDsfromUserSIDs('{userSids}') as Result";
                        command.CommandType = CommandType.Text;
                        base.Database.OpenConnection();
                        using (var result = command.ExecuteReader())
                        {
                            while (result.Read())
                            {
                                _cmUserId = result["Result"].ToString();
                            }
                        }
                    }
                }
                return _cmUserId;
            }
        }
#pragma warning disable IDE1006 // Naming Styles
        #region generated function DBSets
        public DbSet<fn_rbac_GS_SYSTEM> fn_rbac_GS_SYSTEM { get; set; }
        public DbSet<fn_rbac_UpdateContents> fn_rbac_UpdateContents { get; set; }
        public DbSet<fn_rbac_HS_INSTALLED_EXECUTABLE> fn_rbac_HS_INSTALLED_EXECUTABLE { get; set; }
        public DbSet<fn_rbac_CH_PolicyRequestHistory> fn_rbac_CH_PolicyRequestHistory { get; set; }
        public DbSet<fn_rbac_HS_SYSTEM> fn_rbac_HS_SYSTEM { get; set; }
        public DbSet<fn_rbac_GS_INSTALLED_SOFTWARE> fn_rbac_GS_INSTALLED_SOFTWARE { get; set; }
        public DbSet<fn_rbac_R_User> fn_rbac_R_User { get; set; }
        public DbSet<fn_rbac_UpdateComplianceStatus> fn_rbac_UpdateComplianceStatus { get; set; }
        public DbSet<fn_rbac_CIComplianceStatusConflictsDetail> fn_rbac_CIComplianceStatusConflictsDetail { get; set; }
        public DbSet<fn_rbac_GS_SYSTEM_DEVICES> fn_rbac_GS_SYSTEM_DEVICES { get; set; }
        public DbSet<fn_rbac_StatMsgWithInsStrings> fn_rbac_StatMsgWithInsStrings { get; set; }
        public DbSet<fn_rbac_HS_INSTALLED_SOFTWARE> fn_rbac_HS_INSTALLED_SOFTWARE { get; set; }
        public DbSet<fn_rbac_RA_User_UserGroupName> fn_rbac_RA_User_UserGroupName { get; set; }
        public DbSet<fn_rbac_AI_MVLS> fn_rbac_AI_MVLS { get; set; }
        public DbSet<fn_rbac_Site> fn_rbac_Site { get; set; }
        public DbSet<fn_rbac_GS_SYSTEM_DRIVER> fn_rbac_GS_SYSTEM_DRIVER { get; set; }
        public DbSet<fn_rbac_SMSConfigurationItems> fn_rbac_SMSConfigurationItems { get; set; }
        public DbSet<fn_rbac_GS_IRQ> fn_rbac_GS_IRQ { get; set; }
        public DbSet<fn_rbac_RA_User_UserContainerName> fn_rbac_RA_User_UserContainerName { get; set; }
        public DbSet<fn_rbac_AdvertisementStatusInformation> fn_rbac_AdvertisementStatusInformation { get; set; }
        public DbSet<fn_rbac_HS_SYSTEM_DRIVER> fn_rbac_HS_SYSTEM_DRIVER { get; set; }
        public DbSet<fn_rbac_HS_IRQ> fn_rbac_HS_IRQ { get; set; }
        public DbSet<fn_rbac_RA_User_User_Group_Name_F> fn_rbac_RA_User_User_Group_Name_F { get; set; }
        public DbSet<fn_rbac_GS_SoftwareProduct> fn_rbac_GS_SoftwareProduct { get; set; }
        public DbSet<fn_rbac_GS_SYSTEM_ENCLOSURE> fn_rbac_GS_SYSTEM_ENCLOSURE { get; set; }
        public DbSet<fn_rbac_ServerComponents> fn_rbac_ServerComponents { get; set; }
        public DbSet<fn_rbac_GS_KEYBOARD_DEVICE> fn_rbac_GS_KEYBOARD_DEVICE { get; set; }
        public DbSet<fn_rbac_RA_User_UserOUName> fn_rbac_RA_User_UserOUName { get; set; }
        public DbSet<fn_rbac_EndpointProtectionStatus> fn_rbac_EndpointProtectionStatus { get; set; }
        public DbSet<fn_rbac_LU_Category_Editable> fn_rbac_LU_Category_Editable { get; set; }
        public DbSet<fn_rbac_HS_SYSTEM_ENCLOSURE> fn_rbac_HS_SYSTEM_ENCLOSURE { get; set; }
        public DbSet<fn_rbac_HS_KEYBOARD_DEVICE> fn_rbac_HS_KEYBOARD_DEVICE { get; set; }
        public DbSet<fn_rbac_Content> fn_rbac_Content { get; set; }
        public DbSet<fn_rbac_CIConfigPointTypes> fn_rbac_CIConfigPointTypes { get; set; }
        public DbSet<fn_rbac_GS_SYSTEMBOOTDATA> fn_rbac_GS_SYSTEMBOOTDATA { get; set; }
        public DbSet<fn_rbac_MeteredProductRule> fn_rbac_MeteredProductRule { get; set; }
        public DbSet<fn_rbac_GS_LOAD_ORDER_GROUP> fn_rbac_GS_LOAD_ORDER_GROUP { get; set; }
        public DbSet<fn_rbac_CI_CurrentErrorDetails> fn_rbac_CI_CurrentErrorDetails { get; set; }
        public DbSet<fn_rbac_HS_SYSTEMBOOTDATA> fn_rbac_HS_SYSTEMBOOTDATA { get; set; }
        public DbSet<fn_rbac_HS_LOAD_ORDER_GROUP> fn_rbac_HS_LOAD_ORDER_GROUP { get; set; }
        public DbSet<fn_rbac_R_UserGroup> fn_rbac_R_UserGroup { get; set; }
        public DbSet<fn_rbac_BundledConfigurationItems> fn_rbac_BundledConfigurationItems { get; set; }
        public DbSet<fn_rbac_GS_SYSTEMBOOTSUMMARY> fn_rbac_GS_SYSTEMBOOTSUMMARY { get; set; }
        public DbSet<fn_rbac_GS_LOGICAL_DISK> fn_rbac_GS_LOGICAL_DISK { get; set; }
        public DbSet<fn_rbac_RA_UserGroupADContainerName> fn_rbac_RA_UserGroupADContainerName { get; set; }
        public DbSet<fn_rbac_GS_INSTALLED_SOFTWARE_CATEGORIZED> fn_rbac_GS_INSTALLED_SOFTWARE_CATEGORIZED { get; set; }
        public DbSet<fn_rbac_HS_SYSTEMBOOTSUMMARY> fn_rbac_HS_SYSTEMBOOTSUMMARY { get; set; }
        public DbSet<fn_rbac_DriverContentToPackage> fn_rbac_DriverContentToPackage { get; set; }
        public DbSet<fn_rbac_HS_LOGICAL_DISK> fn_rbac_HS_LOGICAL_DISK { get; set; }
        public DbSet<fn_rbac_RA_User_Group_Group_OU_Name> fn_rbac_RA_User_Group_Group_OU_Name { get; set; }
        public DbSet<fn_rbac_GS_TAPE_DRIVE> fn_rbac_GS_TAPE_DRIVE { get; set; }
        public DbSet<fn_rbac_GS_MDM_DEVDETAIL_EXT01> fn_rbac_GS_MDM_DEVDETAIL_EXT01 { get; set; }
        public DbSet<fn_rbac_CICurrentRuleDetail> fn_rbac_CICurrentRuleDetail { get; set; }
        public DbSet<fn_rbac_HS_TAPE_DRIVE> fn_rbac_HS_TAPE_DRIVE { get; set; }
        public DbSet<fn_rbac_CustomInventoryReport> fn_rbac_CustomInventoryReport { get; set; }
        public DbSet<fn_rbac_HS_MDM_DEVDETAIL_EXT01> fn_rbac_HS_MDM_DEVDETAIL_EXT01 { get; set; }
        public DbSet<fn_rbac_GS_TIME_ZONE> fn_rbac_GS_TIME_ZONE { get; set; }
        public DbSet<fn_rbac_GS_MDM_RemoteFind> fn_rbac_GS_MDM_RemoteFind { get; set; }
        public DbSet<fn_rbac_HS_TIME_ZONE> fn_rbac_HS_TIME_ZONE { get; set; }
        public DbSet<fn_rbac_CITargetedMachines> fn_rbac_CITargetedMachines { get; set; }
        public DbSet<fn_rbac_HS_MDM_RemoteFind> fn_rbac_HS_MDM_RemoteFind { get; set; }
        public DbSet<fn_rbac_GS_TPM> fn_rbac_GS_TPM { get; set; }
        public DbSet<fn_rbac_CIRelation> fn_rbac_CIRelation { get; set; }
        public DbSet<fn_rbac_GS_MDM_SecurityStatus> fn_rbac_GS_MDM_SecurityStatus { get; set; }
        public DbSet<fn_rbac_HS_TPM> fn_rbac_HS_TPM { get; set; }
        public DbSet<fn_rbac_CH_EvalResults> fn_rbac_CH_EvalResults { get; set; }
        public DbSet<fn_rbac_HS_MDM_SecurityStatus> fn_rbac_HS_MDM_SecurityStatus { get; set; }
        public DbSet<fn_rbac_LU_SoftwareList_Local> fn_rbac_LU_SoftwareList_Local { get; set; }
        public DbSet<fn_rbac_GS_TPM_STATUS> fn_rbac_GS_TPM_STATUS { get; set; }
        public DbSet<fn_rbac_GS_MODEM_DEVICE> fn_rbac_GS_MODEM_DEVICE { get; set; }
        public DbSet<fn_rbac_GS_SYSTEM_CONSOLE_USAGE_MAXGROUP> fn_rbac_GS_SYSTEM_CONSOLE_USAGE_MAXGROUP { get; set; }
        public DbSet<fn_rbac_HS_TPM_STATUS> fn_rbac_HS_TPM_STATUS { get; set; }
        public DbSet<fn_rbac_CategoryPermissions> fn_rbac_CategoryPermissions { get; set; }
        public DbSet<fn_rbac_HS_MODEM_DEVICE> fn_rbac_HS_MODEM_DEVICE { get; set; }
        public DbSet<fn_rbac_CIComplianceStatusComplianceDetail> fn_rbac_CIComplianceStatusComplianceDetail { get; set; }
        public DbSet<fn_rbac_GS_TS_ISSUED_LICENSE> fn_rbac_GS_TS_ISSUED_LICENSE { get; set; }
        public DbSet<fn_rbac_GS_MOTHERBOARD_DEVICE> fn_rbac_GS_MOTHERBOARD_DEVICE { get; set; }
        public DbSet<fn_rbac_HS_TS_ISSUED_LICENSE> fn_rbac_HS_TS_ISSUED_LICENSE { get; set; }
        public DbSet<fn_rbac_HS_MOTHERBOARD_DEVICE> fn_rbac_HS_MOTHERBOARD_DEVICE { get; set; }
        public DbSet<fn_rbac_GS_TS_LICENSE_KEY_PACK> fn_rbac_GS_TS_LICENSE_KEY_PACK { get; set; }
        public DbSet<fn_rbac_AppDTDeploymentSummary> fn_rbac_AppDTDeploymentSummary { get; set; }
        public DbSet<fn_rbac_GS_POINTING_DEVICE> fn_rbac_GS_POINTING_DEVICE { get; set; }
        public DbSet<fn_rbac_HS_TS_LICENSE_KEY_PACK> fn_rbac_HS_TS_LICENSE_KEY_PACK { get; set; }
        public DbSet<fn_rbac_HS_POINTING_DEVICE> fn_rbac_HS_POINTING_DEVICE { get; set; }
        public DbSet<fn_rbac_LU_SoftwareList_Editable> fn_rbac_LU_SoftwareList_Editable { get; set; }
        public DbSet<fn_rbac_GS_USB_CONTROLLER> fn_rbac_GS_USB_CONTROLLER { get; set; }
        public DbSet<fn_rbac_GS_NETWORK_ADAPTER> fn_rbac_GS_NETWORK_ADAPTER { get; set; }
        public DbSet<fn_rbac_HS_USB_CONTROLLER> fn_rbac_HS_USB_CONTROLLER { get; set; }
        public DbSet<fn_rbac_HS_NETWORK_ADAPTER> fn_rbac_HS_NETWORK_ADAPTER { get; set; }
        public DbSet<fn_rbac_CIComplianceStatusDetail> fn_rbac_CIComplianceStatusDetail { get; set; }
        public DbSet<fn_rbac_GS_USB_DEVICE> fn_rbac_GS_USB_DEVICE { get; set; }
        public DbSet<fn_rbac_AlertVariable_G> fn_rbac_AlertVariable_G { get; set; }
        public DbSet<fn_rbac_GS_NETWORK_CLIENT> fn_rbac_GS_NETWORK_CLIENT { get; set; }
        public DbSet<fn_rbac_HS_USB_DEVICE> fn_rbac_HS_USB_DEVICE { get; set; }
        public DbSet<fn_rbac_GS_BITLOCKER_DETAILS> fn_rbac_GS_BITLOCKER_DETAILS { get; set; }
        public DbSet<fn_rbac_HS_NETWORK_CLIENT> fn_rbac_HS_NETWORK_CLIENT { get; set; }
        public DbSet<fn_rbac_GS_INSTALLED_SOFTWARE_MS> fn_rbac_GS_INSTALLED_SOFTWARE_MS { get; set; }
        public DbSet<fn_rbac_CMG_Statistics> fn_rbac_CMG_Statistics { get; set; }
        public DbSet<fn_rbac_GS_USER_PROFILE> fn_rbac_GS_USER_PROFILE { get; set; }
        public DbSet<fn_rbac_HS_BITLOCKER_DETAILS> fn_rbac_HS_BITLOCKER_DETAILS { get; set; }
        public DbSet<fn_rbac_GS_NETWORK_ADAPTER_CONFIGURATION> fn_rbac_GS_NETWORK_ADAPTER_CONFIGURATION { get; set; }
        public DbSet<fn_rbac_GS_VIDEO_CONTROLLER> fn_rbac_GS_VIDEO_CONTROLLER { get; set; }
        public DbSet<fn_rbac_HS_NETWORK_ADAPTER_CONFIGURATION> fn_rbac_HS_NETWORK_ADAPTER_CONFIGURATION { get; set; }
        public DbSet<fn_rbac_HS_VIDEO_CONTROLLER> fn_rbac_HS_VIDEO_CONTROLLER { get; set; }
        public DbSet<fn_rbac_GS_NETWORK_LOGIN_PROFILE> fn_rbac_GS_NETWORK_LOGIN_PROFILE { get; set; }
        public DbSet<fn_rbac_WOLClientTimeZones> fn_rbac_WOLClientTimeZones { get; set; }
        public DbSet<fn_rbac_GS_VIRTUAL_APPLICATION_PACKAGES> fn_rbac_GS_VIRTUAL_APPLICATION_PACKAGES { get; set; }
        public DbSet<fn_rbac_HS_NETWORK_LOGIN_PROFILE> fn_rbac_HS_NETWORK_LOGIN_PROFILE { get; set; }
        public DbSet<fn_rbac_UpdateSummaryPerCollection> fn_rbac_UpdateSummaryPerCollection { get; set; }
        public DbSet<fn_rbac_WOLTargetedClients> fn_rbac_WOLTargetedClients { get; set; }
        public DbSet<fn_rbac_HS_VIRTUAL_APPLICATION_PACKAGES> fn_rbac_HS_VIRTUAL_APPLICATION_PACKAGES { get; set; }
        public DbSet<fn_rbac_GS_NT_EVENTLOG_FILE> fn_rbac_GS_NT_EVENTLOG_FILE { get; set; }
        public DbSet<fn_rbac_WOLGetSupportedObjects> fn_rbac_WOLGetSupportedObjects { get; set; }
        public DbSet<fn_rbac_GS_VIRTUAL_APPLICATIONS> fn_rbac_GS_VIRTUAL_APPLICATIONS { get; set; }
        public DbSet<fn_rbac_HS_NT_EVENTLOG_FILE> fn_rbac_HS_NT_EVENTLOG_FILE { get; set; }
        public DbSet<fn_rbac_ThreatSeverities> fn_rbac_ThreatSeverities { get; set; }
        public DbSet<fn_rbac_Users> fn_rbac_Users { get; set; }
        public DbSet<fn_rbac_HS_VIRTUAL_APPLICATIONS> fn_rbac_HS_VIRTUAL_APPLICATIONS { get; set; }
        public DbSet<fn_rbac_GS_OFFICE_ADDIN> fn_rbac_GS_OFFICE_ADDIN { get; set; }
        public DbSet<fn_rbac_GS_1394_CONTROLLER> fn_rbac_GS_1394_CONTROLLER { get; set; }
        public DbSet<fn_rbac_StatMsgAttributes> fn_rbac_StatMsgAttributes { get; set; }
        public DbSet<fn_rbac_UserMachineTypeRelation> fn_rbac_UserMachineTypeRelation { get; set; }
        public DbSet<fn_rbac_GS_VIRTUAL_MACHINE_64> fn_rbac_GS_VIRTUAL_MACHINE_64 { get; set; }
        public DbSet<fn_rbac_HS_OFFICE_ADDIN> fn_rbac_HS_OFFICE_ADDIN { get; set; }
        public DbSet<fn_rbac_HS_1394_CONTROLLER> fn_rbac_HS_1394_CONTROLLER { get; set; }
        public DbSet<fn_rbac_MDMUserPolicyAssignment> fn_rbac_MDMUserPolicyAssignment { get; set; }
        public DbSet<fn_rbac_ThreatDefaultActions> fn_rbac_ThreatDefaultActions { get; set; }
        public DbSet<fn_rbac_HS_VIRTUAL_MACHINE_64> fn_rbac_HS_VIRTUAL_MACHINE_64 { get; set; }
        public DbSet<fn_rbac_GS_COMPUTER_SYSTEM_EXT> fn_rbac_GS_COMPUTER_SYSTEM_EXT { get; set; }
        public DbSet<fn_rbac_GS_OFFICE_DOCUMENTMETRIC> fn_rbac_GS_OFFICE_DOCUMENTMETRIC { get; set; }
        public DbSet<fn_rbac_GS_ACTIVESYNC_SERVICE> fn_rbac_GS_ACTIVESYNC_SERVICE { get; set; }
        public DbSet<fn_rbac_BGB_Statistics> fn_rbac_BGB_Statistics { get; set; }
        public DbSet<fn_rbac_mdmclientidentity> fn_rbac_mdmclientidentity { get; set; }
        public DbSet<fn_rbac_StateNames> fn_rbac_StateNames { get; set; }
        public DbSet<fn_rbac_GS_VIRTUAL_MACHINE> fn_rbac_GS_VIRTUAL_MACHINE { get; set; }
        public DbSet<fn_rbac_HS_COMPUTER_SYSTEM_EXT> fn_rbac_HS_COMPUTER_SYSTEM_EXT { get; set; }
        public DbSet<fn_rbac_HS_OFFICE_DOCUMENTMETRIC> fn_rbac_HS_OFFICE_DOCUMENTMETRIC { get; set; }
        public DbSet<fn_rbac_HS_ACTIVESYNC_SERVICE> fn_rbac_HS_ACTIVESYNC_SERVICE { get; set; }
        public DbSet<fn_rbac_HS_VIRTUAL_MACHINE> fn_rbac_HS_VIRTUAL_MACHINE { get; set; }
        public DbSet<fn_rbac_GS_OFFICE_PRODUCTINFO> fn_rbac_GS_OFFICE_PRODUCTINFO { get; set; }
        public DbSet<fn_rbac_GS_ADD_REMOVE_PROGRAMS_64> fn_rbac_GS_ADD_REMOVE_PROGRAMS_64 { get; set; }
        public DbSet<fn_rbac_LU_CAL_ProductList> fn_rbac_LU_CAL_ProductList { get; set; }
        public DbSet<fn_rbac_PackageStatusRootSummarizer> fn_rbac_PackageStatusRootSummarizer { get; set; }
        public DbSet<fn_rbac_GS_VIRTUAL_MACHINE_EXT> fn_rbac_GS_VIRTUAL_MACHINE_EXT { get; set; }
        public DbSet<fn_rbac_HS_OFFICE_PRODUCTINFO> fn_rbac_HS_OFFICE_PRODUCTINFO { get; set; }
        public DbSet<fn_rbac_HS_ADD_REMOVE_PROGRAMS_64> fn_rbac_HS_ADD_REMOVE_PROGRAMS_64 { get; set; }
        public DbSet<fn_rbac_PackageStatus> fn_rbac_PackageStatus { get; set; }
        public DbSet<fn_rbac_UpdateCIs> fn_rbac_UpdateCIs { get; set; }
        public DbSet<fn_rbac_HS_VIRTUAL_MACHINE_EXT> fn_rbac_HS_VIRTUAL_MACHINE_EXT { get; set; }
        public DbSet<fn_rbac_GS_OFFICE_VBARULEVIOLATION> fn_rbac_GS_OFFICE_VBARULEVIOLATION { get; set; }
        public DbSet<fn_rbac_GS_ADD_REMOVE_PROGRAMS> fn_rbac_GS_ADD_REMOVE_PROGRAMS { get; set; }
        public DbSet<fn_rbac_GS_SoftwareFile> fn_rbac_GS_SoftwareFile { get; set; }
        public DbSet<fn_rbac_ClientCollectionMembers> fn_rbac_ClientCollectionMembers { get; set; }
        public DbSet<fn_rbac_GS_VOLUME> fn_rbac_GS_VOLUME { get; set; }
        public DbSet<fn_rbac_HS_OFFICE_VBARULEVIOLATION> fn_rbac_HS_OFFICE_VBARULEVIOLATION { get; set; }
        public DbSet<fn_rbac_HS_ADD_REMOVE_PROGRAMS> fn_rbac_HS_ADD_REMOVE_PROGRAMS { get; set; }
        public DbSet<fn_rbac_MonthlyUsageSummary> fn_rbac_MonthlyUsageSummary { get; set; }
        public DbSet<fn_rbac_HS_VOLUME> fn_rbac_HS_VOLUME { get; set; }
        public DbSet<fn_rbac_GS_OFFICE_VBASUMMARY> fn_rbac_GS_OFFICE_VBASUMMARY { get; set; }
        public DbSet<fn_rbac_GS_ADVANCED_CLIENT_PORTS> fn_rbac_GS_ADVANCED_CLIENT_PORTS { get; set; }
        public DbSet<fn_rbac_EndpointProtectionHealthStatus> fn_rbac_EndpointProtectionHealthStatus { get; set; }
        public DbSet<fn_rbac_GS_WEBAPP_APPLICATION> fn_rbac_GS_WEBAPP_APPLICATION { get; set; }
        public DbSet<fn_rbac_HS_OFFICE_VBASUMMARY> fn_rbac_HS_OFFICE_VBASUMMARY { get; set; }
        public DbSet<fn_rbac_HS_ADVANCED_CLIENT_PORTS> fn_rbac_HS_ADVANCED_CLIENT_PORTS { get; set; }
        public DbSet<fn_rbac_MIG_EntityReference> fn_rbac_MIG_EntityReference { get; set; }
        public DbSet<fn_rbac_HS_WEBAPP_APPLICATION> fn_rbac_HS_WEBAPP_APPLICATION { get; set; }
        public DbSet<fn_rbac_GS_OFFICE365PROPLUSCONFIGURATIONS> fn_rbac_GS_OFFICE365PROPLUSCONFIGURATIONS { get; set; }
        public DbSet<fn_rbac_GS_AMT_AGENT> fn_rbac_GS_AMT_AGENT { get; set; }
        public DbSet<fn_rbac_EndpointProtectionCollections> fn_rbac_EndpointProtectionCollections { get; set; }
        public DbSet<fn_rbac_MDMDeviceCategory> fn_rbac_MDMDeviceCategory { get; set; }
        public DbSet<fn_rbac_ConfigurationItems> fn_rbac_ConfigurationItems { get; set; }
        public DbSet<fn_rbac_GS_WINDOWSUPDATEAGENTVERSION> fn_rbac_GS_WINDOWSUPDATEAGENTVERSION { get; set; }
        public DbSet<fn_rbac_GS_MBAM_POLICY> fn_rbac_GS_MBAM_POLICY { get; set; }
        public DbSet<fn_rbac_HS_OFFICE365PROPLUSCONFIGURATIONS> fn_rbac_HS_OFFICE365PROPLUSCONFIGURATIONS { get; set; }
        public DbSet<fn_rbac_HS_AMT_AGENT> fn_rbac_HS_AMT_AGENT { get; set; }
        public DbSet<fn_rbac_SMSCICurrentComplianceStatus> fn_rbac_SMSCICurrentComplianceStatus { get; set; }
        public DbSet<fn_rbac_HS_WINDOWSUPDATEAGENTVERSION> fn_rbac_HS_WINDOWSUPDATEAGENTVERSION { get; set; }
        public DbSet<fn_rbac_HS_MBAM_POLICY> fn_rbac_HS_MBAM_POLICY { get; set; }
        public DbSet<fn_rbac_GS_OPERATING_SYSTEM> fn_rbac_GS_OPERATING_SYSTEM { get; set; }
        public DbSet<fn_rbac_GS_APPV_CLIENT_APPLICATION> fn_rbac_GS_APPV_CLIENT_APPLICATION { get; set; }
        public DbSet<fn_rbac_ClientDeploymentState> fn_rbac_ClientDeploymentState { get; set; }
        public DbSet<fn_rbac_DriverPackage> fn_rbac_DriverPackage { get; set; }
        public DbSet<fn_rbac_GS_WINDOWS8_APPLICATION> fn_rbac_GS_WINDOWS8_APPLICATION { get; set; }
        public DbSet<fn_rbac_HS_OPERATING_SYSTEM> fn_rbac_HS_OPERATING_SYSTEM { get; set; }
        public DbSet<fn_rbac_WOLEnabledAssignments> fn_rbac_WOLEnabledAssignments { get; set; }
        public DbSet<fn_rbac_HS_APPV_CLIENT_APPLICATION> fn_rbac_HS_APPV_CLIENT_APPLICATION { get; set; }
        public DbSet<fn_rbac_CIDriverCategories> fn_rbac_CIDriverCategories { get; set; }
        public DbSet<fn_rbac_cicontentpackage> fn_rbac_cicontentpackage { get; set; }
        public DbSet<fn_rbac_HS_WINDOWS8_APPLICATION> fn_rbac_HS_WINDOWS8_APPLICATION { get; set; }
        public DbSet<fn_rbac_GS_OPTIONAL_FEATURE> fn_rbac_GS_OPTIONAL_FEATURE { get; set; }
        public DbSet<fn_rbac_GS_APPV_CLIENT_PACKAGE> fn_rbac_GS_APPV_CLIENT_PACKAGE { get; set; }
        public DbSet<fn_rbac_Network_DATA_Serialized> fn_rbac_Network_DATA_Serialized { get; set; }
        public DbSet<fn_rbac_GS_WINDOWS8_APPLICATION_USER_INFO> fn_rbac_GS_WINDOWS8_APPLICATION_USER_INFO { get; set; }
        public DbSet<fn_rbac_HS_OPTIONAL_FEATURE> fn_rbac_HS_OPTIONAL_FEATURE { get; set; }
        public DbSet<fn_rbac_ThreatCatalog> fn_rbac_ThreatCatalog { get; set; }
        public DbSet<fn_rbac_HS_APPV_CLIENT_PACKAGE> fn_rbac_HS_APPV_CLIENT_PACKAGE { get; set; }
        public DbSet<fn_rbac_CIAssignmentTargetedMachines> fn_rbac_CIAssignmentTargetedMachines { get; set; }
        public DbSet<fn_rbac_MIG_Job> fn_rbac_MIG_Job { get; set; }
        public DbSet<fn_rbac_HS_WINDOWS8_APPLICATION_USER_INFO> fn_rbac_HS_WINDOWS8_APPLICATION_USER_INFO { get; set; }
        public DbSet<fn_rbac_GS_OS_RECOVERY_CONFIGURATION> fn_rbac_GS_OS_RECOVERY_CONFIGURATION { get; set; }
        public DbSet<fn_rbac_SMS_Alert> fn_rbac_SMS_Alert { get; set; }
        public DbSet<fn_rbac_GS_AUTOSTART_SOFTWARE> fn_rbac_GS_AUTOSTART_SOFTWARE { get; set; }
        public DbSet<fn_rbac_GS_WINDOWSUPDATE> fn_rbac_GS_WINDOWSUPDATE { get; set; }
        public DbSet<fn_rbac_HS_OS_RECOVERY_CONFIGURATION> fn_rbac_HS_OS_RECOVERY_CONFIGURATION { get; set; }
        public DbSet<fn_rbac_HS_AUTOSTART_SOFTWARE> fn_rbac_HS_AUTOSTART_SOFTWARE { get; set; }
        public DbSet<fn_rbac_LU_HardwareReadiness> fn_rbac_LU_HardwareReadiness { get; set; }
        public DbSet<fn_rbac_HS_WINDOWSUPDATE> fn_rbac_HS_WINDOWSUPDATE { get; set; }
        public DbSet<fn_rbac_GS_PAGE_FILE_SETTING> fn_rbac_GS_PAGE_FILE_SETTING { get; set; }
        public DbSet<fn_rbac_StatusMessagesAlerts> fn_rbac_StatusMessagesAlerts { get; set; }
        public DbSet<fn_rbac_GS_BASEBOARD> fn_rbac_GS_BASEBOARD { get; set; }
        public DbSet<fn_rbac_CIAssignmentToGroup> fn_rbac_CIAssignmentToGroup { get; set; }
        public DbSet<fn_rbac_GS_WORKSTATION_STATUS> fn_rbac_GS_WORKSTATION_STATUS { get; set; }
        public DbSet<fn_rbac_HS_PAGE_FILE_SETTING> fn_rbac_HS_PAGE_FILE_SETTING { get; set; }
        public DbSet<fn_rbac_Permissions> fn_rbac_Permissions { get; set; }
        public DbSet<fn_rbac_HS_BASEBOARD> fn_rbac_HS_BASEBOARD { get; set; }
        public DbSet<fn_rbac_GS_WRITE_FILTER_STATE> fn_rbac_GS_WRITE_FILTER_STATE { get; set; }
        public DbSet<fn_rbac_GS_OPERATING_SYSTEM_EXT> fn_rbac_GS_OPERATING_SYSTEM_EXT { get; set; }
        public DbSet<fn_rbac_GS_PARALLEL_PORT> fn_rbac_GS_PARALLEL_PORT { get; set; }
        public DbSet<fn_rbac_Package> fn_rbac_Package { get; set; }
        public DbSet<fn_rbac_GS_BATTERY> fn_rbac_GS_BATTERY { get; set; }
        public DbSet<fn_rbac_GS_AntimalwareHealthStatus> fn_rbac_GS_AntimalwareHealthStatus { get; set; }
        public DbSet<fn_rbac_HS_WRITE_FILTER_STATE> fn_rbac_HS_WRITE_FILTER_STATE { get; set; }
        public DbSet<fn_rbac_HS_OPERATING_SYSTEM_EXT> fn_rbac_HS_OPERATING_SYSTEM_EXT { get; set; }
        public DbSet<fn_rbac_CP_Machine> fn_rbac_CP_Machine { get; set; }
        public DbSet<fn_rbac_HS_PARALLEL_PORT> fn_rbac_HS_PARALLEL_PORT { get; set; }
        public DbSet<fn_rbac_GS_PHYSICALDISK> fn_rbac_GS_PHYSICALDISK { get; set; }
        public DbSet<fn_rbac_HS_BATTERY> fn_rbac_HS_BATTERY { get; set; }
        public DbSet<fn_rbac_WOLEnabledTaskSequences> fn_rbac_WOLEnabledTaskSequences { get; set; }
        public DbSet<fn_rbac_AAD_Statistics> fn_rbac_AAD_Statistics { get; set; }
        public DbSet<fn_rbac_GS_PARTITION> fn_rbac_GS_PARTITION { get; set; }
        public DbSet<fn_rbac_WOLSWDistTargetedClients> fn_rbac_WOLSWDistTargetedClients { get; set; }
        public DbSet<fn_rbac_MIG_JobEntity> fn_rbac_MIG_JobEntity { get; set; }
        public DbSet<fn_rbac_HS_PHYSICALDISK> fn_rbac_HS_PHYSICALDISK { get; set; }
        public DbSet<fn_rbac_GS_BOOT_CONFIGURATION> fn_rbac_GS_BOOT_CONFIGURATION { get; set; }
        public DbSet<fn_rbac_HS_PARTITION> fn_rbac_HS_PARTITION { get; set; }
        public DbSet<fn_rbac_WOLSUMTargetedClients> fn_rbac_WOLSUMTargetedClients { get; set; }
        public DbSet<fn_rbac_HS_BOOT_CONFIGURATION> fn_rbac_HS_BOOT_CONFIGURATION { get; set; }
        public DbSet<fn_rbac_Update_ComplianceStatusAll> fn_rbac_Update_ComplianceStatusAll { get; set; }
        public DbSet<fn_rbac_EndpointProtectionHealthStatus_History> fn_rbac_EndpointProtectionHealthStatus_History { get; set; }
        public DbSet<fn_rbac_GS_PC_BIOS> fn_rbac_GS_PC_BIOS { get; set; }
        public DbSet<fn_rbac_WakeupProxyDeploymentState> fn_rbac_WakeupProxyDeploymentState { get; set; }
        public DbSet<fn_rbac_MeteredUser> fn_rbac_MeteredUser { get; set; }
        public DbSet<fn_rbac_GS_BROWSER_HELPER_OBJECT> fn_rbac_GS_BROWSER_HELPER_OBJECT { get; set; }
        public DbSet<fn_rbac_WOLEnabledObjects> fn_rbac_WOLEnabledObjects { get; set; }
        public DbSet<fn_rbac_HS_PC_BIOS> fn_rbac_HS_PC_BIOS { get; set; }
        public DbSet<fn_rbac_UserHealthProfileState> fn_rbac_UserHealthProfileState { get; set; }
        public DbSet<fn_rbac_mdmdeviceproperty> fn_rbac_mdmdeviceproperty { get; set; }
        public DbSet<fn_rbac_HS_BROWSER_HELPER_OBJECT> fn_rbac_HS_BROWSER_HELPER_OBJECT { get; set; }
        public DbSet<fn_rbac_UpdateState_Combined> fn_rbac_UpdateState_Combined { get; set; }
        public DbSet<fn_rbac_vSMS_DistributionDPStatus> fn_rbac_vSMS_DistributionDPStatus { get; set; }
        public DbSet<fn_rbac_EAS_Property_S> fn_rbac_EAS_Property_S { get; set; }
        public DbSet<fn_rbac_GS_X86_PC_MEMORY> fn_rbac_GS_X86_PC_MEMORY { get; set; }
        public DbSet<fn_rbac_SystemInventoryChanges> fn_rbac_SystemInventoryChanges { get; set; }
        public DbSet<fn_rbac_GS_CDROM> fn_rbac_GS_CDROM { get; set; }
        public DbSet<fn_rbac_UpdateScanStatus> fn_rbac_UpdateScanStatus { get; set; }
        public DbSet<fn_rbac_ThreatSummary> fn_rbac_ThreatSummary { get; set; }
        public DbSet<fn_rbac_HS_X86_PC_MEMORY> fn_rbac_HS_X86_PC_MEMORY { get; set; }
        public DbSet<fn_rbac_StatusMessage> fn_rbac_StatusMessage { get; set; }
        public DbSet<fn_rbac_HS_CDROM> fn_rbac_HS_CDROM { get; set; }
        public DbSet<fn_rbac_ThreatCategories> fn_rbac_ThreatCategories { get; set; }
        public DbSet<fn_rbac_DpGroupPackages> fn_rbac_DpGroupPackages { get; set; }
        public DbSet<fn_rbac_GS_PCMCIA_CONTROLLER> fn_rbac_GS_PCMCIA_CONTROLLER { get; set; }
        public DbSet<fn_rbac_GS_EPDeploymentState> fn_rbac_GS_EPDeploymentState { get; set; }
        public DbSet<fn_rbac_GS_ClientEvents> fn_rbac_GS_ClientEvents { get; set; }
        public DbSet<fn_rbac_HS_PCMCIA_CONTROLLER> fn_rbac_HS_PCMCIA_CONTROLLER { get; set; }
        public DbSet<fn_rbac_DistributionPoint> fn_rbac_DistributionPoint { get; set; }
        public DbSet<fn_rbac_HS_ClientEvents> fn_rbac_HS_ClientEvents { get; set; }
        public DbSet<fn_rbac_MeteredFiles> fn_rbac_MeteredFiles { get; set; }
        public DbSet<fn_rbac_SmsPackage> fn_rbac_SmsPackage { get; set; }
        public DbSet<fn_rbac_GS_PHYSICAL_DISK> fn_rbac_GS_PHYSICAL_DISK { get; set; }
        public DbSet<fn_rbac_CIAssignmentToCI> fn_rbac_CIAssignmentToCI { get; set; }
        public DbSet<fn_rbac_ClientAdvertisementStatus> fn_rbac_ClientAdvertisementStatus { get; set; }
        public DbSet<fn_rbac_GS_COMPUTER_SYSTEM> fn_rbac_GS_COMPUTER_SYSTEM { get; set; }
        public DbSet<fn_rbac_DistributionPointInfo> fn_rbac_DistributionPointInfo { get; set; }
        public DbSet<fn_rbac_HS_PHYSICAL_DISK> fn_rbac_HS_PHYSICAL_DISK { get; set; }
        public DbSet<fn_rbac_AssignmentState_Combined> fn_rbac_AssignmentState_Combined { get; set; }
        public DbSet<fn_rbac_CI_DriversCIs> fn_rbac_CI_DriversCIs { get; set; }
        public DbSet<fn_rbac_HS_COMPUTER_SYSTEM> fn_rbac_HS_COMPUTER_SYSTEM { get; set; }
        public DbSet<fn_rbac_LastUsageSummary> fn_rbac_LastUsageSummary { get; set; }
        public DbSet<fn_rbac_Report_StatusMessageDetail> fn_rbac_Report_StatusMessageDetail { get; set; }
        public DbSet<fn_rbac_GS_PHYSICAL_MEMORY> fn_rbac_GS_PHYSICAL_MEMORY { get; set; }
        public DbSet<fn_rbac_ApplicationModelInfo> fn_rbac_ApplicationModelInfo { get; set; }
        public DbSet<fn_rbac_GS_COMPUTER_SYSTEM_PRODUCT> fn_rbac_GS_COMPUTER_SYSTEM_PRODUCT { get; set; }
        public DbSet<fn_rbac_MeterRuleInstallBase> fn_rbac_MeterRuleInstallBase { get; set; }
        public DbSet<fn_rbac_DeviceClientDeploymentState> fn_rbac_DeviceClientDeploymentState { get; set; }
        public DbSet<fn_rbac_HS_PHYSICAL_MEMORY> fn_rbac_HS_PHYSICAL_MEMORY { get; set; }
        public DbSet<fn_rbac_AppInTSDeployment> fn_rbac_AppInTSDeployment { get; set; }
        public DbSet<fn_rbac_HS_COMPUTER_SYSTEM_PRODUCT> fn_rbac_HS_COMPUTER_SYSTEM_PRODUCT { get; set; }
        public DbSet<fn_rbac_ClientMode> fn_rbac_ClientMode { get; set; }
        public DbSet<fn_rbac_MDMAppleLicenses> fn_rbac_MDMAppleLicenses { get; set; }
        public DbSet<fn_rbac_GS_PNP_DEVICE_DRIVER> fn_rbac_GS_PNP_DEVICE_DRIVER { get; set; }
        public DbSet<fn_rbac_GS_ACTIVESYNC_CONNECTED_DEVICE> fn_rbac_GS_ACTIVESYNC_CONNECTED_DEVICE { get; set; }
        public DbSet<fn_rbac_CIRelation_All> fn_rbac_CIRelation_All { get; set; }
        public DbSet<fn_rbac_GS_PORT> fn_rbac_GS_PORT { get; set; }
        public DbSet<fn_rbac_AppDeploymentSummary> fn_rbac_AppDeploymentSummary { get; set; }
        public DbSet<fn_rbac_HS_ACTIVESYNC_CONNECTED_DEVICE> fn_rbac_HS_ACTIVESYNC_CONNECTED_DEVICE { get; set; }
        public DbSet<fn_rbac_CI_DriverHardwareIDs> fn_rbac_CI_DriverHardwareIDs { get; set; }
        public DbSet<fn_rbac_HS_PORT> fn_rbac_HS_PORT { get; set; }
        public DbSet<fn_rbac_GS_DEFAULT_BROWSER> fn_rbac_GS_DEFAULT_BROWSER { get; set; }
        public DbSet<fn_rbac_CategoryMembershipsWithCollection> fn_rbac_CategoryMembershipsWithCollection { get; set; }
        public DbSet<fn_rbac_inventoryreportclass> fn_rbac_inventoryreportclass { get; set; }
        public DbSet<fn_rbac_GS_PORTABLE_BATTERY> fn_rbac_GS_PORTABLE_BATTERY { get; set; }
        public DbSet<fn_rbac_HS_DEFAULT_BROWSER> fn_rbac_HS_DEFAULT_BROWSER { get; set; }
        public DbSet<fn_rbac_TaskExecutionStatus> fn_rbac_TaskExecutionStatus { get; set; }
        public DbSet<fn_rbac_HS_PORTABLE_BATTERY> fn_rbac_HS_PORTABLE_BATTERY { get; set; }
        public DbSet<fn_rbac_AlertValidFeatureArea> fn_rbac_AlertValidFeatureArea { get; set; }
        public DbSet<fn_rbac_GS_DESKTOP> fn_rbac_GS_DESKTOP { get; set; }
        public DbSet<fn_rbac_BootImagePackage_References> fn_rbac_BootImagePackage_References { get; set; }
        public DbSet<fn_rbac_FolderRedirectionState> fn_rbac_FolderRedirectionState { get; set; }
        public DbSet<fn_rbac_CIToContent> fn_rbac_CIToContent { get; set; }
        public DbSet<fn_rbac_GS_POWER_MANAGEMENT_CAPABILITIES> fn_rbac_GS_POWER_MANAGEMENT_CAPABILITIES { get; set; }
        public DbSet<fn_rbac_HS_DESKTOP> fn_rbac_HS_DESKTOP { get; set; }
        public DbSet<fn_rbac_CICategories> fn_rbac_CICategories { get; set; }
        public DbSet<fn_rbac_SummarizationInterval> fn_rbac_SummarizationInterval { get; set; }
        public DbSet<fn_rbac_GS_POWER_MANAGEMENT_CLIENTOPTOUT_SETTINGS> fn_rbac_GS_POWER_MANAGEMENT_CLIENTOPTOUT_SETTINGS { get; set; }
        public DbSet<fn_rbac_AI_NON_MS_LICENSE> fn_rbac_AI_NON_MS_LICENSE { get; set; }
        public DbSet<fn_rbac_GS_DESKTOP_MONITOR> fn_rbac_GS_DESKTOP_MONITOR { get; set; }
        public DbSet<fn_rbac_BootImagePackage> fn_rbac_BootImagePackage { get; set; }
        public DbSet<fn_rbac_CIAssignment> fn_rbac_CIAssignment { get; set; }
        public DbSet<fn_rbac_FileUsageSummaryIntervals> fn_rbac_FileUsageSummaryIntervals { get; set; }
        public DbSet<fn_rbac_SMS_CIRelation> fn_rbac_SMS_CIRelation { get; set; }
        public DbSet<fn_rbac_GS_POWER_MANAGEMENT_CONFIGURATION> fn_rbac_GS_POWER_MANAGEMENT_CONFIGURATION { get; set; }
        public DbSet<fn_rbac_HS_DESKTOP_MONITOR> fn_rbac_HS_DESKTOP_MONITOR { get; set; }
        public DbSet<fn_rbac_CurrentAdvertisementAssignments> fn_rbac_CurrentAdvertisementAssignments { get; set; }
        public DbSet<fn_rbac_GS_POWER_MANAGEMENT_DAY> fn_rbac_GS_POWER_MANAGEMENT_DAY { get; set; }
        public DbSet<fn_rbac_GS_OFFICE_CLIENTMETRIC> fn_rbac_GS_OFFICE_CLIENTMETRIC { get; set; }
        public DbSet<fn_rbac_GS_DEVICE_BLUETOOTH> fn_rbac_GS_DEVICE_BLUETOOTH { get; set; }
        public DbSet<fn_rbac_Admins> fn_rbac_Admins { get; set; }
        public DbSet<fn_rbac_ClientHealthState> fn_rbac_ClientHealthState { get; set; }
        public DbSet<fn_rbac_Update_ComplianceSummary_Live> fn_rbac_Update_ComplianceSummary_Live { get; set; }
        public DbSet<fn_rbac_ServiceWindow> fn_rbac_ServiceWindow { get; set; }
        public DbSet<fn_rbac_GS_POWER_MANAGEMENT_MONTH> fn_rbac_GS_POWER_MANAGEMENT_MONTH { get; set; }
        public DbSet<fn_rbac_HS_OFFICE_CLIENTMETRIC> fn_rbac_HS_OFFICE_CLIENTMETRIC { get; set; }
        public DbSet<fn_rbac_HS_DEVICE_BLUETOOTH> fn_rbac_HS_DEVICE_BLUETOOTH { get; set; }
        public DbSet<fn_rbac_UpdateAssignmentStatus_Live> fn_rbac_UpdateAssignmentStatus_Live { get; set; }
        public DbSet<fn_rbac_CIAssignmentTargetedCollections> fn_rbac_CIAssignmentTargetedCollections { get; set; }
        public DbSet<fn_rbac_GS_POWER_MANAGEMENT_SETTINGS> fn_rbac_GS_POWER_MANAGEMENT_SETTINGS { get; set; }
        public DbSet<fn_rbac_GS_OFFICE_DEVICESUMMARY> fn_rbac_GS_OFFICE_DEVICESUMMARY { get; set; }
        public DbSet<fn_rbac_GS_DEVICE_CAMERA> fn_rbac_GS_DEVICE_CAMERA { get; set; }
        public DbSet<fn_rbac_SystemResourceList> fn_rbac_SystemResourceList { get; set; }
        public DbSet<fn_rbac_AllItems> fn_rbac_AllItems { get; set; }
        public DbSet<fn_rbac_GS_POWER_MANAGEMENT_SUSPEND_ERROR> fn_rbac_GS_POWER_MANAGEMENT_SUSPEND_ERROR { get; set; }
        public DbSet<fn_rbac_HS_OFFICE_DEVICESUMMARY> fn_rbac_HS_OFFICE_DEVICESUMMARY { get; set; }
        public DbSet<fn_rbac_HS_DEVICE_CAMERA> fn_rbac_HS_DEVICE_CAMERA { get; set; }
        public DbSet<fn_rbac_CAL_Processor_Count> fn_rbac_CAL_Processor_Count { get; set; }
        public DbSet<fn_rbac_SummarizerSiteStatus> fn_rbac_SummarizerSiteStatus { get; set; }
        public DbSet<fn_rbac_WOLCommunicationHistory> fn_rbac_WOLCommunicationHistory { get; set; }
        public DbSet<fn_rbac_GS_POWER_SUPPLY> fn_rbac_GS_POWER_SUPPLY { get; set; }
        public DbSet<fn_rbac_GS_OFFICE_DOCUMENTSOLUTION> fn_rbac_GS_OFFICE_DOCUMENTSOLUTION { get; set; }
        public DbSet<fn_rbac_GS_DEVICE_CERTIFICATES> fn_rbac_GS_DEVICE_CERTIFICATES { get; set; }
        public DbSet<fn_rbac_StatMsgModuleNames> fn_rbac_StatMsgModuleNames { get; set; }
        public DbSet<fn_rbac_TaskSequenceReferencesInfo> fn_rbac_TaskSequenceReferencesInfo { get; set; }
        public DbSet<fn_rbac_HS_POWER_SUPPLY> fn_rbac_HS_POWER_SUPPLY { get; set; }
        public DbSet<fn_rbac_HS_OFFICE_DOCUMENTSOLUTION> fn_rbac_HS_OFFICE_DOCUMENTSOLUTION { get; set; }
        public DbSet<fn_rbac_HS_DEVICE_CERTIFICATES> fn_rbac_HS_DEVICE_CERTIFICATES { get; set; }
        public DbSet<fn_rbac_SMS_SC_SysResUse_Properties> fn_rbac_SMS_SC_SysResUse_Properties { get; set; }
        public DbSet<fn_rbac_GS_PRINT_JOB> fn_rbac_GS_PRINT_JOB { get; set; }
        public DbSet<fn_rbac_WOLGetWOLEnabledSites> fn_rbac_WOLGetWOLEnabledSites { get; set; }
        public DbSet<fn_rbac_GS_OFFICE_MACROERROR> fn_rbac_GS_OFFICE_MACROERROR { get; set; }
        public DbSet<fn_rbac_GS_DEVICE_CLIENT> fn_rbac_GS_DEVICE_CLIENT { get; set; }
        public DbSet<fn_rbac_CM_RES_COLL_SMS00001> fn_rbac_CM_RES_COLL_SMS00001 { get; set; }
        public DbSet<fn_rbac_PackageStatusDistPointsSumm> fn_rbac_PackageStatusDistPointsSumm { get; set; }
        public DbSet<fn_rbac_securedobjecttypes> fn_rbac_securedobjecttypes { get; set; }
        public DbSet<fn_rbac_TaskSequencePackage> fn_rbac_TaskSequencePackage { get; set; }
        public DbSet<fn_rbac_HS_PRINT_JOB> fn_rbac_HS_PRINT_JOB { get; set; }
        public DbSet<fn_rbac_HS_OFFICE_MACROERROR> fn_rbac_HS_OFFICE_MACROERROR { get; set; }
        public DbSet<fn_rbac_HS_DEVICE_CLIENT> fn_rbac_HS_DEVICE_CLIENT { get; set; }
        public DbSet<fn_rbac_WOLCommunicationErrorStatus> fn_rbac_WOLCommunicationErrorStatus { get; set; }
        public DbSet<fn_rbac_AllowOrDenyListViolationData> fn_rbac_AllowOrDenyListViolationData { get; set; }
        public DbSet<fn_rbac_DeploymentSummary2> fn_rbac_DeploymentSummary2 { get; set; }
        public DbSet<fn_rbac_System_SMS_Assign_ARR> fn_rbac_System_SMS_Assign_ARR { get; set; }
        public DbSet<fn_rbac_GS_PRINTER_CONFIGURATION> fn_rbac_GS_PRINTER_CONFIGURATION { get; set; }
        public DbSet<fn_rbac_UserMachineSourceRelation> fn_rbac_UserMachineSourceRelation { get; set; }
        public DbSet<fn_rbac_GS_DEVICE_CLIENTAGENTVERSION> fn_rbac_GS_DEVICE_CLIENTAGENTVERSION { get; set; }
        public DbSet<fn_rbac_SupportedPlatforms> fn_rbac_SupportedPlatforms { get; set; }
        public DbSet<fn_rbac_ApplicationIdToNameMap> fn_rbac_ApplicationIdToNameMap { get; set; }
        public DbSet<fn_rbac_Collections> fn_rbac_Collections { get; set; }
        public DbSet<fn_rbac_StateMigration> fn_rbac_StateMigration { get; set; }
        public DbSet<fn_rbac_HS_PRINTER_CONFIGURATION> fn_rbac_HS_PRINTER_CONFIGURATION { get; set; }
        public DbSet<fn_rbac_SoftwareUpdateSource> fn_rbac_SoftwareUpdateSource { get; set; }
        public DbSet<fn_rbac_HS_DEVICE_CLIENTAGENTVERSION> fn_rbac_HS_DEVICE_CLIENTAGENTVERSION { get; set; }
        public DbSet<fn_rbac_replicationdata> fn_rbac_replicationdata { get; set; }
        public DbSet<fn_rbac_CI_CurrentComplianceStatus> fn_rbac_CI_CurrentComplianceStatus { get; set; }
        public DbSet<fn_rbac_CM_RES_COLL_SMS00002> fn_rbac_CM_RES_COLL_SMS00002 { get; set; }
        public DbSet<fn_rbac_ClientMachines> fn_rbac_ClientMachines { get; set; }
        public DbSet<fn_rbac_GS_PRINTER_DEVICE> fn_rbac_GS_PRINTER_DEVICE { get; set; }
        public DbSet<fn_rbac_ObjectsAssignedToOneCategory> fn_rbac_ObjectsAssignedToOneCategory { get; set; }
        public DbSet<fn_rbac_GS_DEVICE_COMPUTERSYSTEM> fn_rbac_GS_DEVICE_COMPUTERSYSTEM { get; set; }
        public DbSet<fn_rbac_ProgramOffers> fn_rbac_ProgramOffers { get; set; }
        public DbSet<fn_rbac_SMS_DistributionPointGroup> fn_rbac_SMS_DistributionPointGroup { get; set; }
        public DbSet<fn_rbac_HS_PRINTER_DEVICE> fn_rbac_HS_PRINTER_DEVICE { get; set; }
        public DbSet<fn_rbac_MDMHealthAttestation> fn_rbac_MDMHealthAttestation { get; set; }
        public DbSet<fn_rbac_HS_DEVICE_COMPUTERSYSTEM> fn_rbac_HS_DEVICE_COMPUTERSYSTEM { get; set; }
        public DbSet<fn_rbac_ProductFileInfo> fn_rbac_ProductFileInfo { get; set; }
        public DbSet<fn_rbac_CISettings> fn_rbac_CISettings { get; set; }
        public DbSet<fn_rbac_SecuredCategories> fn_rbac_SecuredCategories { get; set; }
        public DbSet<fn_rbac_GS_PROCESS> fn_rbac_GS_PROCESS { get; set; }
        public DbSet<fn_rbac_LU_Tags> fn_rbac_LU_Tags { get; set; }
        public DbSet<fn_rbac_GS_DEVICE_DISPLAY> fn_rbac_GS_DEVICE_DISPLAY { get; set; }
        public DbSet<fn_rbac_Package2> fn_rbac_Package2 { get; set; }
        public DbSet<fn_rbac_CM_RES_COLL_SMS00003> fn_rbac_CM_RES_COLL_SMS00003 { get; set; }
        public DbSet<fn_rbac_MDMDeviceThreat> fn_rbac_MDMDeviceThreat { get; set; }
        public DbSet<fn_rbac_HS_PROCESS> fn_rbac_HS_PROCESS { get; set; }
        public DbSet<fn_rbac_HS_DEVICE_DISPLAY> fn_rbac_HS_DEVICE_DISPLAY { get; set; }
        public DbSet<fn_rbac_MIG_Entities> fn_rbac_MIG_Entities { get; set; }
        public DbSet<fn_rbac_CISettingReferences> fn_rbac_CISettingReferences { get; set; }
        public DbSet<fn_rbac_GS_PROCESSOR> fn_rbac_GS_PROCESSOR { get; set; }
        public DbSet<fn_rbac_LocalizedCIProperties2> fn_rbac_LocalizedCIProperties2 { get; set; }
        public DbSet<fn_rbac_GS_DEVICE_EMAIL> fn_rbac_GS_DEVICE_EMAIL { get; set; }
        public DbSet<fn_rbac_CIRules> fn_rbac_CIRules { get; set; }
        public DbSet<fn_rbac_HS_PROCESSOR> fn_rbac_HS_PROCESSOR { get; set; }
        public DbSet<fn_rbac_LocalizedCategories_SiteLoc> fn_rbac_LocalizedCategories_SiteLoc { get; set; }
        public DbSet<fn_rbac_HS_DEVICE_EMAIL> fn_rbac_HS_DEVICE_EMAIL { get; set; }
        public DbSet<fn_rbac_FileUsageSummary> fn_rbac_FileUsageSummary { get; set; }
        public DbSet<fn_rbac_CM_RES_COLL_SMS00004> fn_rbac_CM_RES_COLL_SMS00004 { get; set; }
        public DbSet<fn_rbac_DeviceClientHealthState> fn_rbac_DeviceClientHealthState { get; set; }
        public DbSet<fn_rbac_GS_PROTECTED_VOLUME_INFO> fn_rbac_GS_PROTECTED_VOLUME_INFO { get; set; }
        public DbSet<fn_rbac_GS_DEVICE_ENCRYPTION> fn_rbac_GS_DEVICE_ENCRYPTION { get; set; }
        public DbSet<fn_rbac_DPGroupMembers> fn_rbac_DPGroupMembers { get; set; }
        public DbSet<fn_rbac_ClassicDeploymentAssetDetails> fn_rbac_ClassicDeploymentAssetDetails { get; set; }
        public DbSet<fn_rbac_HS_PROTECTED_VOLUME_INFO> fn_rbac_HS_PROTECTED_VOLUME_INFO { get; set; }
        public DbSet<fn_rbac_GS_AntimalwareInfectionStatus> fn_rbac_GS_AntimalwareInfectionStatus { get; set; }
        public DbSet<fn_rbac_HS_DEVICE_ENCRYPTION> fn_rbac_HS_DEVICE_ENCRYPTION { get; set; }
        public DbSet<fn_rbac_CollectionExpandedUserMembers> fn_rbac_CollectionExpandedUserMembers { get; set; }
        public DbSet<fn_rbac_GS_PROTOCOL> fn_rbac_GS_PROTOCOL { get; set; }
        public DbSet<fn_rbac_GetAdminIDsfromUserSIDs> fn_rbac_GetAdminIDsfromUserSIDs { get; set; }
        public DbSet<fn_rbac_GS_DEVICE_EXCHANGE> fn_rbac_GS_DEVICE_EXCHANGE { get; set; }
        public DbSet<fn_rbac_CH_ClientSummaryHistory> fn_rbac_CH_ClientSummaryHistory { get; set; }
        public DbSet<fn_rbac_CM_RES_COLL_SMSOTHER> fn_rbac_CM_RES_COLL_SMSOTHER { get; set; }
        public DbSet<fn_rbac_HS_PROTOCOL> fn_rbac_HS_PROTOCOL { get; set; }
        public DbSet<fn_rbac_ConfigurationItemsOSD> fn_rbac_ConfigurationItemsOSD { get; set; }
        public DbSet<fn_rbac_HS_DEVICE_EXCHANGE> fn_rbac_HS_DEVICE_EXCHANGE { get; set; }
        public DbSet<fn_rbac_CIRulesAll> fn_rbac_CIRulesAll { get; set; }
        public DbSet<fn_rbac_GS_QUICK_FIX_ENGINEERING> fn_rbac_GS_QUICK_FIX_ENGINEERING { get; set; }
        public DbSet<fn_rbac_GS_DEVICE_INFO> fn_rbac_GS_DEVICE_INFO { get; set; }
        public DbSet<fn_rbac_HS_QUICK_FIX_ENGINEERING> fn_rbac_HS_QUICK_FIX_ENGINEERING { get; set; }
        public DbSet<fn_rbac_ClientModeReadiness> fn_rbac_ClientModeReadiness { get; set; }
        public DbSet<fn_rbac_GS_DEVICE_INSTALLEDAPPLICATIONS> fn_rbac_GS_DEVICE_INSTALLEDAPPLICATIONS { get; set; }
        public DbSet<fn_rbac_CM_RES_COLL_SMS000US> fn_rbac_CM_RES_COLL_SMS000US { get; set; }
        public DbSet<fn_rbac_CIComplianceSummary> fn_rbac_CIComplianceSummary { get; set; }
        public DbSet<fn_rbac_CM_RES_COLL_PS100014> fn_rbac_CM_RES_COLL_PS100014 { get; set; }
        public DbSet<fn_rbac_GS_RAX_APPLICATION> fn_rbac_GS_RAX_APPLICATION { get; set; }
        public DbSet<fn_rbac_Collection> fn_rbac_Collection { get; set; }
        public DbSet<fn_rbac_HS_DEVICE_INSTALLEDAPPLICATIONS> fn_rbac_HS_DEVICE_INSTALLEDAPPLICATIONS { get; set; }
        public DbSet<fn_rbac_R_IPNetwork> fn_rbac_R_IPNetwork { get; set; }
        public DbSet<fn_rbac_HS_RAX_APPLICATION> fn_rbac_HS_RAX_APPLICATION { get; set; }
        public DbSet<fn_rbac_CIAssignmentStatus> fn_rbac_CIAssignmentStatus { get; set; }
        public DbSet<fn_rbac_GS_DEVICE_IRDA> fn_rbac_GS_DEVICE_IRDA { get; set; }
        public DbSet<fn_rbac_R_ProvisioningSystem> fn_rbac_R_ProvisioningSystem { get; set; }
        public DbSet<fn_rbac_GS_SYSTEM_ENCLOSURE_UNIQUE> fn_rbac_GS_SYSTEM_ENCLOSURE_UNIQUE { get; set; }
        public DbSet<fn_rbac_WOLEnabledAdvertisements> fn_rbac_WOLEnabledAdvertisements { get; set; }
        public DbSet<fn_rbac_CIComplianceHistory> fn_rbac_CIComplianceHistory { get; set; }
        public DbSet<fn_rbac_GS_CCM_RECENTLY_USED_APPS> fn_rbac_GS_CCM_RECENTLY_USED_APPS { get; set; }
        public DbSet<fn_rbac_HS_DEVICE_IRDA> fn_rbac_HS_DEVICE_IRDA { get; set; }
        public DbSet<fn_rbac_CM_RES_COLL_SMSDM001> fn_rbac_CM_RES_COLL_SMSDM001 { get; set; }
        public DbSet<fn_rbac_GS_REGISTRY> fn_rbac_GS_REGISTRY { get; set; }
        public DbSet<fn_rbac_CAL_INSTALLED_SOFTWARE_DATA> fn_rbac_CAL_INSTALLED_SOFTWARE_DATA { get; set; }
        public DbSet<fn_rbac_GS_DEVICE_MEMORY_ADDRESS> fn_rbac_GS_DEVICE_MEMORY_ADDRESS { get; set; }
        public DbSet<fn_rbac_StatMsgInsStrings> fn_rbac_StatMsgInsStrings { get; set; }
        public DbSet<fn_rbac_AppIntentAssetData> fn_rbac_AppIntentAssetData { get; set; }
        public DbSet<fn_rbac_HS_REGISTRY> fn_rbac_HS_REGISTRY { get; set; }
        public DbSet<fn_rbac_AMTMachineInfo> fn_rbac_AMTMachineInfo { get; set; }
        public DbSet<fn_rbac_HS_DEVICE_MEMORY_ADDRESS> fn_rbac_HS_DEVICE_MEMORY_ADDRESS { get; set; }
        public DbSet<fn_rbac_AgentDiscoveries> fn_rbac_AgentDiscoveries { get; set; }
        public DbSet<fn_rbac_GS_SCSI_CONTROLLER> fn_rbac_GS_SCSI_CONTROLLER { get; set; }
        public DbSet<fn_rbac_GS_DEVICE_MEMORY> fn_rbac_GS_DEVICE_MEMORY { get; set; }
        public DbSet<fn_rbac_tasksequenceappreferencesinfo> fn_rbac_tasksequenceappreferencesinfo { get; set; }
        public DbSet<fn_rbac_LU_LicensedProduct> fn_rbac_LU_LicensedProduct { get; set; }
        public DbSet<fn_rbac_CM_RES_COLL_SMSDM003> fn_rbac_CM_RES_COLL_SMSDM003 { get; set; }
        public DbSet<fn_rbac_HS_SCSI_CONTROLLER> fn_rbac_HS_SCSI_CONTROLLER { get; set; }
        public DbSet<fn_rbac_HS_DEVICE_MEMORY> fn_rbac_HS_DEVICE_MEMORY { get; set; }
        public DbSet<fn_rbac_WOLGetPendingObjectSchedules> fn_rbac_WOLGetPendingObjectSchedules { get; set; }
        public DbSet<fn_rbac_LicenseKeyStatus> fn_rbac_LicenseKeyStatus { get; set; }
        public DbSet<fn_rbac_Add_Remove_Programs> fn_rbac_Add_Remove_Programs { get; set; }
        public DbSet<fn_rbac_GS_SERIAL_PORT_CONFIGURATION> fn_rbac_GS_SERIAL_PORT_CONFIGURATION { get; set; }
        public DbSet<fn_rbac_GS_DEVICE_OSINFORMATION> fn_rbac_GS_DEVICE_OSINFORMATION { get; set; }
        public DbSet<fn_rbac_SoftwareProduct> fn_rbac_SoftwareProduct { get; set; }
        public DbSet<fn_rbac_HS_SERIAL_PORT_CONFIGURATION> fn_rbac_HS_SERIAL_PORT_CONFIGURATION { get; set; }
        public DbSet<fn_rbac_HS_DEVICE_OSINFORMATION> fn_rbac_HS_DEVICE_OSINFORMATION { get; set; }
        public DbSet<fn_rbac_SMS_SC_SysResUse> fn_rbac_SMS_SC_SysResUse { get; set; }
        public DbSet<fn_rbac_GS_LastSoftwareScan> fn_rbac_GS_LastSoftwareScan { get; set; }
        public DbSet<fn_rbac_GS_SERIAL_PORT> fn_rbac_GS_SERIAL_PORT { get; set; }
        public DbSet<fn_rbac_GS_DEVICE_PASSWORD> fn_rbac_GS_DEVICE_PASSWORD { get; set; }
        public DbSet<fn_rbac_Roles> fn_rbac_Roles { get; set; }
        public DbSet<fn_rbac_usermachinerelation> fn_rbac_usermachinerelation { get; set; }
        public DbSet<fn_rbac_HS_SERIAL_PORT> fn_rbac_HS_SERIAL_PORT { get; set; }
        public DbSet<fn_rbac_HS_DEVICE_PASSWORD> fn_rbac_HS_DEVICE_PASSWORD { get; set; }
        public DbSet<fn_rbac_Program> fn_rbac_Program { get; set; }
        public DbSet<fn_rbac_en_clientcertificaterecords> fn_rbac_en_clientcertificaterecords { get; set; }
        public DbSet<fn_rbac_GS_SERVER_FEATURE> fn_rbac_GS_SERVER_FEATURE { get; set; }
        public DbSet<fn_rbac_GS_DEVICE_POLICY> fn_rbac_GS_DEVICE_POLICY { get; set; }
        public DbSet<fn_rbac_dcmdeploymentresourcesuser> fn_rbac_dcmdeploymentresourcesuser { get; set; }
        public DbSet<fn_rbac_HS_SERVER_FEATURE> fn_rbac_HS_SERVER_FEATURE { get; set; }
        public DbSet<fn_rbac_HS_DEVICE_POLICY> fn_rbac_HS_DEVICE_POLICY { get; set; }
        public DbSet<fn_rbac_MIG_Clients> fn_rbac_MIG_Clients { get; set; }
        public DbSet<fn_rbac_GS_SERVICE> fn_rbac_GS_SERVICE { get; set; }
        public DbSet<fn_rbac_GS_DEVICE_POWER> fn_rbac_GS_DEVICE_POWER { get; set; }
        public DbSet<fn_rbac_MDMDeviceManagementStates> fn_rbac_MDMDeviceManagementStates { get; set; }
        public DbSet<fn_rbac_CITargetedCollections> fn_rbac_CITargetedCollections { get; set; }
        public DbSet<fn_rbac_HS_SERVICE> fn_rbac_HS_SERVICE { get; set; }
        public DbSet<fn_rbac_HS_DEVICE_POWER> fn_rbac_HS_DEVICE_POWER { get; set; }
        public DbSet<fn_rbac_LocalizedCIProperties_SiteLoc> fn_rbac_LocalizedCIProperties_SiteLoc { get; set; }
        public DbSet<fn_rbac_AssignmentStatePerTopic> fn_rbac_AssignmentStatePerTopic { get; set; }
        public DbSet<fn_rbac_GS_SHARE> fn_rbac_GS_SHARE { get; set; }
        public DbSet<fn_rbac_GS_DEVICE_WINDOWSSECURITYPOLICY> fn_rbac_GS_DEVICE_WINDOWSSECURITYPOLICY { get; set; }
        public DbSet<fn_rbac_LU_Category> fn_rbac_LU_Category { get; set; }
        public DbSet<fn_rbac_Alert> fn_rbac_Alert { get; set; }
        public DbSet<fn_rbac_HS_SHARE> fn_rbac_HS_SHARE { get; set; }
        public DbSet<fn_rbac_HS_DEVICE_WINDOWSSECURITYPOLICY> fn_rbac_HS_DEVICE_WINDOWSSECURITYPOLICY { get; set; }
        public DbSet<fn_rbac_R_System> fn_rbac_R_System { get; set; }
        public DbSet<fn_rbac_GS_Threats> fn_rbac_GS_Threats { get; set; }
        public DbSet<fn_rbac_GS_SMS_ADVANCED_CLIENT_STATE> fn_rbac_GS_SMS_ADVANCED_CLIENT_STATE { get; set; }
        public DbSet<fn_rbac_GS_DEVICE_WLAN> fn_rbac_GS_DEVICE_WLAN { get; set; }
        public DbSet<fn_rbac_RA_System_IPAddresses> fn_rbac_RA_System_IPAddresses { get; set; }
        public DbSet<fn_rbac_FullCollectionMembership> fn_rbac_FullCollectionMembership { get; set; }
        public DbSet<fn_rbac_EN_CertificateAuthorities> fn_rbac_EN_CertificateAuthorities { get; set; }
        public DbSet<fn_rbac_HS_SMS_ADVANCED_CLIENT_STATE> fn_rbac_HS_SMS_ADVANCED_CLIENT_STATE { get; set; }
        public DbSet<fn_rbac_HS_DEVICE_WLAN> fn_rbac_HS_DEVICE_WLAN { get; set; }
        public DbSet<fn_rbac_RA_System_IPSubnets> fn_rbac_RA_System_IPSubnets { get; set; }
        public DbSet<fn_rbac_CI_ApplicablePlatforms> fn_rbac_CI_ApplicablePlatforms { get; set; }
        public DbSet<fn_rbac_GS_SOFTWARE_SHORTCUT> fn_rbac_GS_SOFTWARE_SHORTCUT { get; set; }
        public DbSet<fn_rbac_GS_DISK> fn_rbac_GS_DISK { get; set; }
        public DbSet<fn_rbac_RA_System_IPv6Addresses> fn_rbac_RA_System_IPv6Addresses { get; set; }
        public DbSet<fn_rbac_CH_HealthCheckInfo> fn_rbac_CH_HealthCheckInfo { get; set; }
        public DbSet<fn_rbac_DrsSendHistorySummary> fn_rbac_DrsSendHistorySummary { get; set; }
        public DbSet<fn_rbac_HS_SOFTWARE_SHORTCUT> fn_rbac_HS_SOFTWARE_SHORTCUT { get; set; }
        public DbSet<fn_rbac_HS_DISK> fn_rbac_HS_DISK { get; set; }
        public DbSet<fn_rbac_RA_System_IPv6Prefixes> fn_rbac_RA_System_IPv6Prefixes { get; set; }
        public DbSet<fn_rbac_CH_ClientSummary> fn_rbac_CH_ClientSummary { get; set; }
        public DbSet<fn_rbac_UserMachineIntelligence> fn_rbac_UserMachineIntelligence { get; set; }
        public DbSet<fn_rbac_GS_SOFTWARE_TAG> fn_rbac_GS_SOFTWARE_TAG { get; set; }
        public DbSet<fn_rbac_GS_DMA_CHANNEL> fn_rbac_GS_DMA_CHANNEL { get; set; }
        public DbSet<fn_rbac_RA_System_MACAddresses> fn_rbac_RA_System_MACAddresses { get; set; }
        public DbSet<fn_rbac_HS_SOFTWARE_TAG> fn_rbac_HS_SOFTWARE_TAG { get; set; }
        public DbSet<fn_rbac_HS_DMA_CHANNEL> fn_rbac_HS_DMA_CHANNEL { get; set; }
        public DbSet<fn_rbac_RA_System_ResourceNames> fn_rbac_RA_System_ResourceNames { get; set; }
        public DbSet<fn_rbac_GS_SOUND_DEVICE> fn_rbac_GS_SOUND_DEVICE { get; set; }
        public DbSet<fn_rbac_GS_DRIVER_VXD> fn_rbac_GS_DRIVER_VXD { get; set; }
        public DbSet<fn_rbac_RA_System_SystemGroupName> fn_rbac_RA_System_SystemGroupName { get; set; }
        public DbSet<fn_rbac_DM_WipeRecords> fn_rbac_DM_WipeRecords { get; set; }
        public DbSet<fn_rbac_HS_SOUND_DEVICE> fn_rbac_HS_SOUND_DEVICE { get; set; }
        public DbSet<fn_rbac_HS_DRIVER_VXD> fn_rbac_HS_DRIVER_VXD { get; set; }
        public DbSet<fn_rbac_RA_System_SMSAssignedSites> fn_rbac_RA_System_SMSAssignedSites { get; set; }
        public DbSet<fn_rbac_AssignmentTargetedCIs> fn_rbac_AssignmentTargetedCIs { get; set; }
        public DbSet<fn_rbac_CIConflictCode> fn_rbac_CIConflictCode { get; set; }
        public DbSet<fn_rbac_GS_ADVANCED_CLIENT_SSL_CONFIGURATIONS> fn_rbac_GS_ADVANCED_CLIENT_SSL_CONFIGURATIONS { get; set; }
        public DbSet<fn_rbac_GS_EMBEDDED_DEVICE_INFO> fn_rbac_GS_EMBEDDED_DEVICE_INFO { get; set; }
        public DbSet<fn_rbac_RA_System_SMSInstalledSites> fn_rbac_RA_System_SMSInstalledSites { get; set; }
        public DbSet<fn_rbac_ApplicationAssignment> fn_rbac_ApplicationAssignment { get; set; }
        public DbSet<fn_rbac_HS_ADVANCED_CLIENT_SSL_CONFIGURATIONS> fn_rbac_HS_ADVANCED_CLIENT_SSL_CONFIGURATIONS { get; set; }
        public DbSet<fn_rbac_HS_EMBEDDED_DEVICE_INFO> fn_rbac_HS_EMBEDDED_DEVICE_INFO { get; set; }
        public DbSet<fn_rbac_RA_System_SMS_Resident> fn_rbac_RA_System_SMS_Resident { get; set; }
        public DbSet<fn_rbac_Advertisement> fn_rbac_Advertisement { get; set; }
        public DbSet<fn_rbac_DistributionPoints> fn_rbac_DistributionPoints { get; set; }
        public DbSet<fn_rbac_CIComplianceStatusErrorDetail> fn_rbac_CIComplianceStatusErrorDetail { get; set; }
        public DbSet<fn_rbac_GS_SOFTWARE_LICENSING_PRODUCT> fn_rbac_GS_SOFTWARE_LICENSING_PRODUCT { get; set; }
        public DbSet<fn_rbac_GS_ENCRYPTABLE_VOLUME> fn_rbac_GS_ENCRYPTABLE_VOLUME { get; set; }
        public DbSet<fn_rbac_RA_System_SystemContainerName> fn_rbac_RA_System_SystemContainerName { get; set; }
        public DbSet<fn_rbac_HS_SOFTWARE_LICENSING_PRODUCT> fn_rbac_HS_SOFTWARE_LICENSING_PRODUCT { get; set; }
        public DbSet<fn_rbac_HS_ENCRYPTABLE_VOLUME> fn_rbac_HS_ENCRYPTABLE_VOLUME { get; set; }
        public DbSet<fn_rbac_RA_System_System_Group_Name> fn_rbac_RA_System_System_Group_Name { get; set; }
        public DbSet<fn_rbac_GS_SOFTWARE_LICENSING_SERVICE> fn_rbac_GS_SOFTWARE_LICENSING_SERVICE { get; set; }
        public DbSet<fn_rbac_GS_ENVIRONMENT> fn_rbac_GS_ENVIRONMENT { get; set; }
        public DbSet<fn_rbac_RA_System_SystemOUName> fn_rbac_RA_System_SystemOUName { get; set; }
        public DbSet<fn_rbac_HS_SOFTWARE_LICENSING_SERVICE> fn_rbac_HS_SOFTWARE_LICENSING_SERVICE { get; set; }
        public DbSet<fn_rbac_HS_ENVIRONMENT> fn_rbac_HS_ENVIRONMENT { get; set; }
        public DbSet<fn_rbac_RA_System_SystemRoles> fn_rbac_RA_System_SystemRoles { get; set; }
        public DbSet<fn_rbac_CICurrentComplianceStatus> fn_rbac_CICurrentComplianceStatus { get; set; }
        public DbSet<fn_rbac_GS_SYSTEM_ACCOUNT> fn_rbac_GS_SYSTEM_ACCOUNT { get; set; }
        public DbSet<fn_rbac_GS_FIRMWARE> fn_rbac_GS_FIRMWARE { get; set; }
        public DbSet<fn_rbac_CIErrorDetails> fn_rbac_CIErrorDetails { get; set; }
        public DbSet<fn_rbac_HS_SYSTEM_ACCOUNT> fn_rbac_HS_SYSTEM_ACCOUNT { get; set; }
        public DbSet<fn_rbac_HS_FIRMWARE> fn_rbac_HS_FIRMWARE { get; set; }
        public DbSet<fn_rbac_R_UnknownSystem> fn_rbac_R_UnknownSystem { get; set; }
        public DbSet<fn_rbac_CombinedDeviceResources> fn_rbac_CombinedDeviceResources { get; set; }
        public DbSet<fn_rbac_CIComplianceStatusReificationDetail> fn_rbac_CIComplianceStatusReificationDetail { get; set; }
        public DbSet<fn_rbac_GS_SYSTEM_CONSOLE_USAGE> fn_rbac_GS_SYSTEM_CONSOLE_USAGE { get; set; }
        public DbSet<fn_rbac_GS_FOLDER_REDIRECTION_HEALTH> fn_rbac_GS_FOLDER_REDIRECTION_HEALTH { get; set; }
        public DbSet<fn_rbac_RA_Unknown_System_SMS_Assig> fn_rbac_RA_Unknown_System_SMS_Assig { get; set; }
        public DbSet<fn_rbac_R_System_Valid> fn_rbac_R_System_Valid { get; set; }
        public DbSet<fn_rbac_HS_SYSTEM_CONSOLE_USAGE> fn_rbac_HS_SYSTEM_CONSOLE_USAGE { get; set; }
        public DbSet<fn_rbac_GS_IDE_CONTROLLER> fn_rbac_GS_IDE_CONTROLLER { get; set; }
        public DbSet<fn_rbac_UserMachineRelationship> fn_rbac_UserMachineRelationship { get; set; }
        public DbSet<fn_rbac_GS_SYSTEM_CONSOLE_USER> fn_rbac_GS_SYSTEM_CONSOLE_USER { get; set; }
        public DbSet<fn_rbac_HS_IDE_CONTROLLER> fn_rbac_HS_IDE_CONTROLLER { get; set; }
        public DbSet<fn_rbac_CICategories_All> fn_rbac_CICategories_All { get; set; }
        public DbSet<fn_rbac_INSTALLED_SOFTWARE_DATA_Summary> fn_rbac_INSTALLED_SOFTWARE_DATA_Summary { get; set; }
        public DbSet<fn_rbac_HS_SYSTEM_CONSOLE_USER> fn_rbac_HS_SYSTEM_CONSOLE_USER { get; set; }
        public DbSet<fn_rbac_GS_INSTALLED_EXECUTABLE> fn_rbac_GS_INSTALLED_EXECUTABLE { get; set; }
        public DbSet<fn_rbac_FullCollectionMembership_Valid> fn_rbac_FullCollectionMembership_Valid { get; set; }
        #endregion
#pragma warning restore IDE1006 // Naming Styles

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            #region generated Function modelBuilders
            modelBuilder.Entity<fn_rbac_GS_SYSTEM>(eb => {eb.HasNoKey();});
            modelBuilder.Entity<fn_rbac_UpdateContents>(eb => {eb.HasNoKey();});
            modelBuilder.Entity<fn_rbac_HS_INSTALLED_EXECUTABLE>(eb => {eb.HasNoKey();});
            modelBuilder.Entity<fn_rbac_CH_PolicyRequestHistory>(eb => {eb.HasNoKey();});
            modelBuilder.Entity<fn_rbac_HS_SYSTEM>(eb => {eb.HasNoKey();});
            modelBuilder.Entity<fn_rbac_GS_INSTALLED_SOFTWARE>(eb => {eb.HasNoKey();});
            modelBuilder.Entity<fn_rbac_R_User>(eb => {eb.HasNoKey();});
            modelBuilder.Entity<fn_rbac_UpdateComplianceStatus>(eb => {eb.HasNoKey();});
            modelBuilder.Entity<fn_rbac_CIComplianceStatusConflictsDetail>(eb => {eb.HasNoKey();});
            modelBuilder.Entity<fn_rbac_GS_SYSTEM_DEVICES>(eb => {eb.HasNoKey();});
            modelBuilder.Entity<fn_rbac_StatMsgWithInsStrings>(eb => {eb.HasNoKey();});
            modelBuilder.Entity<fn_rbac_HS_INSTALLED_SOFTWARE>(eb => {eb.HasNoKey();});
            modelBuilder.Entity<fn_rbac_RA_User_UserGroupName>(eb => {eb.HasNoKey();});
            modelBuilder.Entity<fn_rbac_AI_MVLS>(eb => {eb.HasNoKey();});
            modelBuilder.Entity<fn_rbac_Site>(eb => {eb.HasNoKey();});
            modelBuilder.Entity<fn_rbac_GS_SYSTEM_DRIVER>(eb => {eb.HasNoKey();});
            modelBuilder.Entity<fn_rbac_SMSConfigurationItems>(eb => {eb.HasNoKey();});
            modelBuilder.Entity<fn_rbac_GS_IRQ>(eb => {eb.HasNoKey();});
            modelBuilder.Entity<fn_rbac_RA_User_UserContainerName>(eb => {eb.HasNoKey();});
            modelBuilder.Entity<fn_rbac_AdvertisementStatusInformation>(eb => {eb.HasNoKey();});
            modelBuilder.Entity<fn_rbac_HS_SYSTEM_DRIVER>(eb => {eb.HasNoKey();});
            modelBuilder.Entity<fn_rbac_HS_IRQ>(eb => {eb.HasNoKey();});
            modelBuilder.Entity<fn_rbac_RA_User_User_Group_Name_F>(eb => {eb.HasNoKey();});
            modelBuilder.Entity<fn_rbac_GS_SoftwareProduct>(eb => {eb.HasNoKey();});
            modelBuilder.Entity<fn_rbac_GS_SYSTEM_ENCLOSURE>(eb => {eb.HasNoKey();});
            modelBuilder.Entity<fn_rbac_ServerComponents>(eb => {eb.HasNoKey();});
            modelBuilder.Entity<fn_rbac_GS_KEYBOARD_DEVICE>(eb => {eb.HasNoKey();});
            modelBuilder.Entity<fn_rbac_RA_User_UserOUName>(eb => {eb.HasNoKey();});
            modelBuilder.Entity<fn_rbac_EndpointProtectionStatus>(eb => {eb.HasNoKey();});
            modelBuilder.Entity<fn_rbac_LU_Category_Editable>(eb => {eb.HasNoKey();});
            modelBuilder.Entity<fn_rbac_HS_SYSTEM_ENCLOSURE>(eb => {eb.HasNoKey();});
            modelBuilder.Entity<fn_rbac_HS_KEYBOARD_DEVICE>(eb => {eb.HasNoKey();});
            modelBuilder.Entity<fn_rbac_Content>(eb => {eb.HasNoKey();});
            modelBuilder.Entity<fn_rbac_CIConfigPointTypes>(eb => {eb.HasNoKey();});
            modelBuilder.Entity<fn_rbac_GS_SYSTEMBOOTDATA>(eb => {eb.HasNoKey();});
            modelBuilder.Entity<fn_rbac_MeteredProductRule>(eb => {eb.HasNoKey();});
            modelBuilder.Entity<fn_rbac_GS_LOAD_ORDER_GROUP>(eb => {eb.HasNoKey();});
            modelBuilder.Entity<fn_rbac_CI_CurrentErrorDetails>(eb => {eb.HasNoKey();});
            modelBuilder.Entity<fn_rbac_HS_SYSTEMBOOTDATA>(eb => {eb.HasNoKey();});
            modelBuilder.Entity<fn_rbac_HS_LOAD_ORDER_GROUP>(eb => {eb.HasNoKey();});
            modelBuilder.Entity<fn_rbac_R_UserGroup>(eb => {eb.HasNoKey();});
            modelBuilder.Entity<fn_rbac_BundledConfigurationItems>(eb => {eb.HasNoKey();});
            modelBuilder.Entity<fn_rbac_GS_SYSTEMBOOTSUMMARY>(eb => {eb.HasNoKey();});
            modelBuilder.Entity<fn_rbac_GS_LOGICAL_DISK>(eb => {eb.HasNoKey();});
            modelBuilder.Entity<fn_rbac_RA_UserGroupADContainerName>(eb => {eb.HasNoKey();});
            modelBuilder.Entity<fn_rbac_GS_INSTALLED_SOFTWARE_CATEGORIZED>(eb => {eb.HasNoKey();});
            modelBuilder.Entity<fn_rbac_HS_SYSTEMBOOTSUMMARY>(eb => {eb.HasNoKey();});
            modelBuilder.Entity<fn_rbac_DriverContentToPackage>(eb => {eb.HasNoKey();});
            modelBuilder.Entity<fn_rbac_HS_LOGICAL_DISK>(eb => {eb.HasNoKey();});
            modelBuilder.Entity<fn_rbac_RA_User_Group_Group_OU_Name>(eb => {eb.HasNoKey();});
            modelBuilder.Entity<fn_rbac_GS_TAPE_DRIVE>(eb => {eb.HasNoKey();});
            modelBuilder.Entity<fn_rbac_GS_MDM_DEVDETAIL_EXT01>(eb => {eb.HasNoKey();});
            modelBuilder.Entity<fn_rbac_CICurrentRuleDetail>(eb => {eb.HasNoKey();});
            modelBuilder.Entity<fn_rbac_HS_TAPE_DRIVE>(eb => {eb.HasNoKey();});
            modelBuilder.Entity<fn_rbac_CustomInventoryReport>(eb => {eb.HasNoKey();});
            modelBuilder.Entity<fn_rbac_HS_MDM_DEVDETAIL_EXT01>(eb => {eb.HasNoKey();});
            modelBuilder.Entity<fn_rbac_GS_TIME_ZONE>(eb => {eb.HasNoKey();});
            modelBuilder.Entity<fn_rbac_GS_MDM_RemoteFind>(eb => {eb.HasNoKey();});
            modelBuilder.Entity<fn_rbac_HS_TIME_ZONE>(eb => {eb.HasNoKey();});
            modelBuilder.Entity<fn_rbac_CITargetedMachines>(eb => {eb.HasNoKey();});
            modelBuilder.Entity<fn_rbac_HS_MDM_RemoteFind>(eb => {eb.HasNoKey();});
            modelBuilder.Entity<fn_rbac_GS_TPM>(eb => {eb.HasNoKey();});
            modelBuilder.Entity<fn_rbac_CIRelation>(eb => {eb.HasNoKey();});
            modelBuilder.Entity<fn_rbac_GS_MDM_SecurityStatus>(eb => {eb.HasNoKey();});
            modelBuilder.Entity<fn_rbac_HS_TPM>(eb => {eb.HasNoKey();});
            modelBuilder.Entity<fn_rbac_CH_EvalResults>(eb => {eb.HasNoKey();});
            modelBuilder.Entity<fn_rbac_HS_MDM_SecurityStatus>(eb => {eb.HasNoKey();});
            modelBuilder.Entity<fn_rbac_LU_SoftwareList_Local>(eb => {eb.HasNoKey();});
            modelBuilder.Entity<fn_rbac_GS_TPM_STATUS>(eb => {eb.HasNoKey();});
            modelBuilder.Entity<fn_rbac_GS_MODEM_DEVICE>(eb => {eb.HasNoKey();});
            modelBuilder.Entity<fn_rbac_GS_SYSTEM_CONSOLE_USAGE_MAXGROUP>(eb => {eb.HasNoKey();});
            modelBuilder.Entity<fn_rbac_HS_TPM_STATUS>(eb => {eb.HasNoKey();});
            modelBuilder.Entity<fn_rbac_CategoryPermissions>(eb => {eb.HasNoKey();});
            modelBuilder.Entity<fn_rbac_HS_MODEM_DEVICE>(eb => {eb.HasNoKey();});
            modelBuilder.Entity<fn_rbac_CIComplianceStatusComplianceDetail>(eb => {eb.HasNoKey();});
            modelBuilder.Entity<fn_rbac_GS_TS_ISSUED_LICENSE>(eb => {eb.HasNoKey();});
            modelBuilder.Entity<fn_rbac_GS_MOTHERBOARD_DEVICE>(eb => {eb.HasNoKey();});
            modelBuilder.Entity<fn_rbac_HS_TS_ISSUED_LICENSE>(eb => {eb.HasNoKey();});
            modelBuilder.Entity<fn_rbac_HS_MOTHERBOARD_DEVICE>(eb => {eb.HasNoKey();});
            modelBuilder.Entity<fn_rbac_GS_TS_LICENSE_KEY_PACK>(eb => {eb.HasNoKey();});
            modelBuilder.Entity<fn_rbac_AppDTDeploymentSummary>(eb => {eb.HasNoKey();});
            modelBuilder.Entity<fn_rbac_GS_POINTING_DEVICE>(eb => {eb.HasNoKey();});
            modelBuilder.Entity<fn_rbac_HS_TS_LICENSE_KEY_PACK>(eb => {eb.HasNoKey();});
            modelBuilder.Entity<fn_rbac_HS_POINTING_DEVICE>(eb => {eb.HasNoKey();});
            modelBuilder.Entity<fn_rbac_LU_SoftwareList_Editable>(eb => {eb.HasNoKey();});
            modelBuilder.Entity<fn_rbac_GS_USB_CONTROLLER>(eb => {eb.HasNoKey();});
            modelBuilder.Entity<fn_rbac_GS_NETWORK_ADAPTER>(eb => {eb.HasNoKey();});
            modelBuilder.Entity<fn_rbac_HS_USB_CONTROLLER>(eb => {eb.HasNoKey();});
            modelBuilder.Entity<fn_rbac_HS_NETWORK_ADAPTER>(eb => {eb.HasNoKey();});
            modelBuilder.Entity<fn_rbac_CIComplianceStatusDetail>(eb => {eb.HasNoKey();});
            modelBuilder.Entity<fn_rbac_GS_USB_DEVICE>(eb => {eb.HasNoKey();});
            modelBuilder.Entity<fn_rbac_AlertVariable_G>(eb => {eb.HasNoKey();});
            modelBuilder.Entity<fn_rbac_GS_NETWORK_CLIENT>(eb => {eb.HasNoKey();});
            modelBuilder.Entity<fn_rbac_HS_USB_DEVICE>(eb => {eb.HasNoKey();});
            modelBuilder.Entity<fn_rbac_GS_BITLOCKER_DETAILS>(eb => {eb.HasNoKey();});
            modelBuilder.Entity<fn_rbac_HS_NETWORK_CLIENT>(eb => {eb.HasNoKey();});
            modelBuilder.Entity<fn_rbac_GS_INSTALLED_SOFTWARE_MS>(eb => {eb.HasNoKey();});
            modelBuilder.Entity<fn_rbac_CMG_Statistics>(eb => {eb.HasNoKey();});
            modelBuilder.Entity<fn_rbac_GS_USER_PROFILE>(eb => {eb.HasNoKey();});
            modelBuilder.Entity<fn_rbac_HS_BITLOCKER_DETAILS>(eb => {eb.HasNoKey();});
            modelBuilder.Entity<fn_rbac_GS_NETWORK_ADAPTER_CONFIGURATION>(eb => {eb.HasNoKey();});
            modelBuilder.Entity<fn_rbac_GS_VIDEO_CONTROLLER>(eb => {eb.HasNoKey();});
            modelBuilder.Entity<fn_rbac_HS_NETWORK_ADAPTER_CONFIGURATION>(eb => {eb.HasNoKey();});
            modelBuilder.Entity<fn_rbac_HS_VIDEO_CONTROLLER>(eb => {eb.HasNoKey();});
            modelBuilder.Entity<fn_rbac_GS_NETWORK_LOGIN_PROFILE>(eb => {eb.HasNoKey();});
            modelBuilder.Entity<fn_rbac_WOLClientTimeZones>(eb => {eb.HasNoKey();});
            modelBuilder.Entity<fn_rbac_GS_VIRTUAL_APPLICATION_PACKAGES>(eb => {eb.HasNoKey();});
            modelBuilder.Entity<fn_rbac_HS_NETWORK_LOGIN_PROFILE>(eb => {eb.HasNoKey();});
            modelBuilder.Entity<fn_rbac_UpdateSummaryPerCollection>(eb => {eb.HasNoKey();});
            modelBuilder.Entity<fn_rbac_WOLTargetedClients>(eb => {eb.HasNoKey();});
            modelBuilder.Entity<fn_rbac_HS_VIRTUAL_APPLICATION_PACKAGES>(eb => {eb.HasNoKey();});
            modelBuilder.Entity<fn_rbac_GS_NT_EVENTLOG_FILE>(eb => {eb.HasNoKey();});
            modelBuilder.Entity<fn_rbac_WOLGetSupportedObjects>(eb => {eb.HasNoKey();});
            modelBuilder.Entity<fn_rbac_GS_VIRTUAL_APPLICATIONS>(eb => {eb.HasNoKey();});
            modelBuilder.Entity<fn_rbac_HS_NT_EVENTLOG_FILE>(eb => {eb.HasNoKey();});
            modelBuilder.Entity<fn_rbac_ThreatSeverities>(eb => {eb.HasNoKey();});
            modelBuilder.Entity<fn_rbac_Users>(eb => {eb.HasNoKey();});
            modelBuilder.Entity<fn_rbac_HS_VIRTUAL_APPLICATIONS>(eb => {eb.HasNoKey();});
            modelBuilder.Entity<fn_rbac_GS_OFFICE_ADDIN>(eb => {eb.HasNoKey();});
            modelBuilder.Entity<fn_rbac_GS_1394_CONTROLLER>(eb => {eb.HasNoKey();});
            modelBuilder.Entity<fn_rbac_StatMsgAttributes>(eb => {eb.HasNoKey();});
            modelBuilder.Entity<fn_rbac_UserMachineTypeRelation>(eb => {eb.HasNoKey();});
            modelBuilder.Entity<fn_rbac_GS_VIRTUAL_MACHINE_64>(eb => {eb.HasNoKey();});
            modelBuilder.Entity<fn_rbac_HS_OFFICE_ADDIN>(eb => {eb.HasNoKey();});
            modelBuilder.Entity<fn_rbac_HS_1394_CONTROLLER>(eb => {eb.HasNoKey();});
            modelBuilder.Entity<fn_rbac_MDMUserPolicyAssignment>(eb => {eb.HasNoKey();});
            modelBuilder.Entity<fn_rbac_ThreatDefaultActions>(eb => {eb.HasNoKey();});
            modelBuilder.Entity<fn_rbac_HS_VIRTUAL_MACHINE_64>(eb => {eb.HasNoKey();});
            modelBuilder.Entity<fn_rbac_GS_COMPUTER_SYSTEM_EXT>(eb => {eb.HasNoKey();});
            modelBuilder.Entity<fn_rbac_GS_OFFICE_DOCUMENTMETRIC>(eb => {eb.HasNoKey();});
            modelBuilder.Entity<fn_rbac_GS_ACTIVESYNC_SERVICE>(eb => {eb.HasNoKey();});
            modelBuilder.Entity<fn_rbac_BGB_Statistics>(eb => {eb.HasNoKey();});
            modelBuilder.Entity<fn_rbac_mdmclientidentity>(eb => {eb.HasNoKey();});
            modelBuilder.Entity<fn_rbac_StateNames>(eb => {eb.HasNoKey();});
            modelBuilder.Entity<fn_rbac_GS_VIRTUAL_MACHINE>(eb => {eb.HasNoKey();});
            modelBuilder.Entity<fn_rbac_HS_COMPUTER_SYSTEM_EXT>(eb => {eb.HasNoKey();});
            modelBuilder.Entity<fn_rbac_HS_OFFICE_DOCUMENTMETRIC>(eb => {eb.HasNoKey();});
            modelBuilder.Entity<fn_rbac_HS_ACTIVESYNC_SERVICE>(eb => {eb.HasNoKey();});
            modelBuilder.Entity<fn_rbac_HS_VIRTUAL_MACHINE>(eb => {eb.HasNoKey();});
            modelBuilder.Entity<fn_rbac_GS_OFFICE_PRODUCTINFO>(eb => {eb.HasNoKey();});
            modelBuilder.Entity<fn_rbac_GS_ADD_REMOVE_PROGRAMS_64>(eb => {eb.HasNoKey();});
            modelBuilder.Entity<fn_rbac_LU_CAL_ProductList>(eb => {eb.HasNoKey();});
            modelBuilder.Entity<fn_rbac_PackageStatusRootSummarizer>(eb => {eb.HasNoKey();});
            modelBuilder.Entity<fn_rbac_GS_VIRTUAL_MACHINE_EXT>(eb => {eb.HasNoKey();});
            modelBuilder.Entity<fn_rbac_HS_OFFICE_PRODUCTINFO>(eb => {eb.HasNoKey();});
            modelBuilder.Entity<fn_rbac_HS_ADD_REMOVE_PROGRAMS_64>(eb => {eb.HasNoKey();});
            modelBuilder.Entity<fn_rbac_PackageStatus>(eb => {eb.HasNoKey();});
            modelBuilder.Entity<fn_rbac_UpdateCIs>(eb => {eb.HasNoKey();});
            modelBuilder.Entity<fn_rbac_HS_VIRTUAL_MACHINE_EXT>(eb => {eb.HasNoKey();});
            modelBuilder.Entity<fn_rbac_GS_OFFICE_VBARULEVIOLATION>(eb => {eb.HasNoKey();});
            modelBuilder.Entity<fn_rbac_GS_ADD_REMOVE_PROGRAMS>(eb => {eb.HasNoKey();});
            modelBuilder.Entity<fn_rbac_GS_SoftwareFile>(eb => {eb.HasNoKey();});
            modelBuilder.Entity<fn_rbac_ClientCollectionMembers>(eb => {eb.HasNoKey();});
            modelBuilder.Entity<fn_rbac_GS_VOLUME>(eb => {eb.HasNoKey();});
            modelBuilder.Entity<fn_rbac_HS_OFFICE_VBARULEVIOLATION>(eb => {eb.HasNoKey();});
            modelBuilder.Entity<fn_rbac_HS_ADD_REMOVE_PROGRAMS>(eb => {eb.HasNoKey();});
            modelBuilder.Entity<fn_rbac_MonthlyUsageSummary>(eb => {eb.HasNoKey();});
            modelBuilder.Entity<fn_rbac_HS_VOLUME>(eb => {eb.HasNoKey();});
            modelBuilder.Entity<fn_rbac_GS_OFFICE_VBASUMMARY>(eb => {eb.HasNoKey();});
            modelBuilder.Entity<fn_rbac_GS_ADVANCED_CLIENT_PORTS>(eb => {eb.HasNoKey();});
            modelBuilder.Entity<fn_rbac_EndpointProtectionHealthStatus>(eb => {eb.HasNoKey();});
            modelBuilder.Entity<fn_rbac_GS_WEBAPP_APPLICATION>(eb => {eb.HasNoKey();});
            modelBuilder.Entity<fn_rbac_HS_OFFICE_VBASUMMARY>(eb => {eb.HasNoKey();});
            modelBuilder.Entity<fn_rbac_HS_ADVANCED_CLIENT_PORTS>(eb => {eb.HasNoKey();});
            modelBuilder.Entity<fn_rbac_MIG_EntityReference>(eb => {eb.HasNoKey();});
            modelBuilder.Entity<fn_rbac_HS_WEBAPP_APPLICATION>(eb => {eb.HasNoKey();});
            modelBuilder.Entity<fn_rbac_GS_OFFICE365PROPLUSCONFIGURATIONS>(eb => {eb.HasNoKey();});
            modelBuilder.Entity<fn_rbac_GS_AMT_AGENT>(eb => {eb.HasNoKey();});
            modelBuilder.Entity<fn_rbac_EndpointProtectionCollections>(eb => {eb.HasNoKey();});
            modelBuilder.Entity<fn_rbac_MDMDeviceCategory>(eb => {eb.HasNoKey();});
            modelBuilder.Entity<fn_rbac_ConfigurationItems>(eb => {eb.HasNoKey();});
            modelBuilder.Entity<fn_rbac_GS_WINDOWSUPDATEAGENTVERSION>(eb => {eb.HasNoKey();});
            modelBuilder.Entity<fn_rbac_GS_MBAM_POLICY>(eb => {eb.HasNoKey();});
            modelBuilder.Entity<fn_rbac_HS_OFFICE365PROPLUSCONFIGURATIONS>(eb => {eb.HasNoKey();});
            modelBuilder.Entity<fn_rbac_HS_AMT_AGENT>(eb => {eb.HasNoKey();});
            modelBuilder.Entity<fn_rbac_SMSCICurrentComplianceStatus>(eb => {eb.HasNoKey();});
            modelBuilder.Entity<fn_rbac_HS_WINDOWSUPDATEAGENTVERSION>(eb => {eb.HasNoKey();});
            modelBuilder.Entity<fn_rbac_HS_MBAM_POLICY>(eb => {eb.HasNoKey();});
            modelBuilder.Entity<fn_rbac_GS_OPERATING_SYSTEM>(eb => {eb.HasNoKey();});
            modelBuilder.Entity<fn_rbac_GS_APPV_CLIENT_APPLICATION>(eb => {eb.HasNoKey();});
            modelBuilder.Entity<fn_rbac_ClientDeploymentState>(eb => {eb.HasNoKey();});
            modelBuilder.Entity<fn_rbac_DriverPackage>(eb => {eb.HasNoKey();});
            modelBuilder.Entity<fn_rbac_GS_WINDOWS8_APPLICATION>(eb => {eb.HasNoKey();});
            modelBuilder.Entity<fn_rbac_HS_OPERATING_SYSTEM>(eb => {eb.HasNoKey();});
            modelBuilder.Entity<fn_rbac_WOLEnabledAssignments>(eb => {eb.HasNoKey();});
            modelBuilder.Entity<fn_rbac_HS_APPV_CLIENT_APPLICATION>(eb => {eb.HasNoKey();});
            modelBuilder.Entity<fn_rbac_CIDriverCategories>(eb => {eb.HasNoKey();});
            modelBuilder.Entity<fn_rbac_cicontentpackage>(eb => {eb.HasNoKey();});
            modelBuilder.Entity<fn_rbac_HS_WINDOWS8_APPLICATION>(eb => {eb.HasNoKey();});
            modelBuilder.Entity<fn_rbac_GS_OPTIONAL_FEATURE>(eb => {eb.HasNoKey();});
            modelBuilder.Entity<fn_rbac_GS_APPV_CLIENT_PACKAGE>(eb => {eb.HasNoKey();});
            modelBuilder.Entity<fn_rbac_Network_DATA_Serialized>(eb => {eb.HasNoKey();});
            modelBuilder.Entity<fn_rbac_GS_WINDOWS8_APPLICATION_USER_INFO>(eb => {eb.HasNoKey();});
            modelBuilder.Entity<fn_rbac_HS_OPTIONAL_FEATURE>(eb => {eb.HasNoKey();});
            modelBuilder.Entity<fn_rbac_ThreatCatalog>(eb => {eb.HasNoKey();});
            modelBuilder.Entity<fn_rbac_HS_APPV_CLIENT_PACKAGE>(eb => {eb.HasNoKey();});
            modelBuilder.Entity<fn_rbac_CIAssignmentTargetedMachines>(eb => {eb.HasNoKey();});
            modelBuilder.Entity<fn_rbac_MIG_Job>(eb => {eb.HasNoKey();});
            modelBuilder.Entity<fn_rbac_HS_WINDOWS8_APPLICATION_USER_INFO>(eb => {eb.HasNoKey();});
            modelBuilder.Entity<fn_rbac_GS_OS_RECOVERY_CONFIGURATION>(eb => {eb.HasNoKey();});
            modelBuilder.Entity<fn_rbac_SMS_Alert>(eb => {eb.HasNoKey();});
            modelBuilder.Entity<fn_rbac_GS_AUTOSTART_SOFTWARE>(eb => {eb.HasNoKey();});
            modelBuilder.Entity<fn_rbac_GS_WINDOWSUPDATE>(eb => {eb.HasNoKey();});
            modelBuilder.Entity<fn_rbac_HS_OS_RECOVERY_CONFIGURATION>(eb => {eb.HasNoKey();});
            modelBuilder.Entity<fn_rbac_HS_AUTOSTART_SOFTWARE>(eb => {eb.HasNoKey();});
            modelBuilder.Entity<fn_rbac_LU_HardwareReadiness>(eb => {eb.HasNoKey();});
            modelBuilder.Entity<fn_rbac_HS_WINDOWSUPDATE>(eb => {eb.HasNoKey();});
            modelBuilder.Entity<fn_rbac_GS_PAGE_FILE_SETTING>(eb => {eb.HasNoKey();});
            modelBuilder.Entity<fn_rbac_StatusMessagesAlerts>(eb => {eb.HasNoKey();});
            modelBuilder.Entity<fn_rbac_GS_BASEBOARD>(eb => {eb.HasNoKey();});
            modelBuilder.Entity<fn_rbac_CIAssignmentToGroup>(eb => {eb.HasNoKey();});
            modelBuilder.Entity<fn_rbac_GS_WORKSTATION_STATUS>(eb => {eb.HasNoKey();});
            modelBuilder.Entity<fn_rbac_HS_PAGE_FILE_SETTING>(eb => {eb.HasNoKey();});
            modelBuilder.Entity<fn_rbac_Permissions>(eb => {eb.HasNoKey();});
            modelBuilder.Entity<fn_rbac_HS_BASEBOARD>(eb => {eb.HasNoKey();});
            modelBuilder.Entity<fn_rbac_GS_WRITE_FILTER_STATE>(eb => {eb.HasNoKey();});
            modelBuilder.Entity<fn_rbac_GS_OPERATING_SYSTEM_EXT>(eb => {eb.HasNoKey();});
            modelBuilder.Entity<fn_rbac_GS_PARALLEL_PORT>(eb => {eb.HasNoKey();});
            modelBuilder.Entity<fn_rbac_Package>(eb => {eb.HasNoKey();});
            modelBuilder.Entity<fn_rbac_GS_BATTERY>(eb => {eb.HasNoKey();});
            modelBuilder.Entity<fn_rbac_GS_AntimalwareHealthStatus>(eb => {eb.HasNoKey();});
            modelBuilder.Entity<fn_rbac_HS_WRITE_FILTER_STATE>(eb => {eb.HasNoKey();});
            modelBuilder.Entity<fn_rbac_HS_OPERATING_SYSTEM_EXT>(eb => {eb.HasNoKey();});
            modelBuilder.Entity<fn_rbac_CP_Machine>(eb => {eb.HasNoKey();});
            modelBuilder.Entity<fn_rbac_HS_PARALLEL_PORT>(eb => {eb.HasNoKey();});
            modelBuilder.Entity<fn_rbac_GS_PHYSICALDISK>(eb => {eb.HasNoKey();});
            modelBuilder.Entity<fn_rbac_HS_BATTERY>(eb => {eb.HasNoKey();});
            modelBuilder.Entity<fn_rbac_WOLEnabledTaskSequences>(eb => {eb.HasNoKey();});
            modelBuilder.Entity<fn_rbac_AAD_Statistics>(eb => {eb.HasNoKey();});
            modelBuilder.Entity<fn_rbac_GS_PARTITION>(eb => {eb.HasNoKey();});
            modelBuilder.Entity<fn_rbac_WOLSWDistTargetedClients>(eb => {eb.HasNoKey();});
            modelBuilder.Entity<fn_rbac_MIG_JobEntity>(eb => {eb.HasNoKey();});
            modelBuilder.Entity<fn_rbac_HS_PHYSICALDISK>(eb => {eb.HasNoKey();});
            modelBuilder.Entity<fn_rbac_GS_BOOT_CONFIGURATION>(eb => {eb.HasNoKey();});
            modelBuilder.Entity<fn_rbac_HS_PARTITION>(eb => {eb.HasNoKey();});
            modelBuilder.Entity<fn_rbac_WOLSUMTargetedClients>(eb => {eb.HasNoKey();});
            modelBuilder.Entity<fn_rbac_HS_BOOT_CONFIGURATION>(eb => {eb.HasNoKey();});
            modelBuilder.Entity<fn_rbac_Update_ComplianceStatusAll>(eb => {eb.HasNoKey();});
            modelBuilder.Entity<fn_rbac_EndpointProtectionHealthStatus_History>(eb => {eb.HasNoKey();});
            modelBuilder.Entity<fn_rbac_GS_PC_BIOS>(eb => {eb.HasNoKey();});
            modelBuilder.Entity<fn_rbac_WakeupProxyDeploymentState>(eb => {eb.HasNoKey();});
            modelBuilder.Entity<fn_rbac_MeteredUser>(eb => {eb.HasNoKey();});
            modelBuilder.Entity<fn_rbac_GS_BROWSER_HELPER_OBJECT>(eb => {eb.HasNoKey();});
            modelBuilder.Entity<fn_rbac_WOLEnabledObjects>(eb => {eb.HasNoKey();});
            modelBuilder.Entity<fn_rbac_HS_PC_BIOS>(eb => {eb.HasNoKey();});
            modelBuilder.Entity<fn_rbac_UserHealthProfileState>(eb => {eb.HasNoKey();});
            modelBuilder.Entity<fn_rbac_mdmdeviceproperty>(eb => {eb.HasNoKey();});
            modelBuilder.Entity<fn_rbac_HS_BROWSER_HELPER_OBJECT>(eb => {eb.HasNoKey();});
            modelBuilder.Entity<fn_rbac_UpdateState_Combined>(eb => {eb.HasNoKey();});
            modelBuilder.Entity<fn_rbac_vSMS_DistributionDPStatus>(eb => {eb.HasNoKey();});
            modelBuilder.Entity<fn_rbac_EAS_Property_S>(eb => {eb.HasNoKey();});
            modelBuilder.Entity<fn_rbac_GS_X86_PC_MEMORY>(eb => {eb.HasNoKey();});
            modelBuilder.Entity<fn_rbac_SystemInventoryChanges>(eb => {eb.HasNoKey();});
            modelBuilder.Entity<fn_rbac_GS_CDROM>(eb => {eb.HasNoKey();});
            modelBuilder.Entity<fn_rbac_UpdateScanStatus>(eb => {eb.HasNoKey();});
            modelBuilder.Entity<fn_rbac_ThreatSummary>(eb => {eb.HasNoKey();});
            modelBuilder.Entity<fn_rbac_HS_X86_PC_MEMORY>(eb => {eb.HasNoKey();});
            modelBuilder.Entity<fn_rbac_StatusMessage>(eb => {eb.HasNoKey();});
            modelBuilder.Entity<fn_rbac_HS_CDROM>(eb => {eb.HasNoKey();});
            modelBuilder.Entity<fn_rbac_ThreatCategories>(eb => {eb.HasNoKey();});
            modelBuilder.Entity<fn_rbac_DpGroupPackages>(eb => {eb.HasNoKey();});
            modelBuilder.Entity<fn_rbac_GS_PCMCIA_CONTROLLER>(eb => {eb.HasNoKey();});
            modelBuilder.Entity<fn_rbac_GS_EPDeploymentState>(eb => {eb.HasNoKey();});
            modelBuilder.Entity<fn_rbac_GS_ClientEvents>(eb => {eb.HasNoKey();});
            modelBuilder.Entity<fn_rbac_HS_PCMCIA_CONTROLLER>(eb => {eb.HasNoKey();});
            modelBuilder.Entity<fn_rbac_DistributionPoint>(eb => {eb.HasNoKey();});
            modelBuilder.Entity<fn_rbac_HS_ClientEvents>(eb => {eb.HasNoKey();});
            modelBuilder.Entity<fn_rbac_MeteredFiles>(eb => {eb.HasNoKey();});
            modelBuilder.Entity<fn_rbac_SmsPackage>(eb => {eb.HasNoKey();});
            modelBuilder.Entity<fn_rbac_GS_PHYSICAL_DISK>(eb => {eb.HasNoKey();});
            modelBuilder.Entity<fn_rbac_CIAssignmentToCI>(eb => {eb.HasNoKey();});
            modelBuilder.Entity<fn_rbac_ClientAdvertisementStatus>(eb => {eb.HasNoKey();});
            modelBuilder.Entity<fn_rbac_GS_COMPUTER_SYSTEM>(eb => {eb.HasNoKey();});
            modelBuilder.Entity<fn_rbac_DistributionPointInfo>(eb => {eb.HasNoKey();});
            modelBuilder.Entity<fn_rbac_HS_PHYSICAL_DISK>(eb => {eb.HasNoKey();});
            modelBuilder.Entity<fn_rbac_AssignmentState_Combined>(eb => {eb.HasNoKey();});
            modelBuilder.Entity<fn_rbac_CI_DriversCIs>(eb => {eb.HasNoKey();});
            modelBuilder.Entity<fn_rbac_HS_COMPUTER_SYSTEM>(eb => {eb.HasNoKey();});
            modelBuilder.Entity<fn_rbac_LastUsageSummary>(eb => {eb.HasNoKey();});
            modelBuilder.Entity<fn_rbac_Report_StatusMessageDetail>(eb => {eb.HasNoKey();});
            modelBuilder.Entity<fn_rbac_GS_PHYSICAL_MEMORY>(eb => {eb.HasNoKey();});
            modelBuilder.Entity<fn_rbac_ApplicationModelInfo>(eb => {eb.HasNoKey();});
            modelBuilder.Entity<fn_rbac_GS_COMPUTER_SYSTEM_PRODUCT>(eb => {eb.HasNoKey();});
            modelBuilder.Entity<fn_rbac_MeterRuleInstallBase>(eb => {eb.HasNoKey();});
            modelBuilder.Entity<fn_rbac_DeviceClientDeploymentState>(eb => {eb.HasNoKey();});
            modelBuilder.Entity<fn_rbac_HS_PHYSICAL_MEMORY>(eb => {eb.HasNoKey();});
            modelBuilder.Entity<fn_rbac_AppInTSDeployment>(eb => {eb.HasNoKey();});
            modelBuilder.Entity<fn_rbac_HS_COMPUTER_SYSTEM_PRODUCT>(eb => {eb.HasNoKey();});
            modelBuilder.Entity<fn_rbac_ClientMode>(eb => {eb.HasNoKey();});
            modelBuilder.Entity<fn_rbac_MDMAppleLicenses>(eb => {eb.HasNoKey();});
            modelBuilder.Entity<fn_rbac_GS_PNP_DEVICE_DRIVER>(eb => {eb.HasNoKey();});
            modelBuilder.Entity<fn_rbac_GS_ACTIVESYNC_CONNECTED_DEVICE>(eb => {eb.HasNoKey();});
            modelBuilder.Entity<fn_rbac_CIRelation_All>(eb => {eb.HasNoKey();});
            modelBuilder.Entity<fn_rbac_GS_PORT>(eb => {eb.HasNoKey();});
            modelBuilder.Entity<fn_rbac_AppDeploymentSummary>(eb => {eb.HasNoKey();});
            modelBuilder.Entity<fn_rbac_HS_ACTIVESYNC_CONNECTED_DEVICE>(eb => {eb.HasNoKey();});
            modelBuilder.Entity<fn_rbac_CI_DriverHardwareIDs>(eb => {eb.HasNoKey();});
            modelBuilder.Entity<fn_rbac_HS_PORT>(eb => {eb.HasNoKey();});
            modelBuilder.Entity<fn_rbac_GS_DEFAULT_BROWSER>(eb => {eb.HasNoKey();});
            modelBuilder.Entity<fn_rbac_CategoryMembershipsWithCollection>(eb => {eb.HasNoKey();});
            modelBuilder.Entity<fn_rbac_inventoryreportclass>(eb => {eb.HasNoKey();});
            modelBuilder.Entity<fn_rbac_GS_PORTABLE_BATTERY>(eb => {eb.HasNoKey();});
            modelBuilder.Entity<fn_rbac_HS_DEFAULT_BROWSER>(eb => {eb.HasNoKey();});
            modelBuilder.Entity<fn_rbac_TaskExecutionStatus>(eb => {eb.HasNoKey();});
            modelBuilder.Entity<fn_rbac_HS_PORTABLE_BATTERY>(eb => {eb.HasNoKey();});
            modelBuilder.Entity<fn_rbac_AlertValidFeatureArea>(eb => {eb.HasNoKey();});
            modelBuilder.Entity<fn_rbac_GS_DESKTOP>(eb => {eb.HasNoKey();});
            modelBuilder.Entity<fn_rbac_BootImagePackage_References>(eb => {eb.HasNoKey();});
            modelBuilder.Entity<fn_rbac_FolderRedirectionState>(eb => {eb.HasNoKey();});
            modelBuilder.Entity<fn_rbac_CIToContent>(eb => {eb.HasNoKey();});
            modelBuilder.Entity<fn_rbac_GS_POWER_MANAGEMENT_CAPABILITIES>(eb => {eb.HasNoKey();});
            modelBuilder.Entity<fn_rbac_HS_DESKTOP>(eb => {eb.HasNoKey();});
            modelBuilder.Entity<fn_rbac_CICategories>(eb => {eb.HasNoKey();});
            modelBuilder.Entity<fn_rbac_SummarizationInterval>(eb => {eb.HasNoKey();});
            modelBuilder.Entity<fn_rbac_GS_POWER_MANAGEMENT_CLIENTOPTOUT_SETTINGS>(eb => {eb.HasNoKey();});
            modelBuilder.Entity<fn_rbac_AI_NON_MS_LICENSE>(eb => {eb.HasNoKey();});
            modelBuilder.Entity<fn_rbac_GS_DESKTOP_MONITOR>(eb => {eb.HasNoKey();});
            modelBuilder.Entity<fn_rbac_BootImagePackage>(eb => {eb.HasNoKey();});
            modelBuilder.Entity<fn_rbac_CIAssignment>(eb => {eb.HasNoKey();});
            modelBuilder.Entity<fn_rbac_FileUsageSummaryIntervals>(eb => {eb.HasNoKey();});
            modelBuilder.Entity<fn_rbac_SMS_CIRelation>(eb => {eb.HasNoKey();});
            modelBuilder.Entity<fn_rbac_GS_POWER_MANAGEMENT_CONFIGURATION>(eb => {eb.HasNoKey();});
            modelBuilder.Entity<fn_rbac_HS_DESKTOP_MONITOR>(eb => {eb.HasNoKey();});
            modelBuilder.Entity<fn_rbac_CurrentAdvertisementAssignments>(eb => {eb.HasNoKey();});
            modelBuilder.Entity<fn_rbac_GS_POWER_MANAGEMENT_DAY>(eb => {eb.HasNoKey();});
            modelBuilder.Entity<fn_rbac_GS_OFFICE_CLIENTMETRIC>(eb => {eb.HasNoKey();});
            modelBuilder.Entity<fn_rbac_GS_DEVICE_BLUETOOTH>(eb => {eb.HasNoKey();});
            modelBuilder.Entity<fn_rbac_Admins>(eb => {eb.HasNoKey();});
            modelBuilder.Entity<fn_rbac_ClientHealthState>(eb => {eb.HasNoKey();});
            modelBuilder.Entity<fn_rbac_Update_ComplianceSummary_Live>(eb => {eb.HasNoKey();});
            modelBuilder.Entity<fn_rbac_ServiceWindow>(eb => {eb.HasNoKey();});
            modelBuilder.Entity<fn_rbac_GS_POWER_MANAGEMENT_MONTH>(eb => {eb.HasNoKey();});
            modelBuilder.Entity<fn_rbac_HS_OFFICE_CLIENTMETRIC>(eb => {eb.HasNoKey();});
            modelBuilder.Entity<fn_rbac_HS_DEVICE_BLUETOOTH>(eb => {eb.HasNoKey();});
            modelBuilder.Entity<fn_rbac_UpdateAssignmentStatus_Live>(eb => {eb.HasNoKey();});
            modelBuilder.Entity<fn_rbac_CIAssignmentTargetedCollections>(eb => {eb.HasNoKey();});
            modelBuilder.Entity<fn_rbac_GS_POWER_MANAGEMENT_SETTINGS>(eb => {eb.HasNoKey();});
            modelBuilder.Entity<fn_rbac_GS_OFFICE_DEVICESUMMARY>(eb => {eb.HasNoKey();});
            modelBuilder.Entity<fn_rbac_GS_DEVICE_CAMERA>(eb => {eb.HasNoKey();});
            modelBuilder.Entity<fn_rbac_SystemResourceList>(eb => {eb.HasNoKey();});
            modelBuilder.Entity<fn_rbac_AllItems>(eb => {eb.HasNoKey();});
            modelBuilder.Entity<fn_rbac_GS_POWER_MANAGEMENT_SUSPEND_ERROR>(eb => {eb.HasNoKey();});
            modelBuilder.Entity<fn_rbac_HS_OFFICE_DEVICESUMMARY>(eb => {eb.HasNoKey();});
            modelBuilder.Entity<fn_rbac_HS_DEVICE_CAMERA>(eb => {eb.HasNoKey();});
            modelBuilder.Entity<fn_rbac_CAL_Processor_Count>(eb => {eb.HasNoKey();});
            modelBuilder.Entity<fn_rbac_SummarizerSiteStatus>(eb => {eb.HasNoKey();});
            modelBuilder.Entity<fn_rbac_WOLCommunicationHistory>(eb => {eb.HasNoKey();});
            modelBuilder.Entity<fn_rbac_GS_POWER_SUPPLY>(eb => {eb.HasNoKey();});
            modelBuilder.Entity<fn_rbac_GS_OFFICE_DOCUMENTSOLUTION>(eb => {eb.HasNoKey();});
            modelBuilder.Entity<fn_rbac_GS_DEVICE_CERTIFICATES>(eb => {eb.HasNoKey();});
            modelBuilder.Entity<fn_rbac_StatMsgModuleNames>(eb => {eb.HasNoKey();});
            modelBuilder.Entity<fn_rbac_TaskSequenceReferencesInfo>(eb => {eb.HasNoKey();});
            modelBuilder.Entity<fn_rbac_HS_POWER_SUPPLY>(eb => {eb.HasNoKey();});
            modelBuilder.Entity<fn_rbac_HS_OFFICE_DOCUMENTSOLUTION>(eb => {eb.HasNoKey();});
            modelBuilder.Entity<fn_rbac_HS_DEVICE_CERTIFICATES>(eb => {eb.HasNoKey();});
            modelBuilder.Entity<fn_rbac_SMS_SC_SysResUse_Properties>(eb => {eb.HasNoKey();});
            modelBuilder.Entity<fn_rbac_GS_PRINT_JOB>(eb => {eb.HasNoKey();});
            modelBuilder.Entity<fn_rbac_WOLGetWOLEnabledSites>(eb => {eb.HasNoKey();});
            modelBuilder.Entity<fn_rbac_GS_OFFICE_MACROERROR>(eb => {eb.HasNoKey();});
            modelBuilder.Entity<fn_rbac_GS_DEVICE_CLIENT>(eb => {eb.HasNoKey();});
            modelBuilder.Entity<fn_rbac_CM_RES_COLL_SMS00001>(eb => {eb.HasNoKey();});
            modelBuilder.Entity<fn_rbac_PackageStatusDistPointsSumm>(eb => {eb.HasNoKey();});
            modelBuilder.Entity<fn_rbac_securedobjecttypes>(eb => {eb.HasNoKey();});
            modelBuilder.Entity<fn_rbac_TaskSequencePackage>(eb => {eb.HasNoKey();});
            modelBuilder.Entity<fn_rbac_HS_PRINT_JOB>(eb => {eb.HasNoKey();});
            modelBuilder.Entity<fn_rbac_HS_OFFICE_MACROERROR>(eb => {eb.HasNoKey();});
            modelBuilder.Entity<fn_rbac_HS_DEVICE_CLIENT>(eb => {eb.HasNoKey();});
            modelBuilder.Entity<fn_rbac_WOLCommunicationErrorStatus>(eb => {eb.HasNoKey();});
            modelBuilder.Entity<fn_rbac_AllowOrDenyListViolationData>(eb => {eb.HasNoKey();});
            modelBuilder.Entity<fn_rbac_DeploymentSummary2>(eb => {eb.HasNoKey();});
            modelBuilder.Entity<fn_rbac_System_SMS_Assign_ARR>(eb => {eb.HasNoKey();});
            modelBuilder.Entity<fn_rbac_GS_PRINTER_CONFIGURATION>(eb => {eb.HasNoKey();});
            modelBuilder.Entity<fn_rbac_UserMachineSourceRelation>(eb => {eb.HasNoKey();});
            modelBuilder.Entity<fn_rbac_GS_DEVICE_CLIENTAGENTVERSION>(eb => {eb.HasNoKey();});
            modelBuilder.Entity<fn_rbac_SupportedPlatforms>(eb => {eb.HasNoKey();});
            modelBuilder.Entity<fn_rbac_ApplicationIdToNameMap>(eb => {eb.HasNoKey();});
            modelBuilder.Entity<fn_rbac_Collections>(eb => {eb.HasNoKey();});
            modelBuilder.Entity<fn_rbac_StateMigration>(eb => {eb.HasNoKey();});
            modelBuilder.Entity<fn_rbac_HS_PRINTER_CONFIGURATION>(eb => {eb.HasNoKey();});
            modelBuilder.Entity<fn_rbac_SoftwareUpdateSource>(eb => {eb.HasNoKey();});
            modelBuilder.Entity<fn_rbac_HS_DEVICE_CLIENTAGENTVERSION>(eb => {eb.HasNoKey();});
            modelBuilder.Entity<fn_rbac_replicationdata>(eb => {eb.HasNoKey();});
            modelBuilder.Entity<fn_rbac_CI_CurrentComplianceStatus>(eb => {eb.HasNoKey();});
            modelBuilder.Entity<fn_rbac_CM_RES_COLL_SMS00002>(eb => {eb.HasNoKey();});
            modelBuilder.Entity<fn_rbac_ClientMachines>(eb => {eb.HasNoKey();});
            modelBuilder.Entity<fn_rbac_GS_PRINTER_DEVICE>(eb => {eb.HasNoKey();});
            modelBuilder.Entity<fn_rbac_ObjectsAssignedToOneCategory>(eb => {eb.HasNoKey();});
            modelBuilder.Entity<fn_rbac_GS_DEVICE_COMPUTERSYSTEM>(eb => {eb.HasNoKey();});
            modelBuilder.Entity<fn_rbac_ProgramOffers>(eb => {eb.HasNoKey();});
            modelBuilder.Entity<fn_rbac_SMS_DistributionPointGroup>(eb => {eb.HasNoKey();});
            modelBuilder.Entity<fn_rbac_HS_PRINTER_DEVICE>(eb => {eb.HasNoKey();});
            modelBuilder.Entity<fn_rbac_MDMHealthAttestation>(eb => {eb.HasNoKey();});
            modelBuilder.Entity<fn_rbac_HS_DEVICE_COMPUTERSYSTEM>(eb => {eb.HasNoKey();});
            modelBuilder.Entity<fn_rbac_ProductFileInfo>(eb => {eb.HasNoKey();});
            modelBuilder.Entity<fn_rbac_CISettings>(eb => {eb.HasNoKey();});
            modelBuilder.Entity<fn_rbac_SecuredCategories>(eb => {eb.HasNoKey();});
            modelBuilder.Entity<fn_rbac_GS_PROCESS>(eb => {eb.HasNoKey();});
            modelBuilder.Entity<fn_rbac_LU_Tags>(eb => {eb.HasNoKey();});
            modelBuilder.Entity<fn_rbac_GS_DEVICE_DISPLAY>(eb => {eb.HasNoKey();});
            modelBuilder.Entity<fn_rbac_Package2>(eb => {eb.HasNoKey();});
            modelBuilder.Entity<fn_rbac_CM_RES_COLL_SMS00003>(eb => {eb.HasNoKey();});
            modelBuilder.Entity<fn_rbac_MDMDeviceThreat>(eb => {eb.HasNoKey();});
            modelBuilder.Entity<fn_rbac_HS_PROCESS>(eb => {eb.HasNoKey();});
            modelBuilder.Entity<fn_rbac_HS_DEVICE_DISPLAY>(eb => {eb.HasNoKey();});
            modelBuilder.Entity<fn_rbac_MIG_Entities>(eb => {eb.HasNoKey();});
            modelBuilder.Entity<fn_rbac_CISettingReferences>(eb => {eb.HasNoKey();});
            modelBuilder.Entity<fn_rbac_GS_PROCESSOR>(eb => {eb.HasNoKey();});
            modelBuilder.Entity<fn_rbac_LocalizedCIProperties2>(eb => {eb.HasNoKey();});
            modelBuilder.Entity<fn_rbac_GS_DEVICE_EMAIL>(eb => {eb.HasNoKey();});
            modelBuilder.Entity<fn_rbac_CIRules>(eb => {eb.HasNoKey();});
            modelBuilder.Entity<fn_rbac_HS_PROCESSOR>(eb => {eb.HasNoKey();});
            modelBuilder.Entity<fn_rbac_LocalizedCategories_SiteLoc>(eb => {eb.HasNoKey();});
            modelBuilder.Entity<fn_rbac_HS_DEVICE_EMAIL>(eb => {eb.HasNoKey();});
            modelBuilder.Entity<fn_rbac_FileUsageSummary>(eb => {eb.HasNoKey();});
            modelBuilder.Entity<fn_rbac_CM_RES_COLL_SMS00004>(eb => {eb.HasNoKey();});
            modelBuilder.Entity<fn_rbac_DeviceClientHealthState>(eb => {eb.HasNoKey();});
            modelBuilder.Entity<fn_rbac_GS_PROTECTED_VOLUME_INFO>(eb => {eb.HasNoKey();});
            modelBuilder.Entity<fn_rbac_GS_DEVICE_ENCRYPTION>(eb => {eb.HasNoKey();});
            modelBuilder.Entity<fn_rbac_DPGroupMembers>(eb => {eb.HasNoKey();});
            modelBuilder.Entity<fn_rbac_ClassicDeploymentAssetDetails>(eb => {eb.HasNoKey();});
            modelBuilder.Entity<fn_rbac_HS_PROTECTED_VOLUME_INFO>(eb => {eb.HasNoKey();});
            modelBuilder.Entity<fn_rbac_GS_AntimalwareInfectionStatus>(eb => {eb.HasNoKey();});
            modelBuilder.Entity<fn_rbac_HS_DEVICE_ENCRYPTION>(eb => {eb.HasNoKey();});
            modelBuilder.Entity<fn_rbac_CollectionExpandedUserMembers>(eb => {eb.HasNoKey();});
            modelBuilder.Entity<fn_rbac_GS_PROTOCOL>(eb => {eb.HasNoKey();});
            modelBuilder.Entity<fn_rbac_GetAdminIDsfromUserSIDs>(eb => {eb.HasNoKey();});
            modelBuilder.Entity<fn_rbac_GS_DEVICE_EXCHANGE>(eb => {eb.HasNoKey();});
            modelBuilder.Entity<fn_rbac_CH_ClientSummaryHistory>(eb => {eb.HasNoKey();});
            modelBuilder.Entity<fn_rbac_CM_RES_COLL_SMSOTHER>(eb => {eb.HasNoKey();});
            modelBuilder.Entity<fn_rbac_HS_PROTOCOL>(eb => {eb.HasNoKey();});
            modelBuilder.Entity<fn_rbac_ConfigurationItemsOSD>(eb => {eb.HasNoKey();});
            modelBuilder.Entity<fn_rbac_HS_DEVICE_EXCHANGE>(eb => {eb.HasNoKey();});
            modelBuilder.Entity<fn_rbac_CIRulesAll>(eb => {eb.HasNoKey();});
            modelBuilder.Entity<fn_rbac_GS_QUICK_FIX_ENGINEERING>(eb => {eb.HasNoKey();});
            modelBuilder.Entity<fn_rbac_GS_DEVICE_INFO>(eb => {eb.HasNoKey();});
            modelBuilder.Entity<fn_rbac_HS_QUICK_FIX_ENGINEERING>(eb => {eb.HasNoKey();});
            modelBuilder.Entity<fn_rbac_ClientModeReadiness>(eb => {eb.HasNoKey();});
            modelBuilder.Entity<fn_rbac_GS_DEVICE_INSTALLEDAPPLICATIONS>(eb => {eb.HasNoKey();});
            modelBuilder.Entity<fn_rbac_CM_RES_COLL_SMS000US>(eb => {eb.HasNoKey();});
            modelBuilder.Entity<fn_rbac_CIComplianceSummary>(eb => {eb.HasNoKey();});
            modelBuilder.Entity<fn_rbac_CM_RES_COLL_PS100014>(eb => {eb.HasNoKey();});
            modelBuilder.Entity<fn_rbac_GS_RAX_APPLICATION>(eb => {eb.HasNoKey();});
            modelBuilder.Entity<fn_rbac_Collection>(eb => {eb.HasNoKey();});
            modelBuilder.Entity<fn_rbac_HS_DEVICE_INSTALLEDAPPLICATIONS>(eb => {eb.HasNoKey();});
            modelBuilder.Entity<fn_rbac_R_IPNetwork>(eb => {eb.HasNoKey();});
            modelBuilder.Entity<fn_rbac_HS_RAX_APPLICATION>(eb => {eb.HasNoKey();});
            modelBuilder.Entity<fn_rbac_CIAssignmentStatus>(eb => {eb.HasNoKey();});
            modelBuilder.Entity<fn_rbac_GS_DEVICE_IRDA>(eb => {eb.HasNoKey();});
            modelBuilder.Entity<fn_rbac_R_ProvisioningSystem>(eb => {eb.HasNoKey();});
            modelBuilder.Entity<fn_rbac_GS_SYSTEM_ENCLOSURE_UNIQUE>(eb => {eb.HasNoKey();});
            modelBuilder.Entity<fn_rbac_WOLEnabledAdvertisements>(eb => {eb.HasNoKey();});
            modelBuilder.Entity<fn_rbac_CIComplianceHistory>(eb => {eb.HasNoKey();});
            modelBuilder.Entity<fn_rbac_GS_CCM_RECENTLY_USED_APPS>(eb => {eb.HasNoKey();});
            modelBuilder.Entity<fn_rbac_HS_DEVICE_IRDA>(eb => {eb.HasNoKey();});
            modelBuilder.Entity<fn_rbac_CM_RES_COLL_SMSDM001>(eb => {eb.HasNoKey();});
            modelBuilder.Entity<fn_rbac_GS_REGISTRY>(eb => {eb.HasNoKey();});
            modelBuilder.Entity<fn_rbac_CAL_INSTALLED_SOFTWARE_DATA>(eb => {eb.HasNoKey();});
            modelBuilder.Entity<fn_rbac_GS_DEVICE_MEMORY_ADDRESS>(eb => {eb.HasNoKey();});
            modelBuilder.Entity<fn_rbac_StatMsgInsStrings>(eb => {eb.HasNoKey();});
            modelBuilder.Entity<fn_rbac_AppIntentAssetData>(eb => {eb.HasNoKey();});
            modelBuilder.Entity<fn_rbac_HS_REGISTRY>(eb => {eb.HasNoKey();});
            modelBuilder.Entity<fn_rbac_AMTMachineInfo>(eb => {eb.HasNoKey();});
            modelBuilder.Entity<fn_rbac_HS_DEVICE_MEMORY_ADDRESS>(eb => {eb.HasNoKey();});
            modelBuilder.Entity<fn_rbac_AgentDiscoveries>(eb => {eb.HasNoKey();});
            modelBuilder.Entity<fn_rbac_GS_SCSI_CONTROLLER>(eb => {eb.HasNoKey();});
            modelBuilder.Entity<fn_rbac_GS_DEVICE_MEMORY>(eb => {eb.HasNoKey();});
            modelBuilder.Entity<fn_rbac_tasksequenceappreferencesinfo>(eb => {eb.HasNoKey();});
            modelBuilder.Entity<fn_rbac_LU_LicensedProduct>(eb => {eb.HasNoKey();});
            modelBuilder.Entity<fn_rbac_CM_RES_COLL_SMSDM003>(eb => {eb.HasNoKey();});
            modelBuilder.Entity<fn_rbac_HS_SCSI_CONTROLLER>(eb => {eb.HasNoKey();});
            modelBuilder.Entity<fn_rbac_HS_DEVICE_MEMORY>(eb => {eb.HasNoKey();});
            modelBuilder.Entity<fn_rbac_WOLGetPendingObjectSchedules>(eb => {eb.HasNoKey();});
            modelBuilder.Entity<fn_rbac_LicenseKeyStatus>(eb => {eb.HasNoKey();});
            modelBuilder.Entity<fn_rbac_Add_Remove_Programs>(eb => {eb.HasNoKey();});
            modelBuilder.Entity<fn_rbac_GS_SERIAL_PORT_CONFIGURATION>(eb => {eb.HasNoKey();});
            modelBuilder.Entity<fn_rbac_GS_DEVICE_OSINFORMATION>(eb => {eb.HasNoKey();});
            modelBuilder.Entity<fn_rbac_SoftwareProduct>(eb => {eb.HasNoKey();});
            modelBuilder.Entity<fn_rbac_HS_SERIAL_PORT_CONFIGURATION>(eb => {eb.HasNoKey();});
            modelBuilder.Entity<fn_rbac_HS_DEVICE_OSINFORMATION>(eb => {eb.HasNoKey();});
            modelBuilder.Entity<fn_rbac_SMS_SC_SysResUse>(eb => {eb.HasNoKey();});
            modelBuilder.Entity<fn_rbac_GS_LastSoftwareScan>(eb => {eb.HasNoKey();});
            modelBuilder.Entity<fn_rbac_GS_SERIAL_PORT>(eb => {eb.HasNoKey();});
            modelBuilder.Entity<fn_rbac_GS_DEVICE_PASSWORD>(eb => {eb.HasNoKey();});
            modelBuilder.Entity<fn_rbac_Roles>(eb => {eb.HasNoKey();});
            modelBuilder.Entity<fn_rbac_usermachinerelation>(eb => {eb.HasNoKey();});
            modelBuilder.Entity<fn_rbac_HS_SERIAL_PORT>(eb => {eb.HasNoKey();});
            modelBuilder.Entity<fn_rbac_HS_DEVICE_PASSWORD>(eb => {eb.HasNoKey();});
            modelBuilder.Entity<fn_rbac_Program>(eb => {eb.HasNoKey();});
            modelBuilder.Entity<fn_rbac_en_clientcertificaterecords>(eb => {eb.HasNoKey();});
            modelBuilder.Entity<fn_rbac_GS_SERVER_FEATURE>(eb => {eb.HasNoKey();});
            modelBuilder.Entity<fn_rbac_GS_DEVICE_POLICY>(eb => {eb.HasNoKey();});
            modelBuilder.Entity<fn_rbac_dcmdeploymentresourcesuser>(eb => {eb.HasNoKey();});
            modelBuilder.Entity<fn_rbac_HS_SERVER_FEATURE>(eb => {eb.HasNoKey();});
            modelBuilder.Entity<fn_rbac_HS_DEVICE_POLICY>(eb => {eb.HasNoKey();});
            modelBuilder.Entity<fn_rbac_MIG_Clients>(eb => {eb.HasNoKey();});
            modelBuilder.Entity<fn_rbac_GS_SERVICE>(eb => {eb.HasNoKey();});
            modelBuilder.Entity<fn_rbac_GS_DEVICE_POWER>(eb => {eb.HasNoKey();});
            modelBuilder.Entity<fn_rbac_MDMDeviceManagementStates>(eb => {eb.HasNoKey();});
            modelBuilder.Entity<fn_rbac_CITargetedCollections>(eb => {eb.HasNoKey();});
            modelBuilder.Entity<fn_rbac_HS_SERVICE>(eb => {eb.HasNoKey();});
            modelBuilder.Entity<fn_rbac_HS_DEVICE_POWER>(eb => {eb.HasNoKey();});
            modelBuilder.Entity<fn_rbac_LocalizedCIProperties_SiteLoc>(eb => {eb.HasNoKey();});
            modelBuilder.Entity<fn_rbac_AssignmentStatePerTopic>(eb => {eb.HasNoKey();});
            modelBuilder.Entity<fn_rbac_GS_SHARE>(eb => {eb.HasNoKey();});
            modelBuilder.Entity<fn_rbac_GS_DEVICE_WINDOWSSECURITYPOLICY>(eb => {eb.HasNoKey();});
            modelBuilder.Entity<fn_rbac_LU_Category>(eb => {eb.HasNoKey();});
            modelBuilder.Entity<fn_rbac_Alert>(eb => {eb.HasNoKey();});
            modelBuilder.Entity<fn_rbac_HS_SHARE>(eb => {eb.HasNoKey();});
            modelBuilder.Entity<fn_rbac_HS_DEVICE_WINDOWSSECURITYPOLICY>(eb => {eb.HasNoKey();});
            modelBuilder.Entity<fn_rbac_R_System>(eb => {eb.HasNoKey();});
            modelBuilder.Entity<fn_rbac_GS_Threats>(eb => {eb.HasNoKey();});
            modelBuilder.Entity<fn_rbac_GS_SMS_ADVANCED_CLIENT_STATE>(eb => {eb.HasNoKey();});
            modelBuilder.Entity<fn_rbac_GS_DEVICE_WLAN>(eb => {eb.HasNoKey();});
            modelBuilder.Entity<fn_rbac_RA_System_IPAddresses>(eb => {eb.HasNoKey();});
            modelBuilder.Entity<fn_rbac_FullCollectionMembership>(eb => {eb.HasNoKey();});
            modelBuilder.Entity<fn_rbac_EN_CertificateAuthorities>(eb => {eb.HasNoKey();});
            modelBuilder.Entity<fn_rbac_HS_SMS_ADVANCED_CLIENT_STATE>(eb => {eb.HasNoKey();});
            modelBuilder.Entity<fn_rbac_HS_DEVICE_WLAN>(eb => {eb.HasNoKey();});
            modelBuilder.Entity<fn_rbac_RA_System_IPSubnets>(eb => {eb.HasNoKey();});
            modelBuilder.Entity<fn_rbac_CI_ApplicablePlatforms>(eb => {eb.HasNoKey();});
            modelBuilder.Entity<fn_rbac_GS_SOFTWARE_SHORTCUT>(eb => {eb.HasNoKey();});
            modelBuilder.Entity<fn_rbac_GS_DISK>(eb => {eb.HasNoKey();});
            modelBuilder.Entity<fn_rbac_RA_System_IPv6Addresses>(eb => {eb.HasNoKey();});
            modelBuilder.Entity<fn_rbac_CH_HealthCheckInfo>(eb => {eb.HasNoKey();});
            modelBuilder.Entity<fn_rbac_DrsSendHistorySummary>(eb => {eb.HasNoKey();});
            modelBuilder.Entity<fn_rbac_HS_SOFTWARE_SHORTCUT>(eb => {eb.HasNoKey();});
            modelBuilder.Entity<fn_rbac_HS_DISK>(eb => {eb.HasNoKey();});
            modelBuilder.Entity<fn_rbac_RA_System_IPv6Prefixes>(eb => {eb.HasNoKey();});
            modelBuilder.Entity<fn_rbac_CH_ClientSummary>(eb => {eb.HasNoKey();});
            modelBuilder.Entity<fn_rbac_UserMachineIntelligence>(eb => {eb.HasNoKey();});
            modelBuilder.Entity<fn_rbac_GS_SOFTWARE_TAG>(eb => {eb.HasNoKey();});
            modelBuilder.Entity<fn_rbac_GS_DMA_CHANNEL>(eb => {eb.HasNoKey();});
            modelBuilder.Entity<fn_rbac_RA_System_MACAddresses>(eb => {eb.HasNoKey();});
            modelBuilder.Entity<fn_rbac_HS_SOFTWARE_TAG>(eb => {eb.HasNoKey();});
            modelBuilder.Entity<fn_rbac_HS_DMA_CHANNEL>(eb => {eb.HasNoKey();});
            modelBuilder.Entity<fn_rbac_RA_System_ResourceNames>(eb => {eb.HasNoKey();});
            modelBuilder.Entity<fn_rbac_GS_SOUND_DEVICE>(eb => {eb.HasNoKey();});
            modelBuilder.Entity<fn_rbac_GS_DRIVER_VXD>(eb => {eb.HasNoKey();});
            modelBuilder.Entity<fn_rbac_RA_System_SystemGroupName>(eb => {eb.HasNoKey();});
            modelBuilder.Entity<fn_rbac_DM_WipeRecords>(eb => {eb.HasNoKey();});
            modelBuilder.Entity<fn_rbac_HS_SOUND_DEVICE>(eb => {eb.HasNoKey();});
            modelBuilder.Entity<fn_rbac_HS_DRIVER_VXD>(eb => {eb.HasNoKey();});
            modelBuilder.Entity<fn_rbac_RA_System_SMSAssignedSites>(eb => {eb.HasNoKey();});
            modelBuilder.Entity<fn_rbac_AssignmentTargetedCIs>(eb => {eb.HasNoKey();});
            modelBuilder.Entity<fn_rbac_CIConflictCode>(eb => {eb.HasNoKey();});
            modelBuilder.Entity<fn_rbac_GS_ADVANCED_CLIENT_SSL_CONFIGURATIONS>(eb => {eb.HasNoKey();});
            modelBuilder.Entity<fn_rbac_GS_EMBEDDED_DEVICE_INFO>(eb => {eb.HasNoKey();});
            modelBuilder.Entity<fn_rbac_RA_System_SMSInstalledSites>(eb => {eb.HasNoKey();});
            modelBuilder.Entity<fn_rbac_ApplicationAssignment>(eb => {eb.HasNoKey();});
            modelBuilder.Entity<fn_rbac_HS_ADVANCED_CLIENT_SSL_CONFIGURATIONS>(eb => {eb.HasNoKey();});
            modelBuilder.Entity<fn_rbac_HS_EMBEDDED_DEVICE_INFO>(eb => {eb.HasNoKey();});
            modelBuilder.Entity<fn_rbac_RA_System_SMS_Resident>(eb => {eb.HasNoKey();});
            modelBuilder.Entity<fn_rbac_Advertisement>(eb => {eb.HasNoKey();});
            modelBuilder.Entity<fn_rbac_DistributionPoints>(eb => {eb.HasNoKey();});
            modelBuilder.Entity<fn_rbac_CIComplianceStatusErrorDetail>(eb => {eb.HasNoKey();});
            modelBuilder.Entity<fn_rbac_GS_SOFTWARE_LICENSING_PRODUCT>(eb => {eb.HasNoKey();});
            modelBuilder.Entity<fn_rbac_GS_ENCRYPTABLE_VOLUME>(eb => {eb.HasNoKey();});
            modelBuilder.Entity<fn_rbac_RA_System_SystemContainerName>(eb => {eb.HasNoKey();});
            modelBuilder.Entity<fn_rbac_HS_SOFTWARE_LICENSING_PRODUCT>(eb => {eb.HasNoKey();});
            modelBuilder.Entity<fn_rbac_HS_ENCRYPTABLE_VOLUME>(eb => {eb.HasNoKey();});
            modelBuilder.Entity<fn_rbac_RA_System_System_Group_Name>(eb => {eb.HasNoKey();});
            modelBuilder.Entity<fn_rbac_GS_SOFTWARE_LICENSING_SERVICE>(eb => {eb.HasNoKey();});
            modelBuilder.Entity<fn_rbac_GS_ENVIRONMENT>(eb => {eb.HasNoKey();});
            modelBuilder.Entity<fn_rbac_RA_System_SystemOUName>(eb => {eb.HasNoKey();});
            modelBuilder.Entity<fn_rbac_HS_SOFTWARE_LICENSING_SERVICE>(eb => {eb.HasNoKey();});
            modelBuilder.Entity<fn_rbac_HS_ENVIRONMENT>(eb => {eb.HasNoKey();});
            modelBuilder.Entity<fn_rbac_RA_System_SystemRoles>(eb => {eb.HasNoKey();});
            modelBuilder.Entity<fn_rbac_CICurrentComplianceStatus>(eb => {eb.HasNoKey();});
            modelBuilder.Entity<fn_rbac_GS_SYSTEM_ACCOUNT>(eb => {eb.HasNoKey();});
            modelBuilder.Entity<fn_rbac_GS_FIRMWARE>(eb => {eb.HasNoKey();});
            modelBuilder.Entity<fn_rbac_CIErrorDetails>(eb => {eb.HasNoKey();});
            modelBuilder.Entity<fn_rbac_HS_SYSTEM_ACCOUNT>(eb => {eb.HasNoKey();});
            modelBuilder.Entity<fn_rbac_HS_FIRMWARE>(eb => {eb.HasNoKey();});
            modelBuilder.Entity<fn_rbac_R_UnknownSystem>(eb => {eb.HasNoKey();});
            modelBuilder.Entity<fn_rbac_CombinedDeviceResources>(eb => {eb.HasNoKey();});
            modelBuilder.Entity<fn_rbac_CIComplianceStatusReificationDetail>(eb => {eb.HasNoKey();});
            modelBuilder.Entity<fn_rbac_GS_SYSTEM_CONSOLE_USAGE>(eb => {eb.HasNoKey();});
            modelBuilder.Entity<fn_rbac_GS_FOLDER_REDIRECTION_HEALTH>(eb => {eb.HasNoKey();});
            modelBuilder.Entity<fn_rbac_RA_Unknown_System_SMS_Assig>(eb => {eb.HasNoKey();});
            modelBuilder.Entity<fn_rbac_R_System_Valid>(eb => {eb.HasNoKey();});
            modelBuilder.Entity<fn_rbac_HS_SYSTEM_CONSOLE_USAGE>(eb => {eb.HasNoKey();});
            modelBuilder.Entity<fn_rbac_GS_IDE_CONTROLLER>(eb => {eb.HasNoKey();});
            modelBuilder.Entity<fn_rbac_UserMachineRelationship>(eb => {eb.HasNoKey();});
            modelBuilder.Entity<fn_rbac_GS_SYSTEM_CONSOLE_USER>(eb => {eb.HasNoKey();});
            modelBuilder.Entity<fn_rbac_HS_IDE_CONTROLLER>(eb => {eb.HasNoKey();});
            modelBuilder.Entity<fn_rbac_CICategories_All>(eb => {eb.HasNoKey();});
            modelBuilder.Entity<fn_rbac_INSTALLED_SOFTWARE_DATA_Summary>(eb => {eb.HasNoKey();});
            modelBuilder.Entity<fn_rbac_HS_SYSTEM_CONSOLE_USER>(eb => {eb.HasNoKey();});
            modelBuilder.Entity<fn_rbac_GS_INSTALLED_EXECUTABLE>(eb => {eb.HasNoKey();});
            modelBuilder.Entity<fn_rbac_FullCollectionMembership_Valid>(eb => {eb.HasNoKey();});
            #endregion
        }
    }
}
