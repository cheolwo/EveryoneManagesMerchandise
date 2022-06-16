using BusinessData.ofPresentationLayer.ofDTO.ofHR.ofPlatform;
using BusinessView.ofViewModels.ofWebApp.ofHR.ofHRBusinessPart;

namespace BusinessView.ofViewModels.ofWebApp.ofPlatform.ofHR.ofHRBusinessPart
{
    public class PlatformHRBusinessPartPageViewModel : HRBusinessPartPageViewModel<PlatformHRBusinessPart> 
    {
        public readonly PlatformPostHRBusinessPartViewModel _PlatformPostHRBusinessPartViewModel;
        public readonly PlatformPutHRBusinessPartViewModel _PlatformPutHRBusinessPartViewModel;
        public readonly PlatformDeleteHRBusinessPartViewModel _PlatformDeleteHRBusinessPartViewModel;
        public readonly PlatformGetsHRBusinessPartViewModel _PlatformGetsHRBusinessPartViewModel;

        public PlatformHRBusinessPartPageViewModel(PlatformPostHRBusinessPartViewModel PlatformPostHRBusinessPartViewModel, 
                                        PlatformPutHRBusinessPartViewModel PlatformPutHRBusinessPartViewModel,
                                        PlatformDeleteHRBusinessPartViewModel PlatformDeleteHRBusinessPartViewModel,
                                        PlatformGetsHRBusinessPartViewModel PlatformGetsHRBusinessPartViewModel)
                :base(PlatformPostHRBusinessPartViewModel, PlatformPutHRBusinessPartViewModel, PlatformDeleteHRBusinessPartViewModel, PlatformGetsHRBusinessPartViewModel)
                    
        {
            _PlatformPostHRBusinessPartViewModel = PlatformPostHRBusinessPartViewModel;
            _PlatformPutHRBusinessPartViewModel = PlatformPutHRBusinessPartViewModel;
            _PlatformDeleteHRBusinessPartViewModel = PlatformDeleteHRBusinessPartViewModel;
            _PlatformGetsHRBusinessPartViewModel = PlatformGetsHRBusinessPartViewModel;
        }
    }
}