using BusinessView.ofDTO.ofWarehouse.ofPlatform;
using BusinessView.ofViewModels.ofGeneric;

namespace BusinessView.ofViewModels.ofWebApp.ofPlatform.ofWarehouse.ofLoadFrame
{
    public class PlatformLoadFramePageViewModel : EntityPageViewModel<PlatformLoadFrame> 
    {
        public PlatformLoadFramePageViewModel(PlatformPostLoadFrameViewModel PlatformPostLoadFrameViewModel, 
                                        PlatformPutLoadFrameViewModel PlatformPutLoadFrameViewModel,
                                        PlatformDeleteLoadFrameViewModel PlatformDeleteLoadFrameViewModel,
                                        PlatformGetsLoadFrameViewModel PlatformGetsLoadFrameViewModel)
                :base(PlatformPostLoadFrameViewModel, PlatformPutLoadFrameViewModel, PlatformDeleteLoadFrameViewModel, PlatformGetsLoadFrameViewModel)
                    
        {
            
        }
    }
}