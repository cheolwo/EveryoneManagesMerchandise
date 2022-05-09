using BusinessView.ofDTO.ofMarket.ofPlatform;
using BusinessView.ofServices.ofCommon;
using BusinessView.ofViewModels.ofGeneric;

namespace BusinessView.ofViewModels.ofWebApp.ofPlatform.ofMarket.ofPlatMarket
{
    public class PlatformPlatMarketPageViewModel : CenterPageViewModel<PlatformPlatMarket> 
    {
        public PlatformPlatMarketPageViewModel(ICenterPageRoadAddressService centerPageRoadAddressService,
                                        ICenterPageTaxService centerPageTaxService,
                                        ICenterPageIdentityRoleService centerPageIdentityRoleService,
                                        PlatformPostPlatMarketViewModel PlatformPostPlatMarketViewModel, 
                                        PlatformPutPlatMarketViewModel PlatformPutPlatMarketViewModel,
                                        PlatformDeletePlatMarketViewModel PlatformDeletePlatMarketViewModel,
                                        PlatformGetsPlatMarketViewModel PlatformGetsPlatMarketViewModel)
                :base(centerPageRoadAddressService, centerPageTaxService, centerPageIdentityRoleService, PlatformPostPlatMarketViewModel, PlatformPutPlatMarketViewModel, PlatformDeletePlatMarketViewModel, PlatformGetsPlatMarketViewModel)
                    
        {
            
        }
    }
}