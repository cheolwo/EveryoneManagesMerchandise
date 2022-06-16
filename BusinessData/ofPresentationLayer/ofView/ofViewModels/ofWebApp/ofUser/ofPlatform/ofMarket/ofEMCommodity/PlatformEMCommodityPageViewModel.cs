using BusinessData.ofPresentationLayer.ofDTO.ofMarket.ofPlatform;
using BusinessView.ofViewModels.ofWebApp.ofMarket.ofEMCommodity;

namespace BusinessView.ofViewModels.ofWebApp.ofPlatform.ofMarket.ofEMCommodity
{
    public class PlatformEMCommodityPageViewModel : EMCommodityPageViewModel<PlatformEMCommodity> 
    {
        public readonly PlatformPostEMCommodityViewModel _PlatformPostEMCommodityViewModel;
        public readonly PlatformPutEMCommodityViewModel _PlatformPutEMCommodityViewModel;
        public readonly PlatformDeleteEMCommodityViewModel _PlatformDeleteEMCommodityViewModel;
        public readonly PlatformGetsEMCommodityViewModel _PlatformGetsEMCommodityViewModel;

        public PlatformEMCommodityPageViewModel(PlatformPostEMCommodityViewModel PlatformPostEMCommodityViewModel, 
                                        PlatformPutEMCommodityViewModel PlatformPutEMCommodityViewModel,
                                        PlatformDeleteEMCommodityViewModel PlatformDeleteEMCommodityViewModel,
                                        PlatformGetsEMCommodityViewModel PlatformGetsEMCommodityViewModel)
                :base(PlatformPostEMCommodityViewModel, PlatformPutEMCommodityViewModel, PlatformDeleteEMCommodityViewModel, PlatformGetsEMCommodityViewModel)
                    
        {
            _PlatformPostEMCommodityViewModel = PlatformPostEMCommodityViewModel;
            _PlatformPutEMCommodityViewModel = PlatformPutEMCommodityViewModel;
            _PlatformDeleteEMCommodityViewModel = PlatformDeleteEMCommodityViewModel;
            _PlatformGetsEMCommodityViewModel = PlatformGetsEMCommodityViewModel;
        }
    }
}