using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

namespace CommunityCenter.SQL
{
    public class CCSql : ICCSql
    {
        private string _connectionString;
        public CCSql(string connectionString)
        {
            _connectionString = connectionString;
        }
        public async System.Threading.Tasks.Task<CCSQLResult> ExecuteQueryAsync(string query, Dictionary<string, object> Parameters = null)
        {
            var result = new CCSQLResult();
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    if(Parameters != null)
                    {
                        foreach(var key in Parameters.Keys)
                        {
                            string paramName = key;
                            if(!paramName.StartsWith("@")) { paramName = "@" + paramName; }
                            command.Parameters.AddWithValue(paramName, Parameters[key]);
                        }
                    }
                    using (SqlDataReader reader = await command.ExecuteReaderAsync())
                    {
                        result.Columns = Enumerable.Range(0, reader.FieldCount).Select(reader.GetName).ToList();
                        while (reader.Read())
                        {
                            object[] values = new object[reader.FieldCount];
                            reader.GetValues(values);
                            result.Results.Add(values);
                        }
                    }
                }
            }
            return result;
        }
        public CCSQLResult ExecuteQuery(string query, Dictionary<string, object> Parameters = null)
        {
            var r = ExecuteQueryAsync(query, Parameters);
            r.Wait();
            return r.Result;
        }

    }
}
