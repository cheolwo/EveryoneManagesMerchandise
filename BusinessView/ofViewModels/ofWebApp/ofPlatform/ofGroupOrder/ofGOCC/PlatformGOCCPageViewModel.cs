using BusinessView.ofDTO.ofGroupOrder.ofPlatform;
using BusinessView.ofViewModels.ofGeneric;

namespace BusinessView.ofViewModels.ofWebApp.ofPlatform.ofGroupOrder.ofGOCC
{
    public class PlatformGOCCPageViewModel : CommodityPageViewModel<PlatformGOCC> 
    {
        public PlatformGOCCPageViewModel(PlatformPostGOCCViewModel PlatformPostGOCCViewModel, 
                                        PlatformPutGOCCViewModel PlatformPutGOCCViewModel,
                                        PlatformDeleteGOCCViewModel PlatformDeleteGOCCViewModel,
                                        PlatformGetsGOCCViewModel PlatformGetsGOCCViewModel)
                :base(PlatformPostGOCCViewModel, PlatformPutGOCCViewModel, PlatformDeleteGOCCViewModel, PlatformGetsGOCCViewModel)
                    
        {
            
        }
    }
}