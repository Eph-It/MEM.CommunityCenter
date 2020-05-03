using System;
using System.Collections.Generic;
using System.Text;

namespace CommunityCenter.CM.Models
{
    public class CCObject
    {
        public string Table { get; set; }
        public string Name { get; set; }
        public string Parent { get; set; }
        public string ParentKey { get; set; }
        public string Key { get; set; }
        public CCObjectTableType TableType { get; set; }
        public string Parameters { get; set; }
    }

    public enum CCObjectTableType
    {
        Table,
        View,
        Function,
        StoredProcedure
    }
}
