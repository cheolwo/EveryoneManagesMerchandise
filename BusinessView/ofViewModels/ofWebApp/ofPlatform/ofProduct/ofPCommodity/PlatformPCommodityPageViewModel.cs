using BusinessView.ofDTO.ofProduct.ofPlatform;
using BusinessView.ofViewModels.ofGeneric;

namespace BusinessView.ofViewModels.ofWebApp.ofPlatform.ofProduct.ofPCommodity
{
    public class PlatformPCommodityPageViewModel : CommodityPageViewModel<PlatformPCommodity> 
    {
        public PlatformPCommodityPageViewModel(PlatformPostPCommodityViewModel PlatformPostPCommodityViewModel, 
                                        PlatformPutPCommodityViewModel PlatformPutPCommodityViewModel,
                                        PlatformDeletePCommodityViewModel PlatformDeletePCommodityViewModel,
                                        PlatformGetsPCommodityViewModel PlatformGetsPCommodityViewModel)
                :base(PlatformPostPCommodityViewModel, PlatformPutPCommodityViewModel, PlatformDeletePCommodityViewModel, PlatformGetsPCommodityViewModel)
                    
        {
            
        }
    }
}