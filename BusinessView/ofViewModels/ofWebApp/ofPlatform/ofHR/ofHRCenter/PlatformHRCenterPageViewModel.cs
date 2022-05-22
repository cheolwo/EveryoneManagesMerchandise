using BusinessView.ofDTO.ofHR.ofPlatform;
using BusinessView.ofServices.ofCommon;
using BusinessView.ofViewModels.ofGeneric;
using BusinessLogic.ofExternal.ofSearchingService;
namespace BusinessView.ofViewModels.ofWebApp.ofPlatform.ofHR.ofHRCenter
{
    public class PlatformHRCenterPageViewModel : CenterPageViewModel<PlatformHRCenter> 
    {
        public readonly PlatformPostHRCenterViewModel _PlatformPostHRCenterViewModel;
        public readonly PlatformPutHRCenterViewModel _PlatformPutHRCenterViewModel;
        public readonly PlatformDeleteHRCenterViewModel _PlatformDeleteHRCenterViewModel;
        public readonly PlatformGetsHRCenterViewModel _PlatformGetsHRCenterViewModel;
        public PlatformHRCenterPageViewModel(ICenterPageRoadAddressService centerPageRoadAddressService,
                                        ICenterPageTaxService centerPageTaxService,
                                        ICenterPageIdentityRoleService centerPageIdentityRoleService,
                                        PlatformPostHRCenterViewModel PlatformPostHRCenterViewModel, 
                                        PlatformPutHRCenterViewModel PlatformPutHRCenterViewModel,
                                        PlatformDeleteHRCenterViewModel PlatformDeleteHRCenterViewModel,
                                        PlatformGetsHRCenterViewModel PlatformGetsHRCenterViewModel)
                :base(centerPageRoadAddressService, centerPageTaxService, centerPageIdentityRoleService, PlatformPostHRCenterViewModel, PlatformPutHRCenterViewModel, PlatformDeleteHRCenterViewModel, PlatformGetsHRCenterViewModel)
                    
        {
            _PlatformPostHRCenterViewModel = PlatformPostHRCenterViewModel;
            _PlatformPutHRCenterViewModel = PlatformPutHRCenterViewModel;
            _PlatformDeleteHRCenterViewModel = PlatformDeleteHRCenterViewModel;
            _PlatformGetsHRCenterViewModel = PlatformGetsHRCenterViewModel;
        }
    }
}