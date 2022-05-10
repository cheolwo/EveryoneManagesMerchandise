using BusinessView.ofDTO.ofOrder.ofPlatform;
using BusinessView.ofViewModels.ofGeneric;

namespace BusinessView.ofViewModels.ofWebApp.ofPlatform.ofOrder.ofSOCommodity
{
    public class PlatformSOCommodityPageViewModel : StatusPageViewModel<PlatformSOCommodity> 
    {
        public PlatformSOCommodityPageViewModel(PlatformPostSOCommodityViewModel PlatformPostSOCommodityViewModel, 
                                        PlatformPutSOCommodityViewModel PlatformPutSOCommodityViewModel,
                                        PlatformDeleteSOCommodityViewModel PlatformDeleteSOCommodityViewModel,
                                        PlatformGetsSOCommodityViewModel PlatformGetsSOCommodityViewModel)
                :base(PlatformPostSOCommodityViewModel, PlatformPutSOCommodityViewModel, PlatformDeleteSOCommodityViewModel, PlatformGetsSOCommodityViewModel)
                    
        {
            
        }
    }
}