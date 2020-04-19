using System;

namespace CommunityCenter.CM.DB.Models
{
    public class fn_rbac_HS_DEVICE_PASSWORD
    {
        public int ResourceID { get; set; }

        public int GroupID { get; set; }

        public int RevisionID { get; set; }

        public int? AgentID { get; set; }

        public DateTime TimeStamp { get; set; }

        public int? AllowRecoveryPassword0 { get; set; }

        public int? AutolockTimeout0 { get; set; }

        public int? Enabled0 { get; set; }

        public int? Expiration0 { get; set; }

        public int? History0 { get; set; }

        public int? MaxAttemptsBeforeWipe0 { get; set; }

        public int? MinComplexChars0 { get; set; }

        public int? MinLength0 { get; set; }

        public int? PasswordQuality0 { get; set; }

        public int? Type0 { get; set; }

    }
}

