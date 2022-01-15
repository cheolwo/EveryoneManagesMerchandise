﻿using BusinessLogic.ofManagement;
using BusinessLoogic.ofManager.ofKamis;
using Microsoft.AspNetCore.Components;

namespace PlatformManager.Pages
{
    public partial class KamisPriceInfo : ComponentBase
    {
        [Inject] public KamisRequestFactory KamisRequestFactory { get; set; }
        [Inject] public KamisAPIManager KamisAPIManager { get; set; }
        public HttpClient HttpClient { get; }
        protected override async Task OnInitializedAsync()
        {
            await KamisAPIManager.CollectPriceInfoToDbByGetAPI("2021-11-01", "2021-11-10");
        }
    }
}
