using System;

namespace CommunityCenter.Models.RBAC
{
    public class fn_rbac_GS_OFFICE_CLIENTMETRIC
    {
        public int ResourceID { get; set; }

        public int GroupID { get; set; }

        public int RevisionID { get; set; }

        public int? AgentID { get; set; }

        public DateTime TimeStamp { get; set; }

        public int? CompatibilityErrorCount0 { get; set; }

        public int? CrashedSessionCount0 { get; set; }

        public int? MacroCompileErrorCount0 { get; set; }

        public int? MacroRuntimeErrorCount0 { get; set; }

        public string OfficeApp0 { get; set; }

        public int? SessionCount0 { get; set; }

    }
}

