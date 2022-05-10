using BusinessView.ofServices.ofCommon;
using BusinessView.ofTrade.ofPlatform;
using BusinessView.ofViewModels.ofGeneric;

namespace BusinessView.ofViewModels.ofWebApp.ofPlatform.ofTrade.ofTradeCenter
{
    public class PlatformTradeCenterPageViewModel : CenterPageViewModel<PlatformTradeCenter> 
    {
        public PlatformTradeCenterPageViewModel(ICenterPageRoadAddressService centerPageRoadAddressService,
                                        ICenterPageTaxService centerPageTaxService,
                                        ICenterPageIdentityRoleService centerPageIdentityRoleService,
                                        PlatformPostTradeCenterViewModel PlatformPostTradeCenterViewModel, 
                                        PlatformPutTradeCenterViewModel PlatformPutTradeCenterViewModel,
                                        PlatformDeleteTradeCenterViewModel PlatformDeleteTradeCenterViewModel,
                                        PlatformGetsTradeCenterViewModel PlatformGetsTradeCenterViewModel)
                :base(centerPageRoadAddressService, centerPageTaxService, centerPageIdentityRoleService, PlatformPostTradeCenterViewModel, PlatformPutTradeCenterViewModel, PlatformDeleteTradeCenterViewModel, PlatformGetsTradeCenterViewModel)
                    
        {
            
        }
    }
}