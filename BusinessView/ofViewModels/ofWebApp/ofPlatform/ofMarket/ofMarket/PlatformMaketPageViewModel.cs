using BusinessView.ofDTO.ofMarket.ofPlatform;
using BusinessView.ofServices.ofCommon;
using BusinessView.ofViewModels.ofGeneric;

namespace BusinessView.ofViewModels.ofWebApp.ofPlatform.ofMarket.ofMarket
{
    public class PlatformMarketPageViewModel : CenterPageViewModel<PlatformMarket> 
    {
        public readonly PlatformPostMarketViewModel _PlatformPostMarketViewModel;
        public readonly PlatformPutMarketViewModel _PlatformPutMarketViewModel;
        public readonly PlatformDeleteMarketViewModel _PlatformDeleteMarketViewModel;
        public readonly PlatformGetsMarketViewModel _PlatformGetsMarketViewModel;
        public PlatformMarketPageViewModel(ICenterPageRoadAddressService centerPageRoadAddressService,
                                        ICenterPageTaxService centerPageTaxService,
                                        ICenterPageIdentityRoleService centerPageIdentityRoleService,
                                        PlatformPostMarketViewModel PlatformPostMarketViewModel, 
                                        PlatformPutMarketViewModel PlatformPutMarketViewModel,
                                        PlatformDeleteMarketViewModel PlatformDeleteMarketViewModel,
                                        PlatformGetsMarketViewModel PlatformGetsMarketViewModel)
                :base(centerPageRoadAddressService, centerPageTaxService, centerPageIdentityRoleService, PlatformPostMarketViewModel, PlatformPutMarketViewModel, PlatformDeleteMarketViewModel, PlatformGetsMarketViewModel)
                    
        {
            _PlatformPostMarketViewModel = PlatformPostMarketViewModel;
            _PlatformPutMarketViewModel = PlatformPutMarketViewModel;
            _PlatformDeleteMarketViewModel = PlatformDeleteMarketViewModel;
            _PlatformGetsMarketViewModel = PlatformGetsMarketViewModel;
        }
    }
}