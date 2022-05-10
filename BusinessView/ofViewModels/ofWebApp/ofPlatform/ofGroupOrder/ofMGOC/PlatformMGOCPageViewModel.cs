using BusinessView.ofDTO.ofGroupOrder.ofPlatform;
using BusinessView.ofViewModels.ofGeneric;

namespace BusinessView.ofViewModels.ofWebApp.ofPlatform.ofGroupOrder.ofMGOC
{
    public class PlatformMGOCPageViewModel : StatusPageViewModel<PlatformMGOC> 
    {
        public PlatformMGOCPageViewModel(PlatformPostMGOCViewModel PlatformPostMGOCViewModel, 
                                        PlatformPutMGOCViewModel PlatformPutMGOCViewModel,
                                        PlatformDeleteMGOCViewModel PlatformDeleteMGOCViewModel,
                                        PlatformGetsMGOCViewModel PlatformGetsMGOCViewModel)
                :base(PlatformPostMGOCViewModel, PlatformPutMGOCViewModel, PlatformDeleteMGOCViewModel, PlatformGetsMGOCViewModel)
                    
        {
            
        }
    }
}