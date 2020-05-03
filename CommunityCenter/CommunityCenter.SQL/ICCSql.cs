using System;
using System.Collections.Generic;

namespace CommunityCenter.SQL
{
    public interface ICCSql
    {
        System.Threading.Tasks.Task<CCSQLResult> ExecuteQueryAsync(string query, Dictionary<string, object> Parameters = null);
        CCSQLResult ExecuteQuery(string query, Dictionary<string, object> Parameters = null);
    }
}
