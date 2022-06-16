using BusinessData.ofPresentationLayer.ofDTO.ofProduct.ofPlatform;
using BusinessView.ofViewModels.ofWebApp.ofProduct.ofProductCenter;

namespace BusinessView.ofViewModels.ofWebApp.ofPlatform.ofProduct.ofProductCenter
{
    public class PlatformProductCenterPageViewModel : ProductCenterPageViewModel<PlatformProductCenter> 
    {
        public readonly PlatformPostProductCenterViewModel _PlatformPostProductCenterViewModel;
        public readonly PlatformPutProductCenterViewModel _PlatformPutProductCenterViewModel;
        public readonly PlatformDeleteProductCenterViewModel _PlatformDeleteProductCenterViewModel;
        public readonly PlatformGetsProductCenterViewModel _PlatformGetsProductCenterViewModel;

        public PlatformProductCenterPageViewModel(PlatformPostProductCenterViewModel PlatformPostProductCenterViewModel, 
                                        PlatformPutProductCenterViewModel PlatformPutProductCenterViewModel,
                                        PlatformDeleteProductCenterViewModel PlatformDeleteProductCenterViewModel,
                                        PlatformGetsProductCenterViewModel PlatformGetsProductCenterViewModel)
                :base(PlatformPostProductCenterViewModel, PlatformPutProductCenterViewModel, PlatformDeleteProductCenterViewModel, PlatformGetsProductCenterViewModel)
                    
        {
            _PlatformPostProductCenterViewModel = PlatformPostProductCenterViewModel;
            _PlatformPutProductCenterViewModel = PlatformPutProductCenterViewModel;
            _PlatformDeleteProductCenterViewModel = PlatformDeleteProductCenterViewModel;
            _PlatformGetsProductCenterViewModel = PlatformGetsProductCenterViewModel;
        }
    }
}