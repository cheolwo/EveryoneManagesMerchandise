using BusinessView.ofDTO.ofProduct.ofPlatform;
using BusinessView.ofServices.ofCommon;
using BusinessView.ofViewModels.ofGeneric;

namespace BusinessView.ofViewModels.ofWebApp.ofPlatform.ofProduct.ofProducter
{
    public class PlatformProducterPageViewModel : CenterPageViewModel<PlatformProducter> 
    {
        public readonly PlatformPostProducterViewModel _PlatformPostProducterViewModel;
        public readonly PlatformPutProducterViewModel _PlatformPutProducterViewModel;
        public readonly PlatformDeleteProducterViewModel _PlatformDeleteProducterViewModel;
        public readonly PlatformGetsProducterViewModel _PlatformGetsProducterViewModel;
        public PlatformProducterPageViewModel(ICenterPageRoadAddressService centerPageRoadAddressService,
                                        ICenterPageTaxService centerPageTaxService,
                                        ICenterPageIdentityRoleService centerPageIdentityRoleService,
                                        PlatformPostProducterViewModel PlatformPostProducterViewModel, 
                                        PlatformPutProducterViewModel PlatformPutProducterViewModel,
                                        PlatformDeleteProducterViewModel PlatformDeleteProducterViewModel,
                                        PlatformGetsProducterViewModel PlatformGetsProducterViewModel)
                :base(centerPageRoadAddressService, centerPageTaxService, centerPageIdentityRoleService, PlatformPostProducterViewModel, PlatformPutProducterViewModel, PlatformDeleteProducterViewModel, PlatformGetsProducterViewModel)
                    
        {
            _PlatformPostProducterViewModel = PlatformPostProducterViewModel;
            _PlatformPutProducterViewModel = PlatformPutProducterViewModel;
            _PlatformDeleteProducterViewModel = PlatformDeleteProducterViewModel;
            _PlatformGetsProducterViewModel = PlatformGetsProducterViewModel;
        }
    }
}