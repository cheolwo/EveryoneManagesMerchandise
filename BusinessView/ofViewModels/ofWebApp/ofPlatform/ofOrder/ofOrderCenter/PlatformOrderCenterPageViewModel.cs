using BusinessView.ofDTO.ofOrder.ofPlatform;
using BusinessView.ofServices.ofCommon;
using BusinessView.ofViewModels.ofGeneric;
using BusinessView.ofExternal.ofSearchingService;
namespace BusinessView.ofViewModels.ofWebApp.ofPlatform.ofOrder.ofOrderCenter
{
    public class PlatformOrderCenterPageViewModel : CenterPageViewModel<PlatformOrderCenter> 
    {
        public readonly PlatformPostOrderCenterViewModel _PlatformPostOrderCenterViewModel;
        public readonly PlatformPutOrderCenterViewModel _PlatformPutOrderCenterViewModel;
        public readonly PlatformDeleteOrderCenterViewModel _PlatformDeleteOrderCenterViewModel;
        public readonly PlatformGetsOrderCenterViewModel _PlatformGetsOrderCenterViewModel;
        public PlatformOrderCenterPageViewModel(ICenterPageRoadAddressService centerPageRoadAddressService,
                                        ICenterPageTaxService centerPageTaxService,
                                        ICenterPageIdentityRoleService centerPageIdentityRoleService,
                                        PlatformPostOrderCenterViewModel PlatformPostOrderCenterViewModel, 
                                        PlatformPutOrderCenterViewModel PlatformPutOrderCenterViewModel,
                                        PlatformDeleteOrderCenterViewModel PlatformDeleteOrderCenterViewModel,
                                        PlatformGetsOrderCenterViewModel PlatformGetsOrderCenterViewModel)
                :base(centerPageRoadAddressService, centerPageTaxService, centerPageIdentityRoleService, PlatformPostOrderCenterViewModel, PlatformPutOrderCenterViewModel, PlatformDeleteOrderCenterViewModel, PlatformGetsOrderCenterViewModel)
                    
        {
            _PlatformPostOrderCenterViewModel = PlatformPostOrderCenterViewModel;
            _PlatformPutOrderCenterViewModel = PlatformPutOrderCenterViewModel;
            _PlatformDeleteOrderCenterViewModel = PlatformDeleteOrderCenterViewModel;
            _PlatformGetsOrderCenterViewModel = PlatformGetsOrderCenterViewModel;
        }
    }
}