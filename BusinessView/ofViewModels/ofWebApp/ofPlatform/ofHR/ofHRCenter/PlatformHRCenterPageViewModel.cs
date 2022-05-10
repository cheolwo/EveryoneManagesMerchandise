using BusinessView.ofDTO.ofHR.ofPlatform;
using BusinessView.ofServices.ofCommon;
using BusinessView.ofViewModels.ofGeneric;

namespace BusinessView.ofViewModels.ofWebApp.ofPlatform.ofHR.ofHRCenter
{
    public class PlatformHRCenterPageViewModel : CenterPageViewModel<PlatformHRCenter> 
    {
        public PlatformHRCenterPageViewModel(ICenterPageRoadAddressService centerPageRoadAddressService,
                                        ICenterPageTaxService centerPageTaxService,
                                        ICenterPageIdentityRoleService centerPageIdentityRoleService,
                                        PlatformPostHRCenterViewModel PlatformPostHRCenterViewModel, 
                                        PlatformPutHRCenterViewModel PlatformPutHRCenterViewModel,
                                        PlatformDeleteHRCenterViewModel PlatformDeleteHRCenterViewModel,
                                        PlatformGetsHRCenterViewModel PlatformGetsHRCenterViewModel)
                :base(centerPageRoadAddressService, centerPageTaxService, centerPageIdentityRoleService, PlatformPostHRCenterViewModel, PlatformPutHRCenterViewModel, PlatformDeleteHRCenterViewModel, PlatformGetsHRCenterViewModel)
                    
        {
            
        }
    }
}