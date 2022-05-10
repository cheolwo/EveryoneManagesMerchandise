using BusinessView.ofDTO.ofWarehouse.ofPlatform;
using BusinessView.ofViewModels.ofGeneric;

namespace BusinessView.ofViewModels.ofWebApp.ofPlatform.ofWarehouse.ofIncomingTag
{
    public class PlatformIncomingTagPageViewModel : EntityPageViewModel<PlatformIncomingTag> 
    {
        public PlatformIncomingTagPageViewModel(PlatformPostIncomingTagViewModel PlatformPostIncomingTagViewModel, 
                                        PlatformPutIncomingTagViewModel PlatformPutIncomingTagViewModel,
                                        PlatformDeleteIncomingTagViewModel PlatformDeleteIncomingTagViewModel,
                                        PlatformGetsIncomingTagViewModel PlatformGetsIncomingTagViewModel)
                :base(PlatformPostIncomingTagViewModel, PlatformPutIncomingTagViewModel, PlatformDeleteIncomingTagViewModel, PlatformGetsIncomingTagViewModel)
                    
        {
            
        }
    }
}