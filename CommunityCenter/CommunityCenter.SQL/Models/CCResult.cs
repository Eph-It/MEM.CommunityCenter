using System;
using System.Collections.Generic;
using System.Text;

namespace CommunityCenter.SQL.Models
{
    public class CCResult
    {
        public ICollection<Dictionary<string, object>> Results { get; set; }
        public int Total { get; set; }
        public int CurrentPage { get; set; }
        
    }
}
