using System;
using System.Collections.Generic;
using System.Text;

namespace CommunityCenter.SQL.Models
{
    public class CCColumn
    {
        public string ColumnName { get; set; }
        public string DisplayName { get; set; }
        public ColumnVisibility Visibility { get; set; }
    }
    public enum ColumnVisibility
    {
        Visible,
        Hidden
    }
}
