using BusinessView.ofDTO.ofMarket.ofPlatform;
using BusinessView.ofViewModels.ofGeneric;
using BusinessView.ofViewModels.ofWebApp.ofMarket.ofMMCommodity;

namespace BusinessView.ofViewModels.ofWebApp.ofPlatform.ofMarket.ofMMCommodity
{
    public class PlatformMMCommodityPageViewModel : MMCommodityPageViewModel<PlatformMMCommodity> 
    {
        public readonly PlatformPostMMCommodityViewModel _PlatformPostMMCommodityViewModel;
        public readonly PlatformPutMMCommodityViewModel _PlatformPutMMCommodityViewModel;
        public readonly PlatformDeleteMMCommodityViewModel _PlatformDeleteMMCommodityViewModel;
        public readonly PlatformGetsMMCommodityViewModel _PlatformGetsMMCommodityViewModel;

        public PlatformMMCommodityPageViewModel(PlatformPostMMCommodityViewModel PlatformPostMMCommodityViewModel, 
                                        PlatformPutMMCommodityViewModel PlatformPutMMCommodityViewModel,
                                        PlatformDeleteMMCommodityViewModel PlatformDeleteMMCommodityViewModel,
                                        PlatformGetsMMCommodityViewModel PlatformGetsMMCommodityViewModel)
                :base(PlatformPostMMCommodityViewModel, PlatformPutMMCommodityViewModel, PlatformDeleteMMCommodityViewModel, PlatformGetsMMCommodityViewModel)
                    
        {
            _PlatformPostMMCommodityViewModel = PlatformPostMMCommodityViewModel;
            _PlatformPutMMCommodityViewModel = PlatformPutMMCommodityViewModel;
            _PlatformDeleteMMCommodityViewModel = PlatformDeleteMMCommodityViewModel;
            _PlatformGetsMMCommodityViewModel = PlatformGetsMMCommodityViewModel;
        }
    }
}