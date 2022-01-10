using Microsoft.AspNet.Identity;
using Microsoft.AspNetCore.Components;

namespace BusinessRazor
{
    public partial class UserComponent : ComponentBase
    {
        [Inject] public UserManager<IdentityUser> _userManager {get; set;}
        [Inject] public IHttpContextAccessor _httpContextAccessor {get; set;}
        [Inject] public ProtectedLocalStorage _protectedLocalStorage {get; set;}
        [Inject] public NavigationManager _navigationManager {get; set;}
        [Parameter] public RenderFragment RenderFragment {get; set;}
        [Parameter] public string Role {get; set;} 
        private bool isConnected {get; set;}
        public IdentityUser IdentityUser = new();
        // 비즈니스관리시스템 도면 : #UserComponent
        protected override async Task OnAfterRenderAsync(bool firstRender)
        {
            if(firstRender)
            {
                IdentityUser = await _protectedLocalStorage.GetAsync<IdentityUser>(IdentityUser.Id);
                if(IdentityUser != null)
                {
                    var IsInRole = await _userManager.IsInRoleAsync(identityUser, role);
                    if(!IsInRole) {_navigationManager.NavigateTo("/Create/{Role}");}
                }
                else
                {
                    IdentityUser = await _userManager.GetUserAsync(_httpContextAccessor.HttpContext.User);
                    if(IdentityUser != null)
                    {
                        _protectedLocalStorage.SetAsync(IdentityUser.Id, IdentityUser);
                        var IsInRole = _userManager.IsInRoleAsync(identityUser, role);
                        if(!IsInRole) {_navigationManager.NavigateTo("/Create/{Role}");}
                    }
                    else { _navigationManager.NavigateTo("/Create/User"); }
                    
                }
                isConnected = true;
                StateHasChanged();
            }
            else
            {
                IdentityUser = await _protectedLocalStorage.GetAsync<IdentityUser>(IdentityUser.Id);
            }
        }
    }
}