using BusinessView.ofDTO.ofProduct.ofPlatform;
using BusinessView.ofViewModels.ofGeneric;

namespace BusinessView.ofViewModels.ofWebApp.ofPlatform.ofProduct.ofEPCommodity
{
    public class PlatformEPCommodityPageViewModel : StatusPageViewModel<PlatformEPCommodity> 
    {
        public PlatformEPCommodityPageViewModel(PlatformPostEPCommodityViewModel PlatformPostEPCommodityViewModel, 
                                        PlatformPutEPCommodityViewModel PlatformPutEPCommodityViewModel,
                                        PlatformDeleteEPCommodityViewModel PlatformDeleteEPCommodityViewModel,
                                        PlatformGetsEPCommodityViewModel PlatformGetsEPCommodityViewModel)
                :base(PlatformPostEPCommodityViewModel, PlatformPutEPCommodityViewModel, PlatformDeleteEPCommodityViewModel, PlatformGetsEPCommodityViewModel)
                    
        {
            
        }
    }
}