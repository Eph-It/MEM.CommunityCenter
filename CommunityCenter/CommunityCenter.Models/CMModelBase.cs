using System;
using System.Collections.Generic;
using System.Text;

namespace CommunityCenter.CM.Models
{
    public class CMModelBase
    {
        public string _Endpoint { get; set; }
        public int _Skip { get; set; }
        public int _Top { get; set; }
        public string _OrderBy { get; set; }
        public string _Filter { get; set; }
    }
}
