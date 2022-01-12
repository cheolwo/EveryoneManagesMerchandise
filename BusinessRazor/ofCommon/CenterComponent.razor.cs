//using BusinessData;
//using BusinessLogic.ofManager.ofGeneric;
//using BusinessRazor.ofCommon;
//using Microsoft.AspNetCore.Components;
//using ProtectedLocalStore;

//namespace BusinessRazor
//{
//    public class CenterValidator
//    {
//        public string Id { get; set; }
//        public string Password { get; set; } // Hasg
//        public CenterValidator(string Id, string Password)
//        {
//            this.Id = Id;
//            this.Password = Password;
//        }
//    }
//    // 비즈니스관리시스템 도면 : CenterCompoenent
//    public partial class CenterComponent<TCenter> : ComponentBase where TCenter : Center, IRelationable
//    {
//        [Inject] public ICenterManager<TCenter> CenterManager { get; set; } 
//        [Inject] public ProtectedLocalStorage ProtectedLocalStorage { get; set; }
//        [Inject] public NavigationManager NavigationManager { get; set; }
//        [CascadingParameter] public UserComponent UserComponent { get; set; }
//        [Parameter] public RenderFragment ChildFragment { get; set; }
//        [Parameter] public List<TCenter> Centers { get; set; }
//        public List<TCenter> CheckCenters = new(); 
//        public List<TCenter> NotCheckCenters = new(); 
//        private bool IsOpenLoginDialog = false;
//        protected override async Task OnAfterRenderAsync(bool firstRender)
//        {
//            // 주로 플랫폼 관리자가 해당 코드로 데이터를 로드
//            if (UserComponent is null)
//            {
//                Centers = await CenterManager.GetToListAsync();
//                await base.OnAfterRenderAsync(firstRender);
//            }
//            // 유저의 경우 해당 코드로 데이터를 로드
//            else
//            {
//                Centers = await CenterManager.GetToListByUserAsync(UserComponent.IdentityUser);
//                if (firstRender)
//                {
//                    if (Centers != null)
//                    {
//                        foreach (var Center in Centers)
//                        {
//                            var CenterValidator = await ProtectedLocalStorage.GetLocalAsync<CenterValidator>(Center.Id);
//                            if (CenterValidator != null) { CheckCenters.Add(Center); }
//                            else { NotCheckCenters.Add(Center); }
//                        }
//                    }
//                    else { NavigationManager.NavigateTo("/Create/{typeof(Center).Name}"); }
//                    StateHasChanged();
//                }
//            }
//        }
//        // Center Login Component 의 EventCallBack 함수로 이용
//        private async Task<bool> Login(FormofCenterLogin formofCenterLogin)
//        {
//            var Center = NotCheckCenters.FirstOrDefault(e => e.Id.Equals(formofCenterLogin.Id));
//            var ValidateCenter = await CenterManager.LoginAsync(formofCenterLogin.CenterLoginId, formofCenterLogin.CenterPassword);
//            if (ValidateCenter != null)
//            {
//                await ProtectedLocalStorage.SetLocalAsync(ValidateCenter.Id,  new CenterValidator(formofCenterLogin.CenterLoginId, formofCenterLogin.CenterPassword));
//                CheckCenters.Add(ValidateCenter);
//                NotCheckCenters.Remove(ValidateCenter);
//                return true;
//            }
//            return false;
//        }
//        // // Center Login Component 의 EventCallBack 함수로 이용
//        private void SwitchLoinDialog()
//        {
//            IsOpenLoginDialog = !IsOpenLoginDialog;
//        }
        
//    }
//}
