using BusinessView.ofDTO.ofOrder.ofPlatform;
using BusinessView.ofViewModels.ofGeneric;

namespace BusinessView.ofViewModels.ofWebApp.ofPlatform.ofOrder.ofOCommodity
{
    public class PlatformOCommodityPageViewModel : CommodityPageViewModel<PlatformOCommodity> 
    {
        public PlatformOCommodityPageViewModel(PlatformPostOCommodityViewModel PlatformPostOCommodityViewModel, 
                                        PlatformPutOCommodityViewModel PlatformPutOCommodityViewModel,
                                        PlatformDeleteOCommodityViewModel PlatformDeleteOCommodityViewModel,
                                        PlatformGetsOCommodityViewModel PlatformGetsOCommodityViewModel)
                :base(PlatformPostOCommodityViewModel, PlatformPutOCommodityViewModel, PlatformDeleteOCommodityViewModel, PlatformGetsOCommodityViewModel)
                    
        {
            
        }
    }
}