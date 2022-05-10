using BusinessView.ofDTO.ofOrder.ofPlatform;
using BusinessView.ofViewModels.ofGeneric;

namespace BusinessView.ofViewModels.ofWebApp.ofPlatform.ofOrder.ofMOCommodity
{
    public class PlatformMOCommodityPageViewModel : StatusPageViewModel<PlatformMOCommodity> 
    {
        public PlatformMOCommodityPageViewModel(PlatformPostMOCommodityViewModel PlatformPostMOCommodityViewModel, 
                                        PlatformPutMOCommodityViewModel PlatformPutMOCommodityViewModel,
                                        PlatformDeleteMOCommodityViewModel PlatformDeleteMOCommodityViewModel,
                                        PlatformGetsMOCommodityViewModel PlatformGetsMOCommodityViewModel)
                :base(PlatformPostMOCommodityViewModel, PlatformPutMOCommodityViewModel, PlatformDeleteMOCommodityViewModel, PlatformGetsMOCommodityViewModel)
                    
        {
            
        }
    }
}