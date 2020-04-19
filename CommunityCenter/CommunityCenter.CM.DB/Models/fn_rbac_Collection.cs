using System;

namespace CommunityCenter.CM.DB.Models
{
    public class fn_rbac_Collection
    {
        public string CollectionID { get; set; }

        public string Name { get; set; }

        public string Comment { get; set; }

        public DateTime? LastChangeTime { get; set; }

        public DateTime? EvaluationStartTime { get; set; }

        public DateTime? LastRefreshTime { get; set; }

        public int? RefreshType { get; set; }

        public int CollectionType { get; set; }

        public int CurrentStatus { get; set; }

        public int MemberCount { get; set; }

        public string MemberClassName { get; set; }

        public DateTime? LastMemberChangeTime { get; set; }

        public int CollID { get; set; }

    }
}

