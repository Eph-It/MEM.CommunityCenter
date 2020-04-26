using System;

namespace CommunityCenter.Models.RBAC
{
    public class fn_rbac_ClassicDeploymentAssetDetails
    {
        public string DeploymentID { get; set; }

        public string ProgramName { get; set; }

        public string PackageID { get; set; }

        public string PackageName { get; set; }

        public string CollectionID { get; set; }

        public string CollectionName { get; set; }

        public int DeviceID { get; set; }

        public string DeviceName { get; set; }

        public string UserName { get; set; }

        public int? MessageID { get; set; }

        public int? StatusType { get; set; }

        public string StatusDescription { get; set; }

        public DateTime? SummarizationTime { get; set; }

    }
}

