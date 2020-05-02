using System;
using System.Collections.Generic;
using System.Text;

namespace CommunityCenter.SQL.Models
{
    public class CCQuery
    {
        public ICollection<CCTable> Tables { get; set; }
        public ICollection<string> OrderBy { get; set; }
        public int Take { get; set; }
        public int Page { get; set; }
        public string Query
        {
            get
            {
                string q = "Select ";
                foreach(var t in Tables)
                {
                    string propStart = $"[{t.TableName}].[";
                    foreach(var c in t.Columns)
                    {
                        if(c.Visibility == ColumnVisibility.Visible)
                        {
                            q += $"[{t.TableName}].[{c.ColumnName}],";
                        }
                    }
                }
                q = q.TrimEnd(',') + " FROM ";

                return q;
            }
        }
    }
}
