using BusinessView.ofTrade.ofPlatform;
using BusinessView.ofViewModels.ofGeneric;

namespace BusinessView.ofViewModels.ofWebApp.ofPlatform.ofTrade.ofTCommodity
{
    public class PlatformTCommodityPageViewModel : CommodityPageViewModel<PlatformTCommodity> 
    {
        public readonly PlatformPostTCommodityViewModel _PlatformPostTCommodityViewModel;
        public readonly PlatformPutTCommodityViewModel _PlatformPutTCommodityViewModel;
        public readonly PlatformDeleteTCommodityViewModel _PlatformDeleteTCommodityViewModel;
        public readonly PlatformGetsTCommodityViewModel _PlatformGetsTCommodityViewModel;
        public PlatformTCommodityPageViewModel(PlatformPostTCommodityViewModel PlatformPostTCommodityViewModel, 
                                        PlatformPutTCommodityViewModel PlatformPutTCommodityViewModel,
                                        PlatformDeleteTCommodityViewModel PlatformDeleteTCommodityViewModel,
                                        PlatformGetsTCommodityViewModel PlatformGetsTCommodityViewModel)
                :base(PlatformPostTCommodityViewModel, PlatformPutTCommodityViewModel, PlatformDeleteTCommodityViewModel, PlatformGetsTCommodityViewModel)
                    
        {
            _PlatformPostTCommodityViewModel = PlatformPostTCommodityViewModel;
            _PlatformPutTCommodityViewModel = PlatformPutTCommodityViewModel;
            _PlatformDeleteTCommodityViewModel = PlatformDeleteTCommodityViewModel;
            _PlatformGetsTCommodityViewModel = PlatformGetsTCommodityViewModel;
        }
    }
}