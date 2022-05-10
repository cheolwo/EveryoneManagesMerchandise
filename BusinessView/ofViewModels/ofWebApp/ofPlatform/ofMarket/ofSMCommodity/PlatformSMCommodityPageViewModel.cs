using BusinessView.ofDTO.ofMarket.ofPlatform;
using BusinessView.ofViewModels.ofGeneric;

namespace BusinessView.ofViewModels.ofWebApp.ofPlatform.ofMarket.ofSMCommodity
{
    public class PlatformSMCommodityPageViewModel : StatusPageViewModel<PlatformSMCommodity> 
    {
        public PlatformSMCommodityPageViewModel(PlatformPostSMCommodityViewModel PlatformPostSMCommodityViewModel, 
                                        PlatformPutSMCommodityViewModel PlatformPutSMCommodityViewModel,
                                        PlatformDeleteSMCommodityViewModel PlatformDeleteSMCommodityViewModel,
                                        PlatformGetsSMCommodityViewModel PlatformGetsSMCommodityViewModel)
                :base(PlatformPostSMCommodityViewModel, PlatformPutSMCommodityViewModel, PlatformDeleteSMCommodityViewModel, PlatformGetsSMCommodityViewModel)
                    
        {
            
        }
    }
}