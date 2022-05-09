using BusinessView.ofTrade.ofPlatform;
using BusinessView.ofViewModels.ofGeneric;

namespace BusinessView.ofViewModels.ofWebApp.ofPlatform.ofTrade.ofTCommodity
{
    public class PlatformTCommodityPageViewModel : CommodityPageViewModel<PlatformTCommodity> 
    {
        public PlatformTCommodityPageViewModel(PlatformPostTCommodityViewModel PlatformPostTCommodityViewModel, 
                                        PlatformPutTCommodityViewModel PlatformPutTCommodityViewModel,
                                        PlatformDeleteTCommodityViewModel PlatformDeleteTCommodityViewModel,
                                        PlatformGetsTCommodityViewModel PlatformGetsTCommodityViewModel)
                :base(PlatformPostTCommodityViewModel, PlatformPutTCommodityViewModel, PlatformDeleteTCommodityViewModel, PlatformGetsTCommodityViewModel)
                    
        {
            
        }
    }
}