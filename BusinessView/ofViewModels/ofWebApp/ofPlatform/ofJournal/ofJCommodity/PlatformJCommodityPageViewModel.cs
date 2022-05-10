using BusinessView.ofDTO.ofJournal.ofPlatform;
using BusinessView.ofViewModels.ofGeneric;

namespace BusinessView.ofViewModels.ofWebApp.ofPlatform.ofJournal.ofJCommodity
{
    public class PlatformJCommodityPageViewModel : CommodityPageViewModel<PlatformJCommodity> 
    {
        public PlatformJCommodityPageViewModel(PlatformPostJCommodityViewModel PlatformPostJCommodityViewModel, 
                                        PlatformPutJCommodityViewModel PlatformPutJCommodityViewModel,
                                        PlatformDeleteJCommodityViewModel PlatformDeleteJCommodityViewModel,
                                        PlatformGetsJCommodityViewModel PlatformGetsJCommodityViewModel)
                :base(PlatformPostJCommodityViewModel, PlatformPutJCommodityViewModel, PlatformDeleteJCommodityViewModel, PlatformGetsJCommodityViewModel)
                    
        {
            
        }
    }
}