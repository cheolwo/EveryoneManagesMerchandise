using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Server.ProtectedBrowserStorage;
using Microsoft.AspNetCore.Identity;

namespace ProducterWebApp.Pages.ofGeneric
{
    public partial class UserComponent : ComponentBase
    {
        [Parameter] public UserManager<IdentityUser> _userManager { get; set; }
        [Parameter] public IHttpContextAccessor _httpContextAccessor { get; set; }
        [Parameter] public ProtectedLocalStorage _protectedLocalStorage { get; set; }
        [Parameter] public RenderFragment EntityFragment { get; set; }
        [Parameter] public string Role { get; set; }
        private bool isConnected { get; set; }
        public IdentityUser IdentityUser = new();
        protected override async Task OnAfterRenderAsync(bool firstRender)
        {
            //IsInRoleAsync(TUser, String)
            if (firstRender)
            {
                var result = await _protectedLocalStorage.GetAsync<IdentityUser>("IdentityUser");
                if(result.Value != null)
                {
                    bool IsInRole = await _userManager.IsInRoleAsync(IdentityUser, Role);
                    if (!IsInRole) { throw new ArgumentException($"User don't have {Role}"); }
                }
                else
                {
                    IdentityUser = await _userManager.GetUserAsync(_httpContextAccessor.HttpContext.User);
                    if (IdentityUser != null)
                    {
                        bool IsInRole = await _userManager.IsInRoleAsync(IdentityUser, Role);
                        if (!IsInRole) { throw new ArgumentException($"User don't have {Role}"); }
                        else
                        {
                            await _protectedLocalStorage.SetAsync("IdentityUser", IdentityUser);
                        }
                    }
                }
                isConnected = true;
                StateHasChanged();
            }
        }
    }
}
