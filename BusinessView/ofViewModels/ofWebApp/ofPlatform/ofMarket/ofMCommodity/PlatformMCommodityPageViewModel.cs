using BusinessView.ofDTO.ofMarket.ofPlatform;
using BusinessView.ofViewModels.ofGeneric;

namespace BusinessView.ofViewModels.ofWebApp.ofPlatform.ofMarket.ofMCommodity
{
    public class PlatformMCommodityPageViewModel : CommodityPageViewModel<PlatformMCommodity> 
    {
        public PlatformMCommodityPageViewModel(PlatformPostMCommodityViewModel PlatformPostMCommodityViewModel, 
                                        PlatformPutMCommodityViewModel PlatformPutMCommodityViewModel,
                                        PlatformDeleteMCommodityViewModel PlatformDeleteMCommodityViewModel,
                                        PlatformGetsMCommodityViewModel PlatformGetsMCommodityViewModel)
                :base(PlatformPostMCommodityViewModel, PlatformPutMCommodityViewModel, PlatformDeleteMCommodityViewModel, PlatformGetsMCommodityViewModel)
                    
        {
            
        }
    }
}