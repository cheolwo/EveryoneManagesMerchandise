using BusinessLogic.ofManagement;
using BusinessLoogic.ofManager.ofKamis;
using Microsoft.AspNetCore.Components;

namespace PlatformManager.Pages
{
    public partial class KamisPriceInfo : ComponentBase
    {
        [Inject] public KamisRequestFactory KamisRequestFactory { get; set; }
        [Inject] public KamisAPIManager KamisAPIManager { get; set; }
        [Inject] public KamisManagement KamisManagement { get; set; }
        public HttpClient HttpClient { get; }
        protected override async Task OnInitializedAsync()
        {
            await KamisManagement.SavePriceInfoToDb("2021-11-01", "2021-11-01");
        }
    }
}
