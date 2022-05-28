using BusinessView.ofDTO.ofGroupOrder.ofPlatform;
using BusinessView.ofViewModels.ofGeneric;

namespace BusinessView.ofViewModels.ofWebApp.ofPlatform.ofGroupOrder.ofSGOC
{
    public class PlatformSGOCPageViewModel : StatusPageViewModel<PlatformSGOC> 
    {
        public readonly PlatformPostSGOCViewModel _PlatformPostSGOCViewModel;
        public readonly PlatformPutSGOCViewModel _PlatformPutSGOCViewModel;
        public readonly PlatformDeleteSGOCViewModel _PlatformDeleteSGOCViewModel;
        public readonly PlatformGetsSGOCViewModel _PlatformGetsSGOCViewModel;
        public PlatformSGOCPageViewModel(PlatformPostSGOCViewModel PlatformPostSGOCViewModel, 
                                        PlatformPutSGOCViewModel PlatformPutSGOCViewModel,
                                        PlatformDeleteSGOCViewModel PlatformDeleteSGOCViewModel,
                                        PlatformGetsSGOCViewModel PlatformGetsSGOCViewModel)
                :base(PlatformPostSGOCViewModel, PlatformPutSGOCViewModel, PlatformDeleteSGOCViewModel, PlatformGetsSGOCViewModel)
                    
        {
            _PlatformPostSGOCViewModel = PlatformPostSGOCViewModel;
            _PlatformPutSGOCViewModel = PlatformPutSGOCViewModel;
            _PlatformDeleteSGOCViewModel = PlatformDeleteSGOCViewModel;
            _PlatformGetsSGOCViewModel = PlatformGetsSGOCViewModel;
        }
    }
}