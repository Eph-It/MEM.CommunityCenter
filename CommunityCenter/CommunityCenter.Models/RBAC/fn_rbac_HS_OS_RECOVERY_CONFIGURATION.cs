using System;

namespace CommunityCenter.Models.RBAC
{
    public class fn_rbac_HS_OS_RECOVERY_CONFIGURATION
    {
        public int ResourceID { get; set; }

        public int GroupID { get; set; }

        public int RevisionID { get; set; }

        public int? AgentID { get; set; }

        public DateTime TimeStamp { get; set; }

        public int? AutoReboot0 { get; set; }

        public string Caption0 { get; set; }

        public string DebugFilePath0 { get; set; }

        public string Description0 { get; set; }

        public int? KernelDumpOnly0 { get; set; }

        public string Name0 { get; set; }

        public int? OverwriteExistingDebugFile0 { get; set; }

        public int? SendAdminAlert0 { get; set; }

        public string SettingID0 { get; set; }

        public int? WriteDebugInfo0 { get; set; }

        public int? WriteToSystemLog0 { get; set; }

    }
}

