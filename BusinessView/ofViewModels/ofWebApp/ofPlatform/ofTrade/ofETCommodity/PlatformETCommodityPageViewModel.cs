using BusinessView.ofTrade.ofPlatform;
using BusinessView.ofViewModels.ofGeneric;

namespace BusinessView.ofViewModels.ofWebApp.ofPlatform.ofTrade.ofETCommodity
{
    public class PlatformETCommodityPageViewModel : StatusPageViewModel<PlatformETCommodity> 
    {
        public PlatformETCommodityPageViewModel(PlatformPostETCommodityViewModel PlatformPostETCommodityViewModel, 
                                        PlatformPutETCommodityViewModel PlatformPutETCommodityViewModel,
                                        PlatformDeleteETCommodityViewModel PlatformDeleteETCommodityViewModel,
                                        PlatformGetsETCommodityViewModel PlatformGetsETCommodityViewModel)
                :base(PlatformPostETCommodityViewModel, PlatformPutETCommodityViewModel, PlatformDeleteETCommodityViewModel, PlatformGetsETCommodityViewModel)
                    
        {
            
        }
    }
}