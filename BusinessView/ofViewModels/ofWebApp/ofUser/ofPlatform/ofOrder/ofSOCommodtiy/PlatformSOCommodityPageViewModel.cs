using BusinessData.ofPresentationLayer.ofDTO.ofOrder.ofPlatform;
using BusinessView.ofViewModels.ofWebApp.ofOrder.ofSOCommodity;

namespace BusinessView.ofViewModels.ofWebApp.ofPlatform.ofOrder.ofSOCommodity
{
    public class PlatformSOCommodityPageViewModel : SOCommodityPageViewModel<PlatformSOCommodity> 
    {
        public readonly PlatformPostSOCommodityViewModel _PlatformPostSOCommodityViewModel;
        public readonly PlatformPutSOCommodityViewModel _PlatformPutSOCommodityViewModel;
        public readonly PlatformDeleteSOCommodityViewModel _PlatformDeleteSOCommodityViewModel;
        public readonly PlatformGetsSOCommodityViewModel _PlatformGetsSOCommodityViewModel;

        public PlatformSOCommodityPageViewModel(PlatformPostSOCommodityViewModel PlatformPostSOCommodityViewModel, 
                                        PlatformPutSOCommodityViewModel PlatformPutSOCommodityViewModel,
                                        PlatformDeleteSOCommodityViewModel PlatformDeleteSOCommodityViewModel,
                                        PlatformGetsSOCommodityViewModel PlatformGetsSOCommodityViewModel)
                :base(PlatformPostSOCommodityViewModel, PlatformPutSOCommodityViewModel, PlatformDeleteSOCommodityViewModel, PlatformGetsSOCommodityViewModel)
                    
        {
            _PlatformPostSOCommodityViewModel = PlatformPostSOCommodityViewModel;
            _PlatformPutSOCommodityViewModel = PlatformPutSOCommodityViewModel;
            _PlatformDeleteSOCommodityViewModel = PlatformDeleteSOCommodityViewModel;
            _PlatformGetsSOCommodityViewModel = PlatformGetsSOCommodityViewModel;
        }
    }
}