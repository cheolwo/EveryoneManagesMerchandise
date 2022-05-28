using BusinessView.ofDTO.ofGroupOrder.ofEmployer;
using BusinessView.ofServices.ofCommon;
using BusinessView.ofViewModels.ofGeneric;
using BusinessView.ofExternal.ofSearchingService;
namespace BusinessView.ofViewModels.ofWebApp.ofEmployer.ofGroupOrder.ofGOC
{
    public class EmployerGOCPageViewModel : EmployerCenterPageViewModel<EmployerGOC> 
    {
        public readonly EmployerPostGOCViewModel _EmployerPostGOCViewModel;
        public readonly EmployerPutGOCViewModel _EmployerPutGOCViewModel;
        public readonly EmployerDeleteGOCViewModel _EmployerDeleteGOCViewModel;
        public readonly EmployerGetsGOCViewModel _EmployerGetsGOCViewModel;
        public EmployerGOCPageViewModel(ICenterPageRoadAddressService centerPageRoadAddressService,
                                        ICenterPageTaxService centerPageTaxService,
                                        ICenterPageIdentityRoleService centerPageIdentityRoleService,
                                        EmployerPostGOCViewModel EmployerPostGOCViewModel, 
                                        EmployerPutGOCViewModel EmployerPutGOCViewModel,
                                        EmployerDeleteGOCViewModel EmployerDeleteGOCViewModel,
                                        EmployerGetsGOCViewModel EmployerGetsGOCViewModel)
                :base(centerPageRoadAddressService, centerPageTaxService, centerPageIdentityRoleService, EmployerPostGOCViewModel, EmployerPutGOCViewModel, EmployerDeleteGOCViewModel, EmployerGetsGOCViewModel)
                    
        {
            _EmployerPostGOCViewModel = EmployerPostGOCViewModel;
            _EmployerPutGOCViewModel = EmployerPutGOCViewModel;
            _EmployerDeleteGOCViewModel = EmployerDeleteGOCViewModel;
            _EmployerGetsGOCViewModel = EmployerGetsGOCViewModel;
        }
    }
}