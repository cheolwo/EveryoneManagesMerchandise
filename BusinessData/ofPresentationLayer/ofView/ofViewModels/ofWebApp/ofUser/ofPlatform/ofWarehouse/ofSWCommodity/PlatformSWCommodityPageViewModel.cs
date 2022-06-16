using BusinessData.ofPresentationLayer.ofDTO.ofWarehouse.ofPlatform;
using BusinessView.ofViewModels.ofWebApp.ofWarehouse.ofSWCommodity;

namespace BusinessView.ofViewModels.ofWebApp.ofPlatform.ofWarehouse.ofSWCommodity
{
    public class PlatformSWCommodityPageViewModel : SWCommodityPageViewModel<PlatformSWCommodity> 
    {
        public readonly PlatformPostSWCommodityViewModel _PlatformPostSWCommodityViewModel;
        public readonly PlatformPutSWCommodityViewModel _PlatformPutSWCommodityViewModel;
        public readonly PlatformDeleteSWCommodityViewModel _PlatformDeleteSWCommodityViewModel;
        public readonly PlatformGetsSWCommodityViewModel _PlatformGetsSWCommodityViewModel;

        public PlatformSWCommodityPageViewModel(PlatformPostSWCommodityViewModel PlatformPostSWCommodityViewModel, 
                                        PlatformPutSWCommodityViewModel PlatformPutSWCommodityViewModel,
                                        PlatformDeleteSWCommodityViewModel PlatformDeleteSWCommodityViewModel,
                                        PlatformGetsSWCommodityViewModel PlatformGetsSWCommodityViewModel)
                :base(PlatformPostSWCommodityViewModel, PlatformPutSWCommodityViewModel, PlatformDeleteSWCommodityViewModel, PlatformGetsSWCommodityViewModel)
                    
        {
            _PlatformPostSWCommodityViewModel = PlatformPostSWCommodityViewModel;
            _PlatformPutSWCommodityViewModel = PlatformPutSWCommodityViewModel;
            _PlatformDeleteSWCommodityViewModel = PlatformDeleteSWCommodityViewModel;
            _PlatformGetsSWCommodityViewModel = PlatformGetsSWCommodityViewModel;
        }
    }
}