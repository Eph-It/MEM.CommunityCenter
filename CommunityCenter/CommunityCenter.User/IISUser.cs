using Microsoft.AspNetCore.Components.Authorization;

namespace CommunityCenter.User
{
    public class IISUser : ICCUser
    {
        private AuthenticationStateProvider _authState;
        public IISUser(AuthenticationStateProvider AuthStateProvider)
        {
            _authState = AuthStateProvider;
        }
        public string GetSids()
        {
            string returnString = "";
            var authStateTask = _authState.GetAuthenticationStateAsync();
            authStateTask.Wait();
            var authState = authStateTask.Result;
            foreach(var claim in authState.User.Claims)
            {
                if (claim.Type.Contains("SID"))
                {
                    returnString += claim.Value + ",";
                }
            }
            return returnString.TrimEnd(',');
        }
    }
}
