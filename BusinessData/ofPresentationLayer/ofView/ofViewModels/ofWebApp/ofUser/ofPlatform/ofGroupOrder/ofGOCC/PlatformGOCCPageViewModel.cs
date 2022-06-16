using BusinessData.ofPresentationLayer.ofDTO.ofGroupOrder.ofPlaform;
using BusinessView.ofViewModels.ofWebApp.ofGroupOrder.ofGOCC;

namespace BusinessView.ofViewModels.ofWebApp.ofPlatform.ofGroupOrder.ofGOCC
{
    public class PlatformGOCCPageViewModel : GOCCPageViewModel<PlatformGOCC> 
    {
        public readonly PlatformPostGOCCViewModel _PlatformPostGOCCViewModel;
        public readonly PlatformPutGOCCViewModel _PlatformPutGOCCViewModel;
        public readonly PlatformDeleteGOCCViewModel _PlatformDeleteGOCCViewModel;
        public readonly PlatformGetsGOCCViewModel _PlatformGetsGOCCViewModel;

        public PlatformGOCCPageViewModel(PlatformPostGOCCViewModel PlatformPostGOCCViewModel, 
                                        PlatformPutGOCCViewModel PlatformPutGOCCViewModel,
                                        PlatformDeleteGOCCViewModel PlatformDeleteGOCCViewModel,
                                        PlatformGetsGOCCViewModel PlatformGetsGOCCViewModel)
                :base(PlatformPostGOCCViewModel, PlatformPutGOCCViewModel, PlatformDeleteGOCCViewModel, PlatformGetsGOCCViewModel)
                    
        {
            _PlatformPostGOCCViewModel = PlatformPostGOCCViewModel;
            _PlatformPutGOCCViewModel = PlatformPutGOCCViewModel;
            _PlatformDeleteGOCCViewModel = PlatformDeleteGOCCViewModel;
            _PlatformGetsGOCCViewModel = PlatformGetsGOCCViewModel;
        }
    }
}