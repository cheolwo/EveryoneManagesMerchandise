using BusinessLoogic.ofManager.ofKamis;
using Microsoft.AspNetCore.Components;

namespace PlatformManager.Pages
{
    public partial class KamisPriceInfo : ComponentBase
    {
        [Inject] public KamisRequestFactory KamisRequestFactory { get; set; }
        protected override async Task OnInitializedAsync()
        {
            await KamisRequestFactory.CreateRequestMessage("2021-11-1", "2021-11-10");
        }
    }
}
