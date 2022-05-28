using BusinessView.ofDTO.ofOrder.ofPlatform;
using BusinessView.ofViewModels.ofGeneric;
using BusinessView.ofViewModels.ofWebApp.ofOrder.ofMOCommodity;

namespace BusinessView.ofViewModels.ofWebApp.ofPlatform.ofOrder.ofMOCommodity
{
    public class PlatformMOCommodityPageViewModel : MOCommodityPageViewModel<PlatformMOCommodity> 
    {
        public readonly PlatformPostMOCommodityViewModel _PlatformPostMOCommodityViewModel;
        public readonly PlatformPutMOCommodityViewModel _PlatformPutMOCommodityViewModel;
        public readonly PlatformDeleteMOCommodityViewModel _PlatformDeleteMOCommodityViewModel;
        public readonly PlatformGetsMOCommodityViewModel _PlatformGetsMOCommodityViewModel;

        public PlatformMOCommodityPageViewModel(PlatformPostMOCommodityViewModel PlatformPostMOCommodityViewModel, 
                                        PlatformPutMOCommodityViewModel PlatformPutMOCommodityViewModel,
                                        PlatformDeleteMOCommodityViewModel PlatformDeleteMOCommodityViewModel,
                                        PlatformGetsMOCommodityViewModel PlatformGetsMOCommodityViewModel)
                :base(PlatformPostMOCommodityViewModel, PlatformPutMOCommodityViewModel, PlatformDeleteMOCommodityViewModel, PlatformGetsMOCommodityViewModel)
                    
        {
            _PlatformPostMOCommodityViewModel = PlatformPostMOCommodityViewModel;
            _PlatformPutMOCommodityViewModel = PlatformPutMOCommodityViewModel;
            _PlatformDeleteMOCommodityViewModel = PlatformDeleteMOCommodityViewModel;
            _PlatformGetsMOCommodityViewModel = PlatformGetsMOCommodityViewModel;
        }
    }
}