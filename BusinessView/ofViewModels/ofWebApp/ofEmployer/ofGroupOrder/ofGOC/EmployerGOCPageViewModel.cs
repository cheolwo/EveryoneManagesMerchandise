using BusinessView.ofDTO.ofGroupOrder.ofEmployer;
using BusinessView.ofServices.ofCommon;
using BusinessView.ofViewModels.ofGeneric;

namespace BusinessView.ofViewModels.ofWebApp.ofEmployer.ofGroupOrder.ofGOC
{
    public class EmployerGOCPageViewModel : CenterPageViewModel<EmployerGOC> 
    {
        public EmployerGOCPageViewModel(ICenterPageRoadAddressService centerPageRoadAddressService,
                                        ICenterPageTaxService centerPageTaxService,
                                        ICenterPageIdentityRoleService centerPageIdentityRoleService,
                                        EmployerPostGOCViewModel EmployerPostGOCViewModel, 
                                        EmployerPutGOCViewModel EmployerPutGOCViewModel,
                                        EmployerDeleteGOCViewModel EmployerDeleteGOCViewModel,
                                        EmployerGetsGOCViewModel EmployerGetsGOCViewModel)
                :base(centerPageRoadAddressService, centerPageTaxService, centerPageIdentityRoleService, EmployerPostGOCViewModel, EmployerPutGOCViewModel, EmployerDeleteGOCViewModel, EmployerGetsGOCViewModel)
                    
        {
            
        }
    }
}