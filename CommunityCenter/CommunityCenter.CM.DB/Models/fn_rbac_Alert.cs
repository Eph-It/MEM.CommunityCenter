using System;

namespace CommunityCenter.CM.DB.Models
{
    public class fn_rbac_Alert
    {
        public int ID { get; set; }

        public string TypeID { get; set; }

        public int RawTypeID { get; set; }

        public string TypeInstanceID { get; set; }

        public string Name { get; set; }

        public string FeatureArea { get; set; }

        public int? Severity { get; set; }

        public string ParameterValues { get; set; }

        public int? RuleState { get; set; }

        public bool? Enabled { get; set; }

        public DateTime? SkipUntil { get; set; }

        public DateTime? CreationTime { get; set; }

        public int AlertState { get; set; }

        public string Comments { get; set; }

        public DateTime? FirstRaisedTime { get; set; }

        public DateTime? LastChangeTime { get; set; }

        public DateTime? AlertStateChangeTime { get; set; }

        public string CreatedBy { get; set; }

        public string ModifiedBy { get; set; }

        public string ClosedBy { get; set; }

        public int? OccurrenceCount { get; set; }

    }
}

