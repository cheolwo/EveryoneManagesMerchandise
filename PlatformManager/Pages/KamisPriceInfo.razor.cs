using BusinessLogic.ofManagement;
using BusinessLoogic.ofManager.ofKamis;
using Microsoft.AspNetCore.Components;

namespace PlatformManager.Pages
{
    public partial class KamisPriceInfo : ComponentBase
    {
        [Inject] public KamisRequestFactory ?KamisRequestFactory { get; set; }
        [Inject] public KamisAPIManager ?KamisAPIManager { get; set; }
        [Inject] public KamisManagement ?KamisManagement { get; set; }
        [Inject] public KamisWholeSalePriceManager ?KamisWholeSalePriceManager { get; set; }
        public HttpClient HttpClient { get; }
        protected override async Task OnInitializedAsync()
        {
#pragma warning disable CS8602 // null 가능 참조에 대한 역참조입니다.
            var KamisWholeSale = await KamisWholeSalePriceManager.FirstOrDefaultAsync();
#pragma warning restore CS8602 // null 가능 참조에 대한 역참조입니다.
            if (KamisWholeSale == null)
            {
                await KamisAPIManager.CollectPriceInfoFromAPI("2021-11-01", "2021-11-02");
            }
        }
    }
}
