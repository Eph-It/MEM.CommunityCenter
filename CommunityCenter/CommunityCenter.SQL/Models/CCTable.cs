using System;
using System.Collections.Generic;
using System.Text;

namespace CommunityCenter.SQL.Models
{
    public class CCTable
    {
        public string TableName { get; set; }
        public List<CCColumn> Columns { get; set; }
    }
}
