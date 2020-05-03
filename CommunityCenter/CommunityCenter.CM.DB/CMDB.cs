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
            string query = "select dbo.fn_rbac_GetAdminIDsfromUserSIDs(@userSids) as Result";
            Dictionary<string, object> Params = new Dictionary<string, object>();
            Params.Add("userSids", _user.GetSids());
            _cmUserSIDs = _ccSQL.ExecuteQuery(query, Params).Results[0][0].ToString();
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
        
    }
}
