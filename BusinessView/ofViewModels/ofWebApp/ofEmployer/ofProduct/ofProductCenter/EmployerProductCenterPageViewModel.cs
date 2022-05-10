using BusinessView.ofDTO.ofProduct.ofEmployer;
using BusinessView.ofServices.ofCommon;
using BusinessView.ofViewModels.ofGeneric;

namespace BusinessView.ofViewModels.ofWebApp.ofEmployer.ofProduct.ofProductCenter
{
    public class EmployerProductCenterPageViewModel : CenterPageViewModel<EmployerProductCenter> 
    {
        public EmployerProductCenterPageViewModel(ICenterPageRoadAddressService centerPageRoadAddressService,
                                        ICenterPageTaxService centerPageTaxService,
                                        ICenterPageIdentityRoleService centerPageIdentityRoleService,
            EmployerPostProductCenterViewModel EmployerPostProductCenterViewModel, 
                                        EmployerPutProductCenterViewModel EmployerPutProductCenterViewModel,
                                        EmployerDeleteProductCenterViewModel EmployerDeleteProductCenterViewModel,
                                        EmployerGetsProductCenterViewModel EmployerGetsProductCenterViewModel)
                :base(centerPageRoadAddressService, centerPageTaxService, centerPageIdentityRoleService, EmployerPostProductCenterViewModel, EmployerPutProductCenterViewModel, EmployerDeleteProductCenterViewModel, EmployerGetsProductCenterViewModel)
                    
        {
            
        }
    }
}