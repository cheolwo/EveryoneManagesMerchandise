using BusinessView.ofDTO.ofMarket.ofPlatform;
using BusinessView.ofServices.ofCommon;
using BusinessView.ofViewModels.ofGeneric;
using BusinessLogic.ofExternal.ofSearchingService;
namespace BusinessView.ofViewModels.ofWebApp.ofPlatform.ofMarket.ofPlatMarket
{
    public class PlatformPlatMarketPageViewModel : CenterPageViewModel<PlatformPlatMarket> 
    {
        public readonly PlatformPostPlatMarketViewModel _PlatformPostPlatMarketViewModel;
        public readonly PlatformPutPlatMarketViewModel _PlatformPutPlatMarketViewModel;
        public readonly PlatformDeletePlatMarketViewModel _PlatformDeletePlatMarketViewModel;
        public readonly PlatformGetsPlatMarketViewModel _PlatformGetsPlatMarketViewModel;
        public PlatformPlatMarketPageViewModel(ICenterPageRoadAddressService centerPageRoadAddressService,
                                        ICenterPageTaxService centerPageTaxService,
                                        ICenterPageIdentityRoleService centerPageIdentityRoleService,
                                        PlatformPostPlatMarketViewModel PlatformPostPlatMarketViewModel, 
                                        PlatformPutPlatMarketViewModel PlatformPutPlatMarketViewModel,
                                        PlatformDeletePlatMarketViewModel PlatformDeletePlatMarketViewModel,
                                        PlatformGetsPlatMarketViewModel PlatformGetsPlatMarketViewModel)
                :base(centerPageRoadAddressService, centerPageTaxService, centerPageIdentityRoleService, PlatformPostPlatMarketViewModel, PlatformPutPlatMarketViewModel, PlatformDeletePlatMarketViewModel, PlatformGetsPlatMarketViewModel)
                    
        {
            _PlatformPostPlatMarketViewModel = PlatformPostPlatMarketViewModel;
            _PlatformPutPlatMarketViewModel = PlatformPutPlatMarketViewModel;
            _PlatformDeletePlatMarketViewModel = PlatformDeletePlatMarketViewModel;
            _PlatformGetsPlatMarketViewModel = PlatformGetsPlatMarketViewModel;
        }
    }
}