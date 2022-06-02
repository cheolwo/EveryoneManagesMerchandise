using BusinessData.ofPresentationLayer.ofDTO.ofWarehouse.ofPlatform;
using BusinessView.ofViewModels.ofWebApp.ofWarehouse.ofIncomingTag;

namespace BusinessView.ofViewModels.ofWebApp.ofPlatform.ofWarehouse.ofIncomingTag
{
    public class PlatformIncomingTagPageViewModel : IncomingTagPageViewModel<PlatformIncomingTag> 
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