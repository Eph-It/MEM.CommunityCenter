using System;

namespace CommunityCenter.Models.RBAC
{
    public class fn_rbac_AppDTDeploymentSummary
    {
        public int CI_ID { get; set; }

        public int? ParentID { get; set; }

        public string TargetCollectionID { get; set; }

        public int AssignmentID { get; set; }

        public string Descript { get; set; }

        public DateTime? DeploymentTime { get; set; }

        public DateTime? ModificationTime { get; set; }

        public int? OfferTypeID { get; set; }

        public int? AlreadyPresent { get; set; }

        public int? Success { get; set; }

        public int? InProgress { get; set; }

        public int? Unknown { get; set; }

        public int? Error { get; set; }

        public int? RequirementsNotMet { get; set; }

    }
}

