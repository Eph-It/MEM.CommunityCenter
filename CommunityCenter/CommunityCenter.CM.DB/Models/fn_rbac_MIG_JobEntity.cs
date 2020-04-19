using System;

namespace CommunityCenter.CM.DB.Models
{
    public class fn_rbac_MIG_JobEntity
    {
        public int EntityID { get; set; }

        public int JobID { get; set; }

        public int JobEntityStatus { get; set; }

        public string EntityName { get; set; }

        public int? EntityStatus { get; set; }

        public int? EntityRichStatus { get; set; }

        public int? Type { get; set; }

        public string UniqueID { get; set; }

        public int? MessageCode { get; set; }

        public string Detail1 { get; set; }

        public string Detail2 { get; set; }

        public string Detail3 { get; set; }

    }
}

