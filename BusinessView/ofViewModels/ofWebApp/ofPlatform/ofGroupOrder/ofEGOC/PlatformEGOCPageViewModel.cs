using BusinessView.ofDTO.ofGroupOrder.ofPlatform;
using BusinessView.ofViewModels.ofGeneric;

namespace BusinessView.ofViewModels.ofWebApp.ofPlatform.ofGroupOrder.ofEGOC
{
    public class PlatformEGOCPageViewModel : StatusPageViewModel<PlatformEGOC> 
    {
        public PlatformEGOCPageViewModel(PlatformPostEGOCViewModel PlatformPostEGOCViewModel, 
                                        PlatformPutEGOCViewModel PlatformPutEGOCViewModel,
                                        PlatformDeleteEGOCViewModel PlatformDeleteEGOCViewModel,
                                        PlatformGetsEGOCViewModel PlatformGetsEGOCViewModel)
                :base(PlatformPostEGOCViewModel, PlatformPutEGOCViewModel, PlatformDeleteEGOCViewModel, PlatformGetsEGOCViewModel)
                    
        {
            
        }
    }
}