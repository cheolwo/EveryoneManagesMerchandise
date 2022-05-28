using BusinessView.ofTrade.ofPlatform;
using BusinessView.ofViewModels.ofGeneric;

namespace BusinessView.ofViewModels.ofWebApp.ofPlatform.ofTrade.ofMTCommodity
{
    public class PlatformMTCommodityPageViewModel : StatusPageViewModel<PlatformMTCommodity> 
    {
        public readonly PlatformPostMTCommodityViewModel _PlatformPostMTCommodityViewModel;
        public readonly PlatformPutMTCommodityViewModel _PlatformPutMTCommodityViewModel;
        public readonly PlatformDeleteMTCommodityViewModel _PlatformDeleteMTCommodityViewModel;
        public readonly PlatformGetsMTCommodityViewModel _PlatformGetsMTCommodityViewModel;
        public PlatformMTCommodityPageViewModel(PlatformPostMTCommodityViewModel PlatformPostMTCommodityViewModel, 
                                        PlatformPutMTCommodityViewModel PlatformPutMTCommodityViewModel,
                                        PlatformDeleteMTCommodityViewModel PlatformDeleteMTCommodityViewModel,
                                        PlatformGetsMTCommodityViewModel PlatformGetsMTCommodityViewModel)
                :base(PlatformPostMTCommodityViewModel, PlatformPutMTCommodityViewModel, PlatformDeleteMTCommodityViewModel, PlatformGetsMTCommodityViewModel)
                    
        {
            _PlatformPostMTCommodityViewModel = PlatformPostMTCommodityViewModel;
            _PlatformPutMTCommodityViewModel = PlatformPutMTCommodityViewModel;
            _PlatformDeleteMTCommodityViewModel = PlatformDeleteMTCommodityViewModel;
            _PlatformGetsMTCommodityViewModel = PlatformGetsMTCommodityViewModel;
        }
    }
}