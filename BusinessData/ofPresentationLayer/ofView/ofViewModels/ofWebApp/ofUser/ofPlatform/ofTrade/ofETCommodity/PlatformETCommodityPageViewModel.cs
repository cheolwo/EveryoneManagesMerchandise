using BusinessData.ofPresentationLayer.ofDTO.ofTrade.ofPlatform;
using BusinessView.ofViewModels.ofWebApp.ofTrade.ofETCommodity;

namespace BusinessView.ofViewModels.ofWebApp.ofPlatform.ofTrade.ofETCommodity
{
    public class PlatformETCommodityPageViewModel : ETCommodityPageViewModel<PlatformETCommodity> 
    {
        public readonly PlatformPostETCommodityViewModel _PlatformPostETCommodityViewModel;
        public readonly PlatformPutETCommodityViewModel _PlatformPutETCommodityViewModel;
        public readonly PlatformDeleteETCommodityViewModel _PlatformDeleteETCommodityViewModel;
        public readonly PlatformGetsETCommodityViewModel _PlatformGetsETCommodityViewModel;

        public PlatformETCommodityPageViewModel(PlatformPostETCommodityViewModel PlatformPostETCommodityViewModel, 
                                        PlatformPutETCommodityViewModel PlatformPutETCommodityViewModel,
                                        PlatformDeleteETCommodityViewModel PlatformDeleteETCommodityViewModel,
                                        PlatformGetsETCommodityViewModel PlatformGetsETCommodityViewModel)
                :base(PlatformPostETCommodityViewModel, PlatformPutETCommodityViewModel, PlatformDeleteETCommodityViewModel, PlatformGetsETCommodityViewModel)
                    
        {
            _PlatformPostETCommodityViewModel = PlatformPostETCommodityViewModel;
            _PlatformPutETCommodityViewModel = PlatformPutETCommodityViewModel;
            _PlatformDeleteETCommodityViewModel = PlatformDeleteETCommodityViewModel;
            _PlatformGetsETCommodityViewModel = PlatformGetsETCommodityViewModel;
        }
    }
}