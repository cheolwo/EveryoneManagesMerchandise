using BusinessView.ofDTO.ofProduct.ofEmployer;
using BusinessView.ofServices.ofCommon;
using BusinessView.ofViewModels.ofGeneric;

namespace BusinessView.ofViewModels.ofWebApp.ofEmployer.ofProduct.ofProducter
{
    public class EmployerProducterPageViewModel : CenterPageViewModel<EmployerProducter> 
    {
        public EmployerProducterPageViewModel(ICenterPageRoadAddressService centerPageRoadAddressService,
                                        ICenterPageTaxService centerPageTaxService,
                                        ICenterPageIdentityRoleService centerPageIdentityRoleService,
                                        EmployerPostProducterViewModel EmployerPostProducterViewModel, 
                                        EmployerPutProducterViewModel EmployerPutProducterViewModel,
                                        EmployerDeleteProducterViewModel EmployerDeleteProducterViewModel,
                                        EmployerGetsProducterViewModel EmployerGetsProducterViewModel)
                :base(centerPageRoadAddressService, centerPageTaxService, centerPageIdentityRoleService, EmployerPostProducterViewModel, EmployerPutProducterViewModel, EmployerDeleteProducterViewModel, EmployerGetsProducterViewModel)
                    
        {
            
        }
    }
}