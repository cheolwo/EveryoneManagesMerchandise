using BusinessView.ofTrade.ofPlatform;
using BusinessView.ofViewModels.ofGeneric;

namespace BusinessView.ofViewModels.ofWebApp.ofPlatform.ofTrade.ofSTCommodity
{
    public class PlatformSTCommodityPageViewModel : StatusPageViewModel<PlatformSTCommodity> 
    {
        public PlatformSTCommodityPageViewModel(PlatformPostSTCommodityViewModel PlatformPostSTCommodityViewModel, 
                                        PlatformPutSTCommodityViewModel PlatformPutSTCommodityViewModel,
                                        PlatformDeleteSTCommodityViewModel PlatformDeleteSTCommodityViewModel,
                                        PlatformGetsSTCommodityViewModel PlatformGetsSTCommodityViewModel)
                :base(PlatformPostSTCommodityViewModel, PlatformPutSTCommodityViewModel, PlatformDeleteSTCommodityViewModel, PlatformGetsSTCommodityViewModel)
                    
        {
            
        }
    }
}