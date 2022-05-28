using BusinessView.ofDTO.ofWarehouse.ofPlatform;
using BusinessView.ofViewModels.ofGeneric;

namespace BusinessView.ofViewModels.ofWebApp.ofPlatform.ofWarehouse.ofMWCommodity
{
    public class PlatformMWCommodityPageViewModel : StatusPageViewModel<PlatformMWCommodity> 
    {
        public readonly PlatformPostMWCommodityViewModel _PlatformPostMWCommodityViewModel;
        public readonly PlatformPutMWCommodityViewModel _PlatformPutMWCommodityViewModel;
        public readonly PlatformDeleteMWCommodityViewModel _PlatformDeleteMWCommodityViewModel;
        public readonly PlatformGetsMWCommodityViewModel _PlatformGetsMWCommodityViewModel;
        public PlatformMWCommodityPageViewModel(PlatformPostMWCommodityViewModel PlatformPostMWCommodityViewModel, 
                                        PlatformPutMWCommodityViewModel PlatformPutMWCommodityViewModel,
                                        PlatformDeleteMWCommodityViewModel PlatformDeleteMWCommodityViewModel,
                                        PlatformGetsMWCommodityViewModel PlatformGetsMWCommodityViewModel)
                :base(PlatformPostMWCommodityViewModel, PlatformPutMWCommodityViewModel, PlatformDeleteMWCommodityViewModel, PlatformGetsMWCommodityViewModel)
                    
        {
            _PlatformPostMWCommodityViewModel = PlatformPostMWCommodityViewModel;
            _PlatformPutMWCommodityViewModel = PlatformPutMWCommodityViewModel;
            _PlatformDeleteMWCommodityViewModel = PlatformDeleteMWCommodityViewModel;
            _PlatformGetsMWCommodityViewModel = PlatformGetsMWCommodityViewModel;
        }
    }
}