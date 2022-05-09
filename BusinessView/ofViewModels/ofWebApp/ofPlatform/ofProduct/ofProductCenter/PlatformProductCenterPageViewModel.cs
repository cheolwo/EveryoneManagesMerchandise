using BusinessView.ofDTO.ofProduct.ofPlatform;
using BusinessView.ofServices.ofCommon;
using BusinessView.ofViewModels.ofGeneric;

namespace BusinessView.ofViewModels.ofWebApp.ofPlatform.ofProduct.ofProductCenter
{
    public class PlatformProductCenterPageViewModel : CenterPageViewModel<PlatformProductCenter> 
    {
        public PlatformProductCenterPageViewModel(ICenterPageRoadAddressService centerPageRoadAddressService,
                                        ICenterPageTaxService centerPageTaxService,
                                        ICenterPageIdentityRoleService centerPageIdentityRoleService,
                                        PlatformPostProductCenterViewModel PlatformPostProductCenterViewModel, 
                                        PlatformPutProductCenterViewModel PlatformPutProductCenterViewModel,
                                        PlatformDeleteProductCenterViewModel PlatformDeleteProductCenterViewModel,
                                        PlatformGetsProductCenterViewModel PlatformGetsProductCenterViewModel)
                :base(centerPageRoadAddressService, centerPageTaxService, centerPageIdentityRoleService, PlatformPostProductCenterViewModel, PlatformPutProductCenterViewModel, PlatformDeleteProductCenterViewModel, PlatformGetsProductCenterViewModel)
                    
        {
            
        }
    }
}