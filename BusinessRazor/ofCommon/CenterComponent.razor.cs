using BusinessData;                          m
using BusinessLogic.ofManager.ofGeneric;
using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessRazor
{
    public class CenterValidator
    {
        public string Id { get; set; }
        public string Password { get; set; } // Hasg
    }
    // 되는지 안 되는지 한 번 해봐야겟는데... 이 부분은...
    // 지금으로서는 개인적인 생각에 Inject 라는 부분은 다 없어져야해.
    public partial class CenterComponent<TCenter> : ComponentBase where TCenter : Center, IRelationable
    {
        [Parameter] public ICenterManager<TCenter> _centerManager { get; set; }
        [Parameter] public ProtectedSessionStorage _protectedSesstionStorage { get; set; }
        [Parameter] public ProtectedLocalStorage _protectedLocalStorage { get; set; }
        [Parameter] public NavigationManager _navigationManager { get; set; }
        [CascadingParamenter] public UserComponent userComponent { get; set; }
        [Parameter] public RenderFragment ChildFragment { get; set; }
        [Parameter] public TCenter Center;
        private bool IsConnected = false;
        private bool IsSucceedLogin = false;
        private bool IsCurrentUser = false;
        
        protected override async Task OnAfterRenderAsync(bool firstRender)
        {
            if (firstRender)
            {
                // 상태저장소 접근
                Center = await _protectedSesstionStorage.GetAsync<TCenter>("Center");
                if (Center != null)
                {
                    IsCurrentUser = true;
                    var CenterValidator = await _protectedLocalStorage.GetAsync<CenterValidator>(Center.Id);
                    if (CenterValidator != null)
                    {
                        var IsLogin = await _centerManager.LoginByCryptPasswrodAsync(Center, CenterValidator.Id, CenterValidator.Password);
                        if (IsLogin)
                        {
                            await _protectedSesstionStorage.SetAsync<TCenter>(Center.Id, Center);
                            IsSucceedLogin = true;
                        };
                    }
                }
                // DB 접근
                else
                {
                    var user = userComponent.IdentityUser;
                    if (user != null)
                    {
                        Center = _centerManager.GetByUserAsync(user);
                        if (Center != null)
                        {
                            IsCurrentUser = true;
                            var CenterValidator = await _protectedLocalStorage.GetAsync<CenterValidator>(Center.Id);
                            if (CenterValidator != null)
                            {
                                var IsLogin = await _centerManager.LoginByCryptPasswrodAsync(Center, CenterValidator.Id, CenterValidator.Password);
                                if (IsLogin)
                                {
                                    await _protectedSesstionStorage.SetAsync<TCenter>(Center.Id, Center);
                                    IsSucceedLogin = true;
                                };
                            }
                        }
                    }
                }
                IsConnected = true;
                StateHasChanged();
            }
        }
        public async Task Lonin(string id, string password)
        {
            try
            {
                Center = await _centerManager.LoginAsync(id, password);
                if (Center != null) { IsSucceedLogin = true; }
            }
            catch
            {
                // Awesome
            }
            finally
            {
                await _protectedSesstionStorage.SetAsync<TCenter>(Center.Id, Center);
            }
        }
    }
    
    

}