using BusinessView.ofDTO.ofWarehouse.ofPlatform;
using BusinessView.ofViewModels.ofGeneric;

namespace BusinessView.ofViewModels.ofWebApp.ofPlatform.ofWarehouse.ofIncomingTag
{
    public class PlatformIncomingTagPageViewModel : EntityPageViewModel<PlatformIncomingTag> 
    {
        public readonly PlatformPostIncomingTagViewModel _PlatformPostIncomingTagViewModel;
        public readonly PlatformPutIncomingTagViewModel _PlatformPutIncomingTagViewModel;
        public readonly PlatformDeleteIncomingTagViewModel _PlatformDeleteIncomingTagViewModel;
        public readonly PlatformGetsIncomingTagViewModel _PlatformGetsIncomingTagViewModel;
        public PlatformIncomingTagPageViewModel(PlatformPostIncomingTagViewModel PlatformPostIncomingTagViewModel, 
                                        PlatformPutIncomingTagViewModel PlatformPutIncomingTagViewModel,
                                        PlatformDeleteIncomingTagViewModel PlatformDeleteIncomingTagViewModel,
                                        PlatformGetsIncomingTagViewModel PlatformGetsIncomingTagViewModel)
                :base(PlatformPostIncomingTagViewModel, PlatformPutIncomingTagViewModel, PlatformDeleteIncomingTagViewModel, PlatformGetsIncomingTagViewModel)
                    
        {
            _PlatformPostIncomingTagViewModel = PlatformPostIncomingTagViewModel;
            _PlatformPutIncomingTagViewModel = PlatformPutIncomingTagViewModel;
            _PlatformDeleteIncomingTagViewModel = PlatformDeleteIncomingTagViewModel;
            _PlatformGetsIncomingTagViewModel = PlatformGetsIncomingTagViewModel;
        }
    }
}