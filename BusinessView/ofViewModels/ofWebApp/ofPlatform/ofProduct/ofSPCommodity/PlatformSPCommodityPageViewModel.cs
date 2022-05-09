using BusinessView.ofDTO.ofProduct.ofPlatform;
using BusinessView.ofViewModels.ofGeneric;

namespace BusinessView.ofViewModels.ofWebApp.ofPlatform.ofProduct.ofSPCommodity
{
    public class PlatformSPCommodityPageViewModel : StatusPageViewModel<PlatformSPCommodity> 
    {
        public PlatformSPCommodityPageViewModel(PlatformPostSPCommodityViewModel PlatformPostSPCommodityViewModel, 
                                        PlatformPutSPCommodityViewModel PlatformPutSPCommodityViewModel,
                                        PlatformDeleteSPCommodityViewModel PlatformDeleteSPCommodityViewModel,
                                        PlatformGetsSPCommodityViewModel PlatformGetsSPCommodityViewModel)
                :base(PlatformPostSPCommodityViewModel, PlatformPutSPCommodityViewModel, PlatformDeleteSPCommodityViewModel, PlatformGetsSPCommodityViewModel)
                    
        {
            
        }
    }
}