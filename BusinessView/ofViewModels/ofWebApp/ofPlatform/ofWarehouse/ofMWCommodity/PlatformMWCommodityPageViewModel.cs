using BusinessView.ofDTO.ofWarehouse.ofPlatform;
using BusinessView.ofViewModels.ofGeneric;

namespace BusinessView.ofViewModels.ofWebApp.ofPlatform.ofWarehouse.ofMWCommodity
{
    public class PlatformMWCommodityPageViewModel : StatusPageViewModel<PlatformMWCommodity> 
    {
        public PlatformMWCommodityPageViewModel(PlatformPostMWCommodityViewModel PlatformPostMWCommodityViewModel, 
                                        PlatformPutMWCommodityViewModel PlatformPutMWCommodityViewModel,
                                        PlatformDeleteMWCommodityViewModel PlatformDeleteMWCommodityViewModel,
                                        PlatformGetsMWCommodityViewModel PlatformGetsMWCommodityViewModel)
                :base(PlatformPostMWCommodityViewModel, PlatformPutMWCommodityViewModel, PlatformDeleteMWCommodityViewModel, PlatformGetsMWCommodityViewModel)
                    
        {
            
        }
    }
}