using System;

namespace CommunityCenter.Models.RBAC
{
    public class fn_rbac_Advertisement
    {
        public string AdvertisementID { get; set; }

        public string AdvertisementName { get; set; }

        public string PackageID { get; set; }

        public string ProgramName { get; set; }

        public string CollectionID { get; set; }

        public string Comment { get; set; }

        public int IncludeSubCollection { get; set; }

        public string HierarchyPath { get; set; }

        public int? AssignmentID { get; set; }

        public int? AssignedScheduleEnabled { get; set; }

        public DateTime? PresentTime { get; set; }

        public int? PresentTimeEnabled { get; set; }

        public int? PresentTimeIsGMT { get; set; }

        public DateTime? ExpirationTime { get; set; }

        public int? ExpirationTimeEnabled { get; set; }

        public int? ExpirationTimeIsGMT { get; set; }

        public int? TimeFlags { get; set; }

        public int? AdvertFlags { get; set; }

        public int? DeviceFlags { get; set; }

        public int? RemoteClientFlags { get; set; }

        public int? Priority { get; set; }

        public string SourceSite { get; set; }

        public int ActionInProgress { get; set; }

    }
}

