using BusinessView.ofDTO.ofProduct.ofPlatform;
using BusinessView.ofServices.ofCommon;
using BusinessView.ofViewModels.ofGeneric;

namespace BusinessView.ofViewModels.ofWebApp.ofPlatform.ofProduct.ofProducter
{
    public class PlatformProducterPageViewModel : CenterPageViewModel<PlatformProducter> 
    {
        public PlatformProducterPageViewModel(ICenterPageRoadAddressService centerPageRoadAddressService,
                                        ICenterPageTaxService centerPageTaxService,
                                        ICenterPageIdentityRoleService centerPageIdentityRoleService,
                                        PlatformPostProducterViewModel PlatformPostProducterViewModel, 
                                        PlatformPutProducterViewModel PlatformPutProducterViewModel,
                                        PlatformDeleteProducterViewModel PlatformDeleteProducterViewModel,
                                        PlatformGetsProducterViewModel PlatformGetsProducterViewModel)
                :base(centerPageRoadAddressService, centerPageTaxService, centerPageIdentityRoleService, PlatformPostProducterViewModel, PlatformPutProducterViewModel, PlatformDeleteProducterViewModel, PlatformGetsProducterViewModel)
                    
        {
            
        }
    }
}