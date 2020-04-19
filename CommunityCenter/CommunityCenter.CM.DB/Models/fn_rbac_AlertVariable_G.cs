using System;

namespace CommunityCenter.CM.DB.Models
{
    public class fn_rbac_AlertVariable_G
    {
        public int ID { get; set; }

        public int TypeID { get; set; }

        public string TypeInstanceID { get; set; }

        public int? Value_Int { get; set; }

        public DateTime? LastChangeTime { get; set; }

    }
}

