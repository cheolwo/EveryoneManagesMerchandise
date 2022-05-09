using BusinessView.ofDTO.ofGroupOrder.ofPlatform;
using BusinessView.ofViewModels.ofGeneric;

namespace BusinessView.ofViewModels.ofWebApp.ofPlatform.ofGroupOrder.ofSGOC
{
    public class PlatformSGOCPageViewModel : StatusPageViewModel<PlatformSGOC> 
    {
        public PlatformSGOCPageViewModel(PlatformPostSGOCViewModel PlatformPostSGOCViewModel, 
                                        PlatformPutSGOCViewModel PlatformPutSGOCViewModel,
                                        PlatformDeleteSGOCViewModel PlatformDeleteSGOCViewModel,
                                        PlatformGetsSGOCViewModel PlatformGetsSGOCViewModel)
                :base(PlatformPostSGOCViewModel, PlatformPutSGOCViewModel, PlatformDeleteSGOCViewModel, PlatformGetsSGOCViewModel)
                    
        {
            
        }
    }
}