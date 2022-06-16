using BusinessData.ofPresentationLayer.ofDTO.ofGroupOrder.ofPlaform;
using BusinessView.ofViewModels.ofWebApp.ofGroupOrder.ofSGOC;

namespace BusinessView.ofViewModels.ofWebApp.ofPlatform.ofGroupOrder.ofSGOC
{
    public class PlatformSGOCPageViewModel : SGOCPageViewModel<PlatformSGOC> 
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