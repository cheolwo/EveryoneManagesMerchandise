using BusinessView.ofDTO.ofHR.ofPlatform;
using BusinessView.ofViewModels.ofGeneric;

namespace BusinessView.ofViewModels.ofWebApp.ofPlatform.ofHR.ofHRBusinessPart
{
    public class PlatformHRBusinessPartPageViewModel : EntityPageViewModel<PlatformHRBusinessPart> 
    {
        public PlatformHRBusinessPartPageViewModel(PlatformPostHRBusinessPartViewModel PlatformPostHRBusinessPartViewModel, 
                                        PlatformPutHRBusinessPartViewModel PlatformPutHRBusinessPartViewModel,
                                        PlatformDeleteHRBusinessPartViewModel PlatformDeleteHRBusinessPartViewModel,
                                        PlatformGetsHRBusinessPartViewModel PlatformGetsHRBusinessPartViewModel)
                :base(PlatformPostHRBusinessPartViewModel, PlatformPutHRBusinessPartViewModel, PlatformDeleteHRBusinessPartViewModel, PlatformGetsHRBusinessPartViewModel)
                    
        {
            
        }
    }
}