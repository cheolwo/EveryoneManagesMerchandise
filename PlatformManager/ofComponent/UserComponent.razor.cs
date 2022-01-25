using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Server.ProtectedBrowserStorage;
using Microsoft.AspNetCore.Identity;

namespace PlatformManager.ofComponent
{
    public partial class UserComponent : ComponentBase
    {
        [Inject] public UserManager<IdentityUser>? UserManager { get; set; }
        [Inject] public IHttpContextAccessor? HttpContextAccessor { get; set; }
        [Inject] public ProtectedLocalStorage? ProtectedLocalStorage { get; set; }
        public RenderFragment ?EntityFragment { get; set; }
        [Parameter] public string? Role { get; set; }
        public bool IsConnected { get; set; }
        public IdentityUser IdentityUser { get; set; }
        protected override async Task OnAfterRenderAsync(bool firstRender)
        {
            if (firstRender)
            {
                IdentityUser = await UserManager.GetUserAsync(HttpContextAccessor.HttpContext.User);
                if (IdentityUser != null)
                {
                    bool IsInRole = await UserManager.IsInRoleAsync(IdentityUser, Role);
                    if (!IsInRole) { throw new ArgumentException($"User don't have {Role}"); }
                    else
                    {
                        await ProtectedLocalStorage.SetAsync("IdentityUser", IdentityUser);
                    }
                }
                else
                {
                    IdentityUser = new();
                    IdentityUser.UserName = "Not Registered User";
                }
            }
            else
            {
                var result = await ProtectedLocalStorage.GetAsync<IdentityUser>("IdentityUser");
                if (result.Value != null)
                {
                    bool IsInRole = await UserManager.IsInRoleAsync(IdentityUser, Role);
                    if (!IsInRole)
                    {
                        // 역할등록하는 화면으로 이동
                        throw new ArgumentException($"User don't have {Role}");
                    }
                    IsConnected = true;
                    StateHasChanged();
                }
            }
        }
    }
}
