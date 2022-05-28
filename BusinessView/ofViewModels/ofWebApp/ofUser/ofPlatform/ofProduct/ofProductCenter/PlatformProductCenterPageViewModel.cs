using BusinessView.ofDTO.ofProduct.ofPlatform;
using BusinessView.ofServices.ofCommon;
using BusinessView.ofViewModels.ofGeneric;
using BusinessView.ofExternal.ofSearchingService;
namespace BusinessView.ofViewModels.ofWebApp.ofPlatform.ofProduct.ofProductCenter
{
    public class PlatformProductCenterPageViewModel : CenterPageViewModel<PlatformProductCenter> 
    {
        public readonly PlatformPostProductCenterViewModel _PlatformPostProductCenterViewModel;
        public readonly PlatformPutProductCenterViewModel _PlatformPutProductCenterViewModel;
        public readonly PlatformDeleteProductCenterViewModel _PlatformDeleteProductCenterViewModel;
        public readonly PlatformGetsProductCenterViewModel _PlatformGetsProductCenterViewModel;
        public PlatformProductCenterPageViewModel(ICenterPageRoadAddressService centerPageRoadAddressService,
                                        ICenterPageTaxService centerPageTaxService,
                                        ICenterPageIdentityRoleService centerPageIdentityRoleService,
                                        PlatformPostProductCenterViewModel PlatformPostProductCenterViewModel, 
                                        PlatformPutProductCenterViewModel PlatformPutProductCenterViewModel,
                                        PlatformDeleteProductCenterViewModel PlatformDeleteProductCenterViewModel,
                                        PlatformGetsProductCenterViewModel PlatformGetsProductCenterViewModel)
                :base(centerPageRoadAddressService, centerPageTaxService, centerPageIdentityRoleService, PlatformPostProductCenterViewModel, PlatformPutProductCenterViewModel, PlatformDeleteProductCenterViewModel, PlatformGetsProductCenterViewModel)
                    
        {
            _PlatformPostProductCenterViewModel = PlatformPostProductCenterViewModel;
            _PlatformPutProductCenterViewModel = PlatformPutProductCenterViewModel;
            _PlatformDeleteProductCenterViewModel = PlatformDeleteProductCenterViewModel;
            _PlatformGetsProductCenterViewModel = PlatformGetsProductCenterViewModel;
        }
    }
}