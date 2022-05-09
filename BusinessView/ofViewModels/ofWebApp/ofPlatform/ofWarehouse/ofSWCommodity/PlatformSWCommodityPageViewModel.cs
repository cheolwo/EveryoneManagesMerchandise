using BusinessView.ofDTO.ofWarehouse.ofPlatform;
using BusinessView.ofViewModels.ofGeneric;

namespace BusinessView.ofViewModels.ofWebApp.ofPlatform.ofWarehouse.ofSWCommodity
{
    public class PlatformSWCommodityPageViewModel : StatusPageViewModel<PlatformSWCommodity> 
    {
        public PlatformSWCommodityPageViewModel(PlatformPostSWCommodityViewModel PlatformPostSWCommodityViewModel, 
                                        PlatformPutSWCommodityViewModel PlatformPutSWCommodityViewModel,
                                        PlatformDeleteSWCommodityViewModel PlatformDeleteSWCommodityViewModel,
                                        PlatformGetsSWCommodityViewModel PlatformGetsSWCommodityViewModel)
                :base(PlatformPostSWCommodityViewModel, PlatformPutSWCommodityViewModel, PlatformDeleteSWCommodityViewModel, PlatformGetsSWCommodityViewModel)
                    
        {
            
        }
    }
}