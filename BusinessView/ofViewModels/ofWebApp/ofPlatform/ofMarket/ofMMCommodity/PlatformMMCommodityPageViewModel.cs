using BusinessView.ofDTO.ofMarket.ofPlatform;
using BusinessView.ofViewModels.ofGeneric;

namespace BusinessView.ofViewModels.ofWebApp.ofPlatform.ofMarket.ofMMCommodity
{
    public class PlatformMMCommodityPageViewModel : StatusPageViewModel<PlatformMMCommodity> 
    {
        public PlatformMMCommodityPageViewModel(PlatformPostMMCommodityViewModel PlatformPostMMCommodityViewModel, 
                                        PlatformPutMMCommodityViewModel PlatformPutMMCommodityViewModel,
                                        PlatformDeleteMMCommodityViewModel PlatformDeleteMMCommodityViewModel,
                                        PlatformGetsMMCommodityViewModel PlatformGetsMMCommodityViewModel)
                :base(PlatformPostMMCommodityViewModel, PlatformPutMMCommodityViewModel, PlatformDeleteMMCommodityViewModel, PlatformGetsMMCommodityViewModel)
                    
        {
            
        }
    }
}