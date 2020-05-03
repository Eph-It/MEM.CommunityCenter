using CommunityCenter.CM.Models;
using CommunityCenter.SQL;
using CommunityCenter.User;
using Microsoft.Extensions.Caching.Memory;
using System;
using System.Collections.Generic;
using System.Text;

namespace CommunityCenter.CM.DB
{
    public class CMDB
    {
        private ICCSql _ccSQL;
        private ICCUser _user;
        private CCObjectModel _objectModel;
        private IMemoryCache _cache;
        public CMDB(ICCSql ccSQL, ICCUser user, CCObjectModel objectModel, IMemoryCache memoryCache)
        {
            _ccSQL = ccSQL;
            _user = user;
            _objectModel = objectModel;
            _cache = memoryCache;
        }
        private string _cmUserSIDs;
        private void RefreshCMUserSIDs()
        {
            if(_cache.TryGetValue(_user.GetSids(), out _cmUserSIDs))
            {
                string query = "select dbo.fn_rbac_GetAdminIDsfromUserSIDs(@userSids) as Result";
                Dictionary<string, object> Params = new Dictionary<string, object>();
                Params.Add("userSids", _user.GetSids());
                _cmUserSIDs = _ccSQL.ExecuteQuery(query, Params).Results[0][0].ToString();
                var cacheEntryOptions = new MemoryCacheEntryOptions()
                    .SetSlidingExpiration(TimeSpan.FromMinutes(5));
                _cache.Set(_user.GetSids(), _cmUserSIDs, cacheEntryOptions);
            }
            
        }
        public string CMUserSIDs
        {
            get
            {
                if (String.IsNullOrEmpty(_cmUserSIDs))
                {
                    RefreshCMUserSIDs();
                }
                return _cmUserSIDs;
            }
        }
        
        public List<CMDBColumn> GetTableColumns(CCObject ccObject)
        {
            List<CMDBColumn> columns = new List<CMDBColumn>();
            if (_cache.TryGetValue($"GetTableColumns.{ccObject.Table}", out columns))
            {
                var cacheEntryOptions = new MemoryCacheEntryOptions()
                    .SetSlidingExpiration(TimeSpan.FromMinutes(10));

                string query = @"
                    SELECT col.name AS 'ColumnName'
		                    ,typ.name as 'ColumnType'
                        from sys.columns col
                            join sys.types typ on
                                col.system_type_id = typ.system_type_id AND col.user_type_id = typ.user_type_id
                        where object_id = object_id(@tableName)
                ";
                Dictionary<string, object> Params = new Dictionary<string, object>();
                Params.Add("tableName", ccObject.Table);
                var results = _ccSQL.ExecuteQuery(query, Params).Results;
                foreach(var result in results)
                {
                    var cmDBColumn = new CMDBColumn();
                    cmDBColumn.ColumnName = result[0].ToString();
                    cmDBColumn.ColumnType = result[1].ToString();
                    columns.Add(cmDBColumn);
                }

                _cache.Set($"GetTableColumns.{ccObject.Table}", columns, cacheEntryOptions);
            }
            return columns;
        }
    }
}
