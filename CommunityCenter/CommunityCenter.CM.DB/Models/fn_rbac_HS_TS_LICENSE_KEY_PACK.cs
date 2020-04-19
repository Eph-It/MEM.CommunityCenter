﻿using System;

namespace CommunityCenter.CM.DB.Models
{
    public class fn_rbac_HS_TS_LICENSE_KEY_PACK
    {
        public int ResourceID { get; set; }

        public int GroupID { get; set; }

        public int RevisionID { get; set; }

        public int? AgentID { get; set; }

        public DateTime TimeStamp { get; set; }

        public int? AvailableLicenses0 { get; set; }

        public string Description0 { get; set; }

        public int? IssuedLicenses0 { get; set; }

        public int? KeyPackId0 { get; set; }

        public int? KeyPackType0 { get; set; }

        public int? ProductType0 { get; set; }

        public string ProductVersion0 { get; set; }

        public int? TotalLicenses0 { get; set; }

    }
}

