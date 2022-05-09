using BusinessView.ofDTO.ofWarehouse.ofPlatform;
using BusinessView.ofViewModels.ofGeneric;

namespace BusinessView.ofViewModels.ofWebApp.ofPlatform.ofWarehouse.ofWCommodity
{
    public class PlatformWCommodityPageViewModel : CommodityPageViewModel<PlatformWCommodity> 
    {
        public PlatformWCommodityPageViewModel(PlatformPostWCommodityViewModel PlatformPostWCommodityViewModel, 
                                        PlatformPutWCommodityViewModel PlatformPutWCommodityViewModel,
                                        PlatformDeleteWCommodityViewModel PlatformDeleteWCommodityViewModel,
                                        PlatformGetsWCommodityViewModel PlatformGetsWCommodityViewModel)
                :base(PlatformPostWCommodityViewModel, PlatformPutWCommodityViewModel, PlatformDeleteWCommodityViewModel, PlatformGetsWCommodityViewModel)
                    
        {
            
        }
    }
}