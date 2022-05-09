using BusinessView.ofDTO.ofOrder.ofPlatform;
using BusinessView.ofServices.ofCommon;
using BusinessView.ofViewModels.ofGeneric;

namespace BusinessView.ofViewModels.ofWebApp.ofPlatform.ofOrder.ofOrderCenter
{
    public class PlatformOrderCenterPageViewModel : CenterPageViewModel<PlatformOrderCenter> 
    {
        public PlatformOrderCenterPageViewModel(ICenterPageRoadAddressService centerPageRoadAddressService,
                                        ICenterPageTaxService centerPageTaxService,
                                        ICenterPageIdentityRoleService centerPageIdentityRoleService,
                                        PlatformPostOrderCenterViewModel PlatformPostOrderCenterViewModel, 
                                        PlatformPutOrderCenterViewModel PlatformPutOrderCenterViewModel,
                                        PlatformDeleteOrderCenterViewModel PlatformDeleteOrderCenterViewModel,
                                        PlatformGetsOrderCenterViewModel PlatformGetsOrderCenterViewModel)
                :base(centerPageRoadAddressService, centerPageTaxService, centerPageIdentityRoleService, PlatformPostOrderCenterViewModel, PlatformPutOrderCenterViewModel, PlatformDeleteOrderCenterViewModel, PlatformGetsOrderCenterViewModel)
                    
        {
            
        }
    }
}