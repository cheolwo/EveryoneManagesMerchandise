using BusinessView.ofTrade.ofPlatform;
using BusinessView.ofViewModels.ofGeneric;

namespace BusinessView.ofViewModels.ofWebApp.ofPlatform.ofTrade.ofMTCommodity
{
    public class PlatformMTCommodityPageViewModel : StatusPageViewModel<PlatformMTCommodity> 
    {
        public PlatformMTCommodityPageViewModel(PlatformPostMTCommodityViewModel PlatformPostMTCommodityViewModel, 
                                        PlatformPutMTCommodityViewModel PlatformPutMTCommodityViewModel,
                                        PlatformDeleteMTCommodityViewModel PlatformDeleteMTCommodityViewModel,
                                        PlatformGetsMTCommodityViewModel PlatformGetsMTCommodityViewModel)
                :base(PlatformPostMTCommodityViewModel, PlatformPutMTCommodityViewModel, PlatformDeleteMTCommodityViewModel, PlatformGetsMTCommodityViewModel)
                    
        {
            
        }
    }
}