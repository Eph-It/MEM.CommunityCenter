using System;

namespace CommunityCenter.CM.DB.Models
{
    public class fn_rbac_AppIntentAssetData
    {
        public int MachineID { get; set; }

        public string MachineName { get; set; }

        public int UserID { get; set; }

        public string UserName { get; set; }

        public int AssignmentID { get; set; }

        public int AppCI { get; set; }

        public byte ComplianceState { get; set; }

        public short? EnforcementState { get; set; }

        public bool? IsApplicable { get; set; }

        public byte DesiredState { get; set; }

        public string AssignmentUniqueID { get; set; }

    }
}

