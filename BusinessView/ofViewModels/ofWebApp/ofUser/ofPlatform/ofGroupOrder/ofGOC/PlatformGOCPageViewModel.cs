using BusinessView.ofDTO.ofGroupOrder.ofPlatform;
using BusinessView.ofViewModels.ofGeneric;
using BusinessView.ofViewModels.ofWebApp.ofGroupOrder.ofGOC;

namespace BusinessView.ofViewModels.ofWebApp.ofPlatform.ofGroupOrder.ofGOC
{
    public class PlatformGOCPageViewModel : GOCPageViewModel<PlatformGOC> 
    {
        public readonly PlatformPostGOCViewModel _PlatformPostGOCViewModel;
        public readonly PlatformPutGOCViewModel _PlatformPutGOCViewModel;
        public readonly PlatformDeleteGOCViewModel _PlatformDeleteGOCViewModel;
        public readonly PlatformGetsGOCViewModel _PlatformGetsGOCViewModel;

        public PlatformGOCPageViewModel(PlatformPostGOCViewModel PlatformPostGOCViewModel, 
                                        PlatformPutGOCViewModel PlatformPutGOCViewModel,
                                        PlatformDeleteGOCViewModel PlatformDeleteGOCViewModel,
                                        PlatformGetsGOCViewModel PlatformGetsGOCViewModel)
                :base(PlatformPostGOCViewModel, PlatformPutGOCViewModel, PlatformDeleteGOCViewModel, PlatformGetsGOCViewModel)
                    
        {
            _PlatformPostGOCViewModel = PlatformPostGOCViewModel;
            _PlatformPutGOCViewModel = PlatformPutGOCViewModel;
            _PlatformDeleteGOCViewModel = PlatformDeleteGOCViewModel;
            _PlatformGetsGOCViewModel = PlatformGetsGOCViewModel;
        }
    }
}