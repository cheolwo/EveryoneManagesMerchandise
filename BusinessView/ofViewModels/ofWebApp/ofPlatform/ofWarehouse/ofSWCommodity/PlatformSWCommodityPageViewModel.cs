using BusinessView.ofDTO.ofWarehouse.ofPlatform;
using BusinessView.ofViewModels.ofGeneric;

namespace BusinessView.ofViewModels.ofWebApp.ofPlatform.ofWarehouse.ofSWCommodity
{
    public class PlatformSWCommodityPageViewModel : StatusPageViewModel<PlatformSWCommodity> 
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