using System;

namespace CommunityCenter.CM.DB.Models
{
    public class fn_rbac_CIAssignment
    {
        public int AssignmentID { get; set; }

        public string Assignment_UniqueID { get; set; }

        public string AssignmentName { get; set; }

        public string Description { get; set; }

        public int LocalCollectionID { get; set; }

        public string CollectionID { get; set; }

        public string CollectionName { get; set; }

        public int IncludeSubCollections { get; set; }

        public int DesiredConfigType { get; set; }

        public int AssignmentAction { get; set; }

        public int? NonComplianceCriticality { get; set; }

        public int DPLocality { get; set; }

        public bool LogComplianceToWinEvent { get; set; }

        public bool SendDetailedNonComplianceStatus { get; set; }

        public int SuppressReboot { get; set; }

        public bool NotifyUser { get; set; }

        public bool UseGMTTimes { get; set; }

        public DateTime CreationTime { get; set; }

        public DateTime? ExpirationTime { get; set; }

        public DateTime StartTime { get; set; }

        public DateTime? EnforcementDeadline { get; set; }

        public bool SoftDeadlineEnabled { get; set; }

        public DateTime LastModificationTime { get; set; }

        public string LastModifiedBy { get; set; }

        public DateTime? UpdateDeadlineTime { get; set; }

        public string EvaluationSchedule { get; set; }

        public bool? OverrideServiceWindows { get; set; }

        public bool? RebootOutsideOfServiceWindows { get; set; }

        public string SourceSite { get; set; }

        public int AssignmentType { get; set; }

        public int? Priority { get; set; }

        public int? OfferTypeID { get; set; }

        public int? OfferFlags { get; set; }

        public bool? RequireApproval { get; set; }

        public bool UpdateSupersedence { get; set; }

        public int LocaleID { get; set; }

        public bool? WoLEnabled { get; set; }

        public bool? RaiseMomAlertsOnFailure { get; set; }

        public bool? DisableMomAlerts { get; set; }

        public bool? EnforcementEnabled { get; set; }

        public bool? UserUIExperience { get; set; }

        public bool? AssignmentEnabled { get; set; }

        public bool? LimitStateMessageVerbosity { get; set; }

        public byte? StateMessageVerbosity { get; set; }

        public int? StateMessagePriority { get; set; }

        public bool? UseBranchCache { get; set; }

        public bool RequirePostRebootFullScan { get; set; }

        public bool? RandomizationEnabled { get; set; }

        public int? RandomizationMinutes { get; set; }

        public bool? PersistOnWriteFilterDevices { get; set; }

        public int? ParentAssignmentID { get; set; }

        public long rowversion { get; set; }

    }
}

