using BusinessData.ofPresentationLayer.ofDTO.ofWarehouse.ofPlatform;
using BusinessView.ofViewModels.ofWebApp.ofWarehouse.ofEWCommodity;

namespace BusinessView.ofViewModels.ofWebApp.ofPlatform.ofWarehouse.ofEWCommodity
{
    public class PlatformEWCommodityPageViewModel : EWCommodityPageViewModel<PlatformEWCommodity> 
    {
        public readonly PlatformPostEWCommodityViewModel _PlatformPostEWCommodityViewModel;
        public readonly PlatformPutEWCommodityViewModel _PlatformPutEWCommodityViewModel;
        public readonly PlatformDeleteEWCommodityViewModel _PlatformDeleteEWCommodityViewModel;
        public readonly PlatformGetsEWCommodityViewModel _PlatformGetsEWCommodityViewModel;

        public PlatformEWCommodityPageViewModel(PlatformPostEWCommodityViewModel PlatformPostEWCommodityViewModel, 
                                        PlatformPutEWCommodityViewModel PlatformPutEWCommodityViewModel,
                                        PlatformDeleteEWCommodityViewModel PlatformDeleteEWCommodityViewModel,
                                        PlatformGetsEWCommodityViewModel PlatformGetsEWCommodityViewModel)
                :base(PlatformPostEWCommodityViewModel, PlatformPutEWCommodityViewModel, PlatformDeleteEWCommodityViewModel, PlatformGetsEWCommodityViewModel)
                    
        {
            _PlatformPostEWCommodityViewModel = PlatformPostEWCommodityViewModel;
            _PlatformPutEWCommodityViewModel = PlatformPutEWCommodityViewModel;
            _PlatformDeleteEWCommodityViewModel = PlatformDeleteEWCommodityViewModel;
            _PlatformGetsEWCommodityViewModel = PlatformGetsEWCommodityViewModel;
        }
    }
}