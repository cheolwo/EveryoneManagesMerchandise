using BusinessView.ofDTO.ofMarket.ofPlatform;
using BusinessView.ofViewModels.ofGeneric;

namespace BusinessView.ofViewModels.ofWebApp.ofPlatform.ofMarket.ofEMCommodity
{
    public class PlatformEMCommodityPageViewModel : StatusPageViewModel<PlatformEMCommodity> 
    {
        public PlatformEMCommodityPageViewModel(PlatformPostEMCommodityViewModel PlatformPostEMCommodityViewModel, 
                                        PlatformPutEMCommodityViewModel PlatformPutEMCommodityViewModel,
                                        PlatformDeleteEMCommodityViewModel PlatformDeleteEMCommodityViewModel,
                                        PlatformGetsEMCommodityViewModel PlatformGetsEMCommodityViewModel)
                :base(PlatformPostEMCommodityViewModel, PlatformPutEMCommodityViewModel, PlatformDeleteEMCommodityViewModel, PlatformGetsEMCommodityViewModel)
                    
        {
            
        }
    }
}