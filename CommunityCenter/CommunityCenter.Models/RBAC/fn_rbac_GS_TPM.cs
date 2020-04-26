using System;

namespace CommunityCenter.Models.RBAC
{
    public class fn_rbac_GS_TPM
    {
        public int ResourceID { get; set; }

        public int GroupID { get; set; }

        public int RevisionID { get; set; }

        public int? AgentID { get; set; }

        public DateTime TimeStamp { get; set; }

        public int? IsActivated_InitialValue0 { get; set; }

        public int? IsEnabled_InitialValue0 { get; set; }

        public int? IsOwned_InitialValue0 { get; set; }

        public int? ManufacturerId0 { get; set; }

        public string ManufacturerVersion0 { get; set; }

        public string ManufacturerVersionInfo0 { get; set; }

        public string PhysicalPresenceVersionInfo0 { get; set; }

        public string SpecVersion0 { get; set; }

    }
}

