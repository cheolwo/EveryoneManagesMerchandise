using BusinessView.ofDTO.ofHR.ofPlatform;
using BusinessView.ofViewModels.ofGeneric;

namespace BusinessView.ofViewModels.ofWebApp.ofPlatform.ofHR.ofHRBusinessPart
{
    public class PlatformHRBusinessPartPageViewModel : EntityPageViewModel<PlatformHRBusinessPart> 
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