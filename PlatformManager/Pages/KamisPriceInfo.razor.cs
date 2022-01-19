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
        [Inject] public KamisWholeSalePriceManager KamisWholeSalePriceManager { get;  }
        public HttpClient HttpClient { get; }
        protected override async Task OnInitializedAsync()
        {
            var KamisWholeSale = KamisWholeSalePriceManager.FirstOrDefaultAsync();
            if(KamisWholeSale == null)
            {
                await KamisAPIManager.CollectPriceInfoFromAPI("2021-11-01", "2021-11-02");
            }
        }
    }
}
