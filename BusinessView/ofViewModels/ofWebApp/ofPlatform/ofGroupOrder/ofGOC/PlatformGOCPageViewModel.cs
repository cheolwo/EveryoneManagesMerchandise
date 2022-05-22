using BusinessView.ofDTO.ofGroupOrder.ofPlatform;
using BusinessView.ofServices.ofCommon;
using BusinessView.ofViewModels.ofGeneric;
using BusinessLogic.ofExternal.ofSearchingService;
namespace BusinessView.ofViewModels.ofWebApp.ofPlatform.ofGroupOrder.ofGOC
{
    public class PlatformGOCPageViewModel : CenterPageViewModel<PlatformGOC> 
    {
        public readonly PlatformPostGOCViewModel _PlatformPostGOCViewModel;
        public readonly PlatformPutGOCViewModel _PlatformPutGOCViewModel;
        public readonly PlatformDeleteGOCViewModel _PlatformDeleteGOCViewModel;
        public readonly PlatformGetsGOCViewModel _PlatformGetsGOCViewModel;
        public PlatformGOCPageViewModel(ICenterPageRoadAddressService centerPageRoadAddressService,
                                        ICenterPageTaxService centerPageTaxService,
                                        ICenterPageIdentityRoleService centerPageIdentityRoleService,
                                        PlatformPostGOCViewModel PlatformPostGOCViewModel, 
                                        PlatformPutGOCViewModel PlatformPutGOCViewModel,
                                        PlatformDeleteGOCViewModel PlatformDeleteGOCViewModel,
                                        PlatformGetsGOCViewModel PlatformGetsGOCViewModel)
                :base(centerPageRoadAddressService, centerPageTaxService, centerPageIdentityRoleService, PlatformPostGOCViewModel, PlatformPutGOCViewModel, PlatformDeleteGOCViewModel, PlatformGetsGOCViewModel)
                    
        {
            _PlatformPostGOCViewModel = PlatformPostGOCViewModel;
            _PlatformPutGOCViewModel = PlatformPutGOCViewModel;
            _PlatformDeleteGOCViewModel = PlatformDeleteGOCViewModel;
            _PlatformGetsGOCViewModel = PlatformGetsGOCViewModel;
        }
    }
}