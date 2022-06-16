using BusinessData.ofPresentationLayer.ofDTO.ofJournal.ofPlatform;
using BusinessView.ofViewModels.ofWebApp.ofJournal.ofJCommodity;

namespace BusinessView.ofViewModels.ofWebApp.ofPlatform.ofJournal.ofJCommodity
{
    public class PlatformJCommodityPageViewModel : JCommodityPageViewModel<PlatformJCommodity> 
    {
        public readonly PlatformPostJCommodityViewModel _PlatformPostJCommodityViewModel;
        public readonly PlatformPutJCommodityViewModel _PlatformPutJCommodityViewModel;
        public readonly PlatformDeleteJCommodityViewModel _PlatformDeleteJCommodityViewModel;
        public readonly PlatformGetsJCommodityViewModel _PlatformGetsJCommodityViewModel;

        public PlatformJCommodityPageViewModel(PlatformPostJCommodityViewModel PlatformPostJCommodityViewModel, 
                                        PlatformPutJCommodityViewModel PlatformPutJCommodityViewModel,
                                        PlatformDeleteJCommodityViewModel PlatformDeleteJCommodityViewModel,
                                        PlatformGetsJCommodityViewModel PlatformGetsJCommodityViewModel)
                :base(PlatformPostJCommodityViewModel, PlatformPutJCommodityViewModel, PlatformDeleteJCommodityViewModel, PlatformGetsJCommodityViewModel)
                    
        {
            _PlatformPostJCommodityViewModel = PlatformPostJCommodityViewModel;
            _PlatformPutJCommodityViewModel = PlatformPutJCommodityViewModel;
            _PlatformDeleteJCommodityViewModel = PlatformDeleteJCommodityViewModel;
            _PlatformGetsJCommodityViewModel = PlatformGetsJCommodityViewModel;
        }
    }
}