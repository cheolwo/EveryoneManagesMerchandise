using BusinessView.ofTrade.ofPlatform;
using BusinessView.ofViewModels.ofGeneric;

namespace BusinessView.ofViewModels.ofWebApp.ofPlatform.ofTrade.ofSTCommodity
{
    public class PlatformSTCommodityPageViewModel : StatusPageViewModel<PlatformSTCommodity> 
    {
        public readonly PlatformPostSTCommodityViewModel _PlatformPostSTCommodityViewModel;
        public readonly PlatformPutSTCommodityViewModel _PlatformPutSTCommodityViewModel;
        public readonly PlatformDeleteSTCommodityViewModel _PlatformDeleteSTCommodityViewModel;
        public readonly PlatformGetsSTCommodityViewModel _PlatformGetsSTCommodityViewModel;
        public PlatformSTCommodityPageViewModel(PlatformPostSTCommodityViewModel PlatformPostSTCommodityViewModel, 
                                        PlatformPutSTCommodityViewModel PlatformPutSTCommodityViewModel,
                                        PlatformDeleteSTCommodityViewModel PlatformDeleteSTCommodityViewModel,
                                        PlatformGetsSTCommodityViewModel PlatformGetsSTCommodityViewModel)
                :base(PlatformPostSTCommodityViewModel, PlatformPutSTCommodityViewModel, PlatformDeleteSTCommodityViewModel, PlatformGetsSTCommodityViewModel)
                    
        {
            _PlatformPostSTCommodityViewModel = PlatformPostSTCommodityViewModel;
            _PlatformPutSTCommodityViewModel = PlatformPutSTCommodityViewModel;
            _PlatformDeleteSTCommodityViewModel = PlatformDeleteSTCommodityViewModel;
            _PlatformGetsSTCommodityViewModel = PlatformGetsSTCommodityViewModel;
        }
    }
}