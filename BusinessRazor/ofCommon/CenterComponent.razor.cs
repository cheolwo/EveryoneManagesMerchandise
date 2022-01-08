using BusinessData;
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
        public CenterValidator(string Id, string Password)
        {
            this.Id = Id;
            this.Password = Password;
        }
    }
    // 비즈니스관리시스템 도면 : CenterCompoenent
    public partial class CenterComponent<TCenter> : ComponentBase where TCenter : Center, IRelationable
    {
        [Inject] public ICenterManager<TCenter> _centerManager { get; set; } 
        [Inject] public ProtectedLocalStorage _protectedLocalStorage { get; set; }
        [Inject] public NavigationManager _navigationManager { get; set; }
        [CascadingParamenter] public UserComponent userComponent { get; set; }
        [Parameter] public RenderFragment ChildFragment { get; set; }
        [Parameter] public List<TCenter> Centers { get; set; }
        public List<TCenter> CheckCenters = new(); 
        public List<TCenter> NotCheckCenters = new(); 
        private bool IsOpenLoginDialog = false;
        private bool IsConnected = false;
        protected override async Task OnAfterRenderAsync(bool firstRender)
        {
            // 주로 플랫폼 관리자가 해당 코드로 데이터를 로드
            if (userComponent is null)
            {
                Centers = await _centerManager.GetToListAsync();
                return base.OnAfterRenderAsync(firstRender);
            }
            // 유저의 경우 해당 코드로 데이터를 로드
            else
            {
                Centers = await _centerManager.GetToListByUserAsync(userComponent.IdentityUser);
                if (firstRender)
                {
                    if (Centers != null)
                    {
                        foreach (var Center in Centers)
                        {
                            var CenterValidator = await _protectedLocalStorage.GetAsync<CenterValidator>(Center.Id);
                            if (CenterValidator != null) { CheckCenters.Add(Center); }
                            else { NotCheckCenters.Add(Center); }
                        }
                    }
                    else { _navigationManager.NavigateTo("/Create/{typeof(Center).Name}"); }
                    IsConnected = true;
                    StateHasChanged();
                }
            }
        }
        // Center Login Component 의 EventCallBack 함수로 이용
        private void Lonin(FormofCenterLogin formofCenterLogin)
        {
            var Center = NotCheckCenters.FirstOrDefault(e => e.Id.Equals(formofCenterLogin.Id));
            bool IsValidate = _centerManager.LoginCheck(Center, 
                                    formofCenterLogin.CenterLoginId, formofCenterLogin.CenterPassword);
            if (IsValidate)
            {
                _protectedLocalStorage.SetAsync<CenterValidator>(Id, 
                new CenterValidator(formofCenterLogin.CenterLoginId, formofCenterLogin.CenterPassword));
                CheckCenters.Add(Center);
                NotCheckCenters.Remove(Center);
                return IsValidate;
            }
            return IsValidate;
        }
        // // Center Login Component 의 EventCallBack 함수로 이용
        private void SwitchLoinDialog()
        {
            IsOpenLoginDialog = !IsOpenLoginDialog;
        }
        
    }
}
