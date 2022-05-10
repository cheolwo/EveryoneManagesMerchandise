using BusinessView.ofDTO.ofProduct.ofPlatform;
using BusinessView.ofViewModels.ofGeneric;

namespace BusinessView.ofViewModels.ofWebApp.ofPlatform.ofProduct.ofMPCommodity
{
    public class PlatformMPCommodityPageViewModel : StatusPageViewModel<PlatformMPCommodity> 
    {
        public PlatformMPCommodityPageViewModel(PlatformPostMPCommodityViewModel PlatformPostMPCommodityViewModel, 
                                        PlatformPutMPCommodityViewModel PlatformPutMPCommodityViewModel,
                                        PlatformDeleteMPCommodityViewModel PlatformDeleteMPCommodityViewModel,
                                        PlatformGetsMPCommodityViewModel PlatformGetsMPCommodityViewModel)
                :base(PlatformPostMPCommodityViewModel, PlatformPutMPCommodityViewModel, PlatformDeleteMPCommodityViewModel, PlatformGetsMPCommodityViewModel)
                    
        {
            
        }
    }
}