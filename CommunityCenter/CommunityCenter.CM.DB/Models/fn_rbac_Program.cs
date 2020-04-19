using System;

namespace CommunityCenter.CM.DB.Models
{
    public class fn_rbac_Program
    {
        public string ProgramName { get; set; }

        public string PackageID { get; set; }

        public string CommandLine { get; set; }

        public string Comment { get; set; }

        public string Description { get; set; }

        public string Requirements { get; set; }

        public string DependentProgram { get; set; }

        public string DriveLetter { get; set; }

        public string WorkingDirectory { get; set; }

        public string ApplicationHierarchy { get; set; }

        public int? ProgramFlags { get; set; }

        public string DiskSpaceRequired { get; set; }

        public int? Duration { get; set; }

        public string RemovalKey { get; set; }

        public int ActionInProgress { get; set; }

    }
}

