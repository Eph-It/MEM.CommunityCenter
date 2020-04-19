using CommunityCenter.Models.CM.Device;
using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CommunityCenter.CM.Client;
using MatBlazor;
using Simple.OData.Client;
using Microsoft.AspNetCore.Components.Authorization;
using System.Security.Claims;
using CommunityCenter.CM.DB;
using Microsoft.EntityFrameworkCore;
using CommunityCenter.CM.DB.Models;

namespace CommunityCenter.UI.Pages
{
    public class DevicesBase : ComponentBase
    {
        protected fn_rbac_CombinedDeviceResources[] res = null;
        protected fn_rbac_CombinedDeviceResources[] fakeRes = null;
        public bool load = false;
        public bool snackBarIsOpen = true;
        public int pageSize = 5;
        public int pageIndex = 0;
        public int pageLength = 0;
        public IEnumerable<Claim> _claims = Enumerable.Empty<Claim>();

        [Inject] CMClient client { get; set; }
        [Inject] AuthenticationStateProvider AuthenticationStateProvider { get; set; }
        [Inject] CMDBContext dbContext { get; set; }
        protected override async Task OnInitializedAsync()
        {
            pageLength = dbContext.GetRBACResults<fn_rbac_CombinedDeviceResources>().Count();
            res = await dbContext.GetRBACResults<fn_rbac_CombinedDeviceResources>().OrderBy(p => p.MachineID).Take(pageSize).ToArrayAsync();
            snackBarIsOpen = false;
        }
        protected async Task OnPageAsync(MatPaginatorPageEvent e)
        {
            snackBarIsOpen = true;
            pageSize = e.PageSize;
            res = await dbContext.GetRBACResults<fn_rbac_CombinedDeviceResources>().OrderBy(p => p.MachineID).Skip(e.PageSize * e.PageIndex).Take(pageSize).ToArrayAsync();
            snackBarIsOpen = false;
        }
    }
}
