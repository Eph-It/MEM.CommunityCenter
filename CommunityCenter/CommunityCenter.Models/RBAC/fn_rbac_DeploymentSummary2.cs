using System;

namespace CommunityCenter.Models.RBAC
{
    public class fn_rbac_DeploymentSummary2
    {
        public string CollectionID { get; set; }

        public string OfferID { get; set; }

        public int? PolicyModelID { get; set; }

        public int? ModelID { get; set; }

        public int AssignmentID { get; set; }

        public string CollectionName { get; set; }

        public int? CollectionType { get; set; }

        public string SoftwareName { get; set; }

        public DateTime? DeploymentTime { get; set; }

        public DateTime? CreationTime { get; set; }

        public DateTime? ModificationTime { get; set; }

        public int? FeatureType { get; set; }

        public int? SummaryType { get; set; }

        public int? DeploymentIntent { get; set; }

        public DateTime? EnforcementDeadline { get; set; }

        public int? NumberSuccess { get; set; }

        public int? NumberInProgress { get; set; }

        public int? NumberUnknown { get; set; }

        public int? NumberErrors { get; set; }

        public int? NumberOther { get; set; }

        public int? NumberTotal { get; set; }

        public DateTime? SummarizationTime { get; set; }

        public string ProgramName { get; set; }

        public string PackageID { get; set; }

    }
}

