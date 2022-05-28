using BusinessView.ofDTO.ofWarehouse.ofPlatform;
using BusinessView.ofViewModels.ofGeneric;
using BusinessView.ofViewModels.ofWebApp.ofWarehouse.ofWCommodity;

namespace BusinessView.ofViewModels.ofWebApp.ofPlatform.ofWarehouse.ofWCommodity
{
    public class PlatformWCommodityPageViewModel : WCommodityPageViewModel<PlatformWCommodity> 
    {
        public readonly PlatformPostWCommodityViewModel _PlatformPostWCommodityViewModel;
        public readonly PlatformPutWCommodityViewModel _PlatformPutWCommodityViewModel;
        public readonly PlatformDeleteWCommodityViewModel _PlatformDeleteWCommodityViewModel;
        public readonly PlatformGetsWCommodityViewModel _PlatformGetsWCommodityViewModel;

        public PlatformWCommodityPageViewModel(PlatformPostWCommodityViewModel PlatformPostWCommodityViewModel, 
                                        PlatformPutWCommodityViewModel PlatformPutWCommodityViewModel,
                                        PlatformDeleteWCommodityViewModel PlatformDeleteWCommodityViewModel,
                                        PlatformGetsWCommodityViewModel PlatformGetsWCommodityViewModel)
                :base(PlatformPostWCommodityViewModel, PlatformPutWCommodityViewModel, PlatformDeleteWCommodityViewModel, PlatformGetsWCommodityViewModel)
                    
        {
            _PlatformPostWCommodityViewModel = PlatformPostWCommodityViewModel;
            _PlatformPutWCommodityViewModel = PlatformPutWCommodityViewModel;
            _PlatformDeleteWCommodityViewModel = PlatformDeleteWCommodityViewModel;
            _PlatformGetsWCommodityViewModel = PlatformGetsWCommodityViewModel;
        }
    }
}