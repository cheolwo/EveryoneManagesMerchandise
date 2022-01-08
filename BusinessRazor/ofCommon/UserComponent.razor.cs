namespace BusinessRazor
{
    public partial class UserComponent : ComponentBase
    {
        [Parameter] public UserManager<IdentityUser> _userManager {get; set;}
        [Parameter] public IHttpContextAccessor _httpContextAccessor {get; set;}
        [Parameter] public ProtectedLocalStorage _protectedLocalStorage {get; set;}
        [Parameter] public RenderFragment RenderFragment {get; set;}
        [Parameter] public string Role {get; set;} 
        private bool isConnected {get; set;}
        public IdentityUser IdentityUser = new();
        protected override async Task OnAfterRenderAsync(bool firstRender)
        {
            //IsInRoleAsync(TUser, String)
            if(firstRender)
            {
                IdentityUser = await _protectedLocalStorage.GetAsync<IdentityUser>(IdentityUser.Id);
                if(IdentityUser != null)
                {
                    _protectedLocalStorage.SetAsync(IdentityUser.Id, IdentityUser);
                }
                else
                {
                    IdentityUser = await _userManager.GetUserAsync(_httpContextAccessor.HttpContext.User);
                    if(IdentityUser != null)
                    {
                        _protectedLocalStorage.SetAsync(IdentityUser.Id, IdentityUser);
                    }
                    else { throw new ArgumentNullException("IdentityUser Is Null"); }
                }
                isConnected = true;
                StateHasChanged();
            }
        }
    }
}