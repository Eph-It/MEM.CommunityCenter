using System;
using System.Collections.Generic;
using System.Text;

namespace CommunityCenter.SQL
{
    public class CCSQLResult
    {
        public List<string> Columns { get; set; }
        public List<object[]>Results { get; set; }
        public CCSQLResult()
        {
            Results = new List<object[]>();
        }
    }
}
