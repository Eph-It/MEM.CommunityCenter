using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CommunityCenter.CM.DB;
using CommunityCenter.Models.RBAC;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CommunityCenter.WebAPI.Server.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class DevicesController : ControllerBase
    {
        private CMDBContext _dbContext;
        public DevicesController(CMDBContext dbContext)
        {
            _dbContext = dbContext;
        }
        public List<fn_rbac_CombinedDeviceResources> GetDevices()
        {
            return _dbContext.GetRBACResults<fn_rbac_CombinedDeviceResources>().Take(10).ToList();
        }
    }
}