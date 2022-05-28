using BusinessView.ofDTO.ofOrder.ofPlatform;
using BusinessView.ofViewModels.ofGeneric;
using BusinessView.ofViewModels.ofWebApp.ofOrder.ofOrderCenter;

namespace BusinessView.ofViewModels.ofWebApp.ofPlatform.ofOrder.ofOrderCenter
{
    public class PlatformOrderCenterPageViewModel : OrderCenterPageViewModel<PlatformOrderCenter> 
    {
        public readonly PlatformPostOrderCenterViewModel _PlatformPostOrderCenterViewModel;
        public readonly PlatformPutOrderCenterViewModel _PlatformPutOrderCenterViewModel;
        public readonly PlatformDeleteOrderCenterViewModel _PlatformDeleteOrderCenterViewModel;
        public readonly PlatformGetsOrderCenterViewModel _PlatformGetsOrderCenterViewModel;

        public PlatformOrderCenterPageViewModel(PlatformPostOrderCenterViewModel PlatformPostOrderCenterViewModel, 
                                        PlatformPutOrderCenterViewModel PlatformPutOrderCenterViewModel,
                                        PlatformDeleteOrderCenterViewModel PlatformDeleteOrderCenterViewModel,
                                        PlatformGetsOrderCenterViewModel PlatformGetsOrderCenterViewModel)
                :base(PlatformPostOrderCenterViewModel, PlatformPutOrderCenterViewModel, PlatformDeleteOrderCenterViewModel, PlatformGetsOrderCenterViewModel)
                    
        {
            _PlatformPostOrderCenterViewModel = PlatformPostOrderCenterViewModel;
            _PlatformPutOrderCenterViewModel = PlatformPutOrderCenterViewModel;
            _PlatformDeleteOrderCenterViewModel = PlatformDeleteOrderCenterViewModel;
            _PlatformGetsOrderCenterViewModel = PlatformGetsOrderCenterViewModel;
        }
    }
}