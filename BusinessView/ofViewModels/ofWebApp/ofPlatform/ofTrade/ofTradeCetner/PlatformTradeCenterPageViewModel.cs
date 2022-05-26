using BusinessView.ofExternal.ofSearchingService;
using BusinessView.ofServices.ofCommon;
using BusinessView.ofTrade.ofPlatform;
using BusinessView.ofViewModels.ofGeneric;

namespace BusinessView.ofViewModels.ofWebApp.ofPlatform.ofTrade.ofTradeCenter
{
    public class PlatformTradeCenterPageViewModel : CenterPageViewModel<PlatformTradeCenter> 
    {
        public readonly PlatformPostTradeCenterViewModel _PlatformPostTradeCenterViewModel;
        public readonly PlatformPutTradeCenterViewModel _PlatformPutTradeCenterViewModel;
        public readonly PlatformDeleteTradeCenterViewModel _PlatformDeleteTradeCenterViewModel;
        public readonly PlatformGetsTradeCenterViewModel _PlatformGetsTradeCenterViewModel;
        public PlatformTradeCenterPageViewModel(ICenterPageRoadAddressService centerPageRoadAddressService,
                                        ICenterPageTaxService centerPageTaxService,
                                        ICenterPageIdentityRoleService centerPageIdentityRoleService,
                                        PlatformPostTradeCenterViewModel PlatformPostTradeCenterViewModel, 
                                        PlatformPutTradeCenterViewModel PlatformPutTradeCenterViewModel,
                                        PlatformDeleteTradeCenterViewModel PlatformDeleteTradeCenterViewModel,
                                        PlatformGetsTradeCenterViewModel PlatformGetsTradeCenterViewModel)
                :base(centerPageRoadAddressService, centerPageTaxService, centerPageIdentityRoleService, PlatformPostTradeCenterViewModel, PlatformPutTradeCenterViewModel, PlatformDeleteTradeCenterViewModel, PlatformGetsTradeCenterViewModel)
                    
        {
            _PlatformPostTradeCenterViewModel = PlatformPostTradeCenterViewModel;
            _PlatformPutTradeCenterViewModel = PlatformPutTradeCenterViewModel;
            _PlatformDeleteTradeCenterViewModel = PlatformDeleteTradeCenterViewModel;
            _PlatformGetsTradeCenterViewModel = PlatformGetsTradeCenterViewModel;
        }
    }
}