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
        [Inject] public NavigationManager? NavigationManager { get; set; }
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
                    var result = await ProtectedLocalStorage.GetAsync<IdentityUser>("IdentiyUser");
                    if (result.Value == null)
                    {
                        await ProtectedLocalStorage.SetAsync("IdentityUser", IdentityUser);
                    }
                    IsConnected = true;
                    StateHasChanged();
                }
                else
                {
                    NavigationManager.NavigateTo("/Login");
                }
            }
            else
            {
                var result = await ProtectedLocalStorage.GetAsync<IdentityUser>("IdentityUser");
                if (result.Value != null)
                {
                    IdentityUser = result.Value;
                    IsConnected = true;
                    StateHasChanged();
                }
                else
				{
                    IdentityUser = await UserManager.GetUserAsync(HttpContextAccessor.HttpContext.User);
                    await ProtectedLocalStorage.SetAsync("IdentityUser", IdentityUser);
                    IsConnected = true;
                    StateHasChanged();
                }
            }
        }
    }
}
