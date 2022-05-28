using BusinessView.ofDTO.ofProduct.ofPlatform;
using BusinessView.ofViewModels.ofGeneric;
using BusinessView.ofViewModels.ofWebApp.ofProduct.ofProducter;

namespace BusinessView.ofViewModels.ofWebApp.ofPlatform.ofProduct.ofProducter
{
    public class PlatformProducterPageViewModel : ProducterPageViewModel<PlatformProducter> 
    {
        public readonly PlatformPostProducterViewModel _PlatformPostProducterViewModel;
        public readonly PlatformPutProducterViewModel _PlatformPutProducterViewModel;
        public readonly PlatformDeleteProducterViewModel _PlatformDeleteProducterViewModel;
        public readonly PlatformGetsProducterViewModel _PlatformGetsProducterViewModel;

        public PlatformProducterPageViewModel(PlatformPostProducterViewModel PlatformPostProducterViewModel, 
                                        PlatformPutProducterViewModel PlatformPutProducterViewModel,
                                        PlatformDeleteProducterViewModel PlatformDeleteProducterViewModel,
                                        PlatformGetsProducterViewModel PlatformGetsProducterViewModel)
                :base(PlatformPostProducterViewModel, PlatformPutProducterViewModel, PlatformDeleteProducterViewModel, PlatformGetsProducterViewModel)
                    
        {
            _PlatformPostProducterViewModel = PlatformPostProducterViewModel;
            _PlatformPutProducterViewModel = PlatformPutProducterViewModel;
            _PlatformDeleteProducterViewModel = PlatformDeleteProducterViewModel;
            _PlatformGetsProducterViewModel = PlatformGetsProducterViewModel;
        }
    }
}