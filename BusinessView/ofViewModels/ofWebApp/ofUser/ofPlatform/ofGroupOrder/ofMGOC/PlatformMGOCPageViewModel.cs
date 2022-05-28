using BusinessView.ofDTO.ofGroupOrder.ofPlatform;
using BusinessView.ofViewModels.ofGeneric;
using BusinessView.ofViewModels.ofWebApp.ofGroupOrder.ofMGOC;

namespace BusinessView.ofViewModels.ofWebApp.ofPlatform.ofGroupOrder.ofMGOC
{
    public class PlatformMGOCPageViewModel : MGOCPageViewModel<PlatformMGOC> 
    {
        public readonly PlatformPostMGOCViewModel _PlatformPostMGOCViewModel;
        public readonly PlatformPutMGOCViewModel _PlatformPutMGOCViewModel;
        public readonly PlatformDeleteMGOCViewModel _PlatformDeleteMGOCViewModel;
        public readonly PlatformGetsMGOCViewModel _PlatformGetsMGOCViewModel;

        public PlatformMGOCPageViewModel(PlatformPostMGOCViewModel PlatformPostMGOCViewModel, 
                                        PlatformPutMGOCViewModel PlatformPutMGOCViewModel,
                                        PlatformDeleteMGOCViewModel PlatformDeleteMGOCViewModel,
                                        PlatformGetsMGOCViewModel PlatformGetsMGOCViewModel)
                :base(PlatformPostMGOCViewModel, PlatformPutMGOCViewModel, PlatformDeleteMGOCViewModel, PlatformGetsMGOCViewModel)
                    
        {
            _PlatformPostMGOCViewModel = PlatformPostMGOCViewModel;
            _PlatformPutMGOCViewModel = PlatformPutMGOCViewModel;
            _PlatformDeleteMGOCViewModel = PlatformDeleteMGOCViewModel;
            _PlatformGetsMGOCViewModel = PlatformGetsMGOCViewModel;
        }
    }
}