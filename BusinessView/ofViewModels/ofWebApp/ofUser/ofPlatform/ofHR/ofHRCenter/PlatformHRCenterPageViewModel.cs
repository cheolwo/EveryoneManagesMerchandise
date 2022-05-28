using BusinessView.ofDTO.ofHR.ofPlatform;
using BusinessView.ofViewModels.ofGeneric;
using BusinessView.ofViewModels.ofWebApp.ofHR.ofHRCenter;

namespace BusinessView.ofViewModels.ofWebApp.ofPlatform.ofHR.ofHRCenter
{
    public class PlatformHRCenterPageViewModel : HRCenterPageViewModel<PlatformHRCenter> 
    {
        public readonly PlatformPostHRCenterViewModel _PlatformPostHRCenterViewModel;
        public readonly PlatformPutHRCenterViewModel _PlatformPutHRCenterViewModel;
        public readonly PlatformDeleteHRCenterViewModel _PlatformDeleteHRCenterViewModel;
        public readonly PlatformGetsHRCenterViewModel _PlatformGetsHRCenterViewModel;

        public PlatformHRCenterPageViewModel(PlatformPostHRCenterViewModel PlatformPostHRCenterViewModel, 
                                        PlatformPutHRCenterViewModel PlatformPutHRCenterViewModel,
                                        PlatformDeleteHRCenterViewModel PlatformDeleteHRCenterViewModel,
                                        PlatformGetsHRCenterViewModel PlatformGetsHRCenterViewModel)
                :base(PlatformPostHRCenterViewModel, PlatformPutHRCenterViewModel, PlatformDeleteHRCenterViewModel, PlatformGetsHRCenterViewModel)
                    
        {
            _PlatformPostHRCenterViewModel = PlatformPostHRCenterViewModel;
            _PlatformPutHRCenterViewModel = PlatformPutHRCenterViewModel;
            _PlatformDeleteHRCenterViewModel = PlatformDeleteHRCenterViewModel;
            _PlatformGetsHRCenterViewModel = PlatformGetsHRCenterViewModel;
        }
    }
}