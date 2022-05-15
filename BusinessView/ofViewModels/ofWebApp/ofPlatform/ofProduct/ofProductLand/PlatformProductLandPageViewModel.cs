using BusinessView.ofDTO.ofProduct.ofPlatform;
using BusinessView.ofViewModels.ofGeneric;

namespace BusinessView.ofViewModels.ofWebApp.ofPlatform.ofProduct.ofProductLand
{
    public class PlatformProductLandPageViewModel : EntityPageViewModel<PlatformProductLand> 
    {
        public readonly PlatformPostProductLandViewModel _PlatformPostProductLandViewModel;
        public readonly PlatformPutProductLandViewModel _PlatformPutProductLandViewModel;
        public readonly PlatformDeleteProductLandViewModel _PlatformDeleteProductLandViewModel;
        public readonly PlatformGetsProductLandViewModel _PlatformGetsProductLandViewModel;
        public PlatformProductLandPageViewModel(PlatformPostProductLandViewModel PlatformPostProductLandViewModel, 
                                        PlatformPutProductLandViewModel PlatformPutProductLandViewModel,
                                        PlatformDeleteProductLandViewModel PlatformDeleteProductLandViewModel,
                                        PlatformGetsProductLandViewModel PlatformGetsProductLandViewModel)
                :base(PlatformPostProductLandViewModel, PlatformPutProductLandViewModel, PlatformDeleteProductLandViewModel, PlatformGetsProductLandViewModel)
                    
        {
            _PlatformPostProductLandViewModel = PlatformPostProductLandViewModel;
            _PlatformPutProductLandViewModel = PlatformPutProductLandViewModel;
            _PlatformDeleteProductLandViewModel = PlatformDeleteProductLandViewModel;
            _PlatformGetsProductLandViewModel = PlatformGetsProductLandViewModel;
        }
    }
}