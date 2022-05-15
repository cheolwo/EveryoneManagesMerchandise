using BusinessView.ofDTO.ofGroupOrder.ofPlatform;
using BusinessView.ofViewModels.ofGeneric;

namespace BusinessView.ofViewModels.ofWebApp.ofPlatform.ofGroupOrder.ofEGOC
{
    public class PlatformEGOCPageViewModel : StatusPageViewModel<PlatformEGOC> 
    {
        public readonly PlatformPostEGOCViewModel _PlatformPostEGOCViewModel;
        public readonly PlatformPutEGOCViewModel _PlatformPutEGOCViewModel;
        public readonly PlatformDeleteEGOCViewModel _PlatformDeleteEGOCViewModel;
        public readonly PlatformGetsEGOCViewModel _PlatformGetsEGOCViewModel;
        public PlatformEGOCPageViewModel(PlatformPostEGOCViewModel PlatformPostEGOCViewModel, 
                                        PlatformPutEGOCViewModel PlatformPutEGOCViewModel,
                                        PlatformDeleteEGOCViewModel PlatformDeleteEGOCViewModel,
                                        PlatformGetsEGOCViewModel PlatformGetsEGOCViewModel)
                :base(PlatformPostEGOCViewModel, PlatformPutEGOCViewModel, PlatformDeleteEGOCViewModel, PlatformGetsEGOCViewModel)
                    
        {
            _PlatformPostEGOCViewModel = PlatformPostEGOCViewModel;
            _PlatformPutEGOCViewModel = PlatformPutEGOCViewModel;
            _PlatformDeleteEGOCViewModel = PlatformDeleteEGOCViewModel;
            _PlatformGetsEGOCViewModel = PlatformGetsEGOCViewModel;
        }
    }
}