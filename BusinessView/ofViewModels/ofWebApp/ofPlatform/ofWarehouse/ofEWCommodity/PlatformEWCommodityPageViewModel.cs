using BusinessView.ofDTO.ofWarehouse.ofPlatform;
using BusinessView.ofViewModels.ofGeneric;

namespace BusinessView.ofViewModels.ofWebApp.ofPlatform.ofWarehouse.ofEWCommodity
{
    public class PlatformEWCommodityPageViewModel : StatusPageViewModel<PlatformEWCommodity> 
    {
        public PlatformEWCommodityPageViewModel(PlatformPostEWCommodityViewModel PlatformPostEWCommodityViewModel, 
                                        PlatformPutEWCommodityViewModel PlatformPutEWCommodityViewModel,
                                        PlatformDeleteEWCommodityViewModel PlatformDeleteEWCommodityViewModel,
                                        PlatformGetsEWCommodityViewModel PlatformGetsEWCommodityViewModel)
                :base(PlatformPostEWCommodityViewModel, PlatformPutEWCommodityViewModel, PlatformDeleteEWCommodityViewModel, PlatformGetsEWCommodityViewModel)
                    
        {
            
        }
    }
}