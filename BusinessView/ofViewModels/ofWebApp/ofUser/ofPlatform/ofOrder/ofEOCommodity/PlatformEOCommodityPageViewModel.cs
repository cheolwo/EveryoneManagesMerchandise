using BusinessData.ofPresentationLayer.ofDTO.ofOrder.ofPlatform;
using BusinessView.ofViewModels.ofWebApp.ofOrder.ofEOCommodity;

namespace BusinessView.ofViewModels.ofWebApp.ofPlatform.ofOrder.ofEOCommodity
{
    public class PlatformEOCommodityPageViewModel : EOCommodityPageViewModel<PlatformEOCommodity> 
    {
        public readonly PlatformPostEOCommodityViewModel _PlatformPostEOCommodityViewModel;
        public readonly PlatformPutEOCommodityViewModel _PlatformPutEOCommodityViewModel;
        public readonly PlatformDeleteEOCommodityViewModel _PlatformDeleteEOCommodityViewModel;
        public readonly PlatformGetsEOCommodityViewModel _PlatformGetsEOCommodityViewModel;

        public PlatformEOCommodityPageViewModel(PlatformPostEOCommodityViewModel PlatformPostEOCommodityViewModel, 
                                        PlatformPutEOCommodityViewModel PlatformPutEOCommodityViewModel,
                                        PlatformDeleteEOCommodityViewModel PlatformDeleteEOCommodityViewModel,
                                        PlatformGetsEOCommodityViewModel PlatformGetsEOCommodityViewModel)
                :base(PlatformPostEOCommodityViewModel, PlatformPutEOCommodityViewModel, PlatformDeleteEOCommodityViewModel, PlatformGetsEOCommodityViewModel)
                    
        {
            _PlatformPostEOCommodityViewModel = PlatformPostEOCommodityViewModel;
            _PlatformPutEOCommodityViewModel = PlatformPutEOCommodityViewModel;
            _PlatformDeleteEOCommodityViewModel = PlatformDeleteEOCommodityViewModel;
            _PlatformGetsEOCommodityViewModel = PlatformGetsEOCommodityViewModel;
        }
    }
}