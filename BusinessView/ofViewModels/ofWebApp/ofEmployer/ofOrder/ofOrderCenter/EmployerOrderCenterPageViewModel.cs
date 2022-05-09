using BusinessView.ofDTO.ofOrder.ofEmployer;
using BusinessView.ofServices.ofCommon;
using BusinessView.ofViewModels.ofGeneric;

namespace BusinessView.ofViewModels.ofWebApp.ofEmployer.ofOrder.ofOrderCenter
{
    public class EmployerOrderCenterPageViewModel : CenterPageViewModel<EmployerOrderCenter> 
    {
        public EmployerOrderCenterPageViewModel(ICenterPageRoadAddressService centerPageRoadAddressService,
                                        ICenterPageTaxService centerPageTaxService,
                                        ICenterPageIdentityRoleService centerPageIdentityRoleService,
                                        EmployerPostOrderCenterViewModel EmployerPostOrderCenterViewModel, 
                                        EmployerPutOrderCenterViewModel EmployerPutOrderCenterViewModel,
                                        EmployerDeleteOrderCenterViewModel EmployerDeleteOrderCenterViewModel,
                                        EmployerGetsOrderCenterViewModel EmployerGetsOrderCenterViewModel)
                :base(centerPageRoadAddressService, centerPageTaxService, centerPageIdentityRoleService, EmployerPostOrderCenterViewModel, EmployerPutOrderCenterViewModel, EmployerDeleteOrderCenterViewModel, EmployerGetsOrderCenterViewModel)
                    
        {
            
        }
    }
}