using BusinessView.ofDTO.ofOrder.ofPlatform;
using BusinessView.ofViewModels.ofGeneric;

namespace BusinessView.ofViewModels.ofWebApp.ofPlatform.ofOrder.ofEOCommodity
{
    public class PlatformEOCommodityPageViewModel : StatusPageViewModel<PlatformEOCommodity> 
    {
        public PlatformEOCommodityPageViewModel(PlatformPostEOCommodityViewModel PlatformPostEOCommodityViewModel, 
                                        PlatformPutEOCommodityViewModel PlatformPutEOCommodityViewModel,
                                        PlatformDeleteEOCommodityViewModel PlatformDeleteEOCommodityViewModel,
                                        PlatformGetsEOCommodityViewModel PlatformGetsEOCommodityViewModel)
                :base(PlatformPostEOCommodityViewModel, PlatformPutEOCommodityViewModel, PlatformDeleteEOCommodityViewModel, PlatformGetsEOCommodityViewModel)
                    
        {
            
        }
    }
}