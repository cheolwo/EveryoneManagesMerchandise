using BusinessData.ofPresentationLayer.ofDTO.ofMarket.ofPlatform;
using BusinessView.ofViewModels.ofWebApp.ofMarket.ofMCommodity;

namespace BusinessView.ofViewModels.ofWebApp.ofPlatform.ofMarket.ofMCommodity
{
    public class PlatformMCommodityPageViewModel : MCommodityPageViewModel<PlatformMCommodity> 
    {
        public readonly PlatformPostMCommodityViewModel _PlatformPostMCommodityViewModel;
        public readonly PlatformPutMCommodityViewModel _PlatformPutMCommodityViewModel;
        public readonly PlatformDeleteMCommodityViewModel _PlatformDeleteMCommodityViewModel;
        public readonly PlatformGetsMCommodityViewModel _PlatformGetsMCommodityViewModel;

        public PlatformMCommodityPageViewModel(PlatformPostMCommodityViewModel PlatformPostMCommodityViewModel, 
                                        PlatformPutMCommodityViewModel PlatformPutMCommodityViewModel,
                                        PlatformDeleteMCommodityViewModel PlatformDeleteMCommodityViewModel,
                                        PlatformGetsMCommodityViewModel PlatformGetsMCommodityViewModel)
                :base(PlatformPostMCommodityViewModel, PlatformPutMCommodityViewModel, PlatformDeleteMCommodityViewModel, PlatformGetsMCommodityViewModel)
                    
        {
            _PlatformPostMCommodityViewModel = PlatformPostMCommodityViewModel;
            _PlatformPutMCommodityViewModel = PlatformPutMCommodityViewModel;
            _PlatformDeleteMCommodityViewModel = PlatformDeleteMCommodityViewModel;
            _PlatformGetsMCommodityViewModel = PlatformGetsMCommodityViewModel;
        }
    }
}