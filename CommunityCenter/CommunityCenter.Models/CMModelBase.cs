using System;
using System.Collections.Generic;
using System.Text;

namespace CommunityCenter.CM.Models
{
    public class CMModelBase
    {
        public string _Endpoint { get; set; }
        public int Skip { get; set; }
        public int Top { get; set; }
        public string OrderBy { get; set; }
        public string Filter { get; set; }
    }
}
