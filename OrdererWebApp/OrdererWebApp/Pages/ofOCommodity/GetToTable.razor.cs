// 이론 상으로는 CallBack 이랑 사용자 옵션의 경우를
// RCL 의 넘겨서 처리하는 게 가능하긴해.
// List의 경우를 넘겨서 처리하는 거잖아.
// Component 부분에서는 Manager 및 Repositroy 계층의 모듈이 
// 나오지 않는 쪽으로 만들어졌으면 좋겟어.
// 그럼 또 Service 를 부모개체로 하는 하위 개체를 만들어서
// 사전신경계에서 데이터 처리가 이루어질 수 있도록 한다?
// Add, Update, Delete, Get 
namespace OrdererWebApp.Pages.ofOCommodity
{
    public partial class GetToTable : ComponentBase
    {
        [Inject] public UserManager<IdentityUser> _userManager {get; set;}
        [Inject] public OrdererService _ordererService {get; set; }
        public List<OCommodity> oCommodities = new();
        protected override async Task OnInitializedAsync()
        {
            oCommodities = await _ordererService.GetToListofOCommoditiy();
        }
        
    }
}