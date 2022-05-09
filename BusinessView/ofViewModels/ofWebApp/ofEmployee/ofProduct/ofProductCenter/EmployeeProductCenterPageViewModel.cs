using BusinessView.ofDTO.ofProduct.ofEmployee;
using BusinessView.ofServices.ofCommon;
using BusinessView.ofViewModels.ofGeneric;

namespace BusinessView.ofViewModels.ofWebApp.ofEmployee.ofProduct.ofProductCenter
{
    public class EmployeeProductCenterPageViewModel : CenterPageViewModel<EmployeeProductCenter> 
    {
        public EmployeeProductCenterPageViewModel(ICenterPageRoadAddressService centerPageRoadAddressService,
                                        ICenterPageTaxService centerPageTaxService,
                                        ICenterPageIdentityRoleService centerPageIdentityRoleService,
            EmployeePostProductCenterViewModel employeePostProductCenterViewModel, 
                                        EmployeePutProductCenterViewModel employeePutProductCenterViewModel,
                                        EmployeeDeleteProductCenterViewModel employeeDeleteProductCenterViewModel,
                                        EmployeeGetsProductCenterViewModel employeeGetsProductCenterViewModel)
                :base(centerPageRoadAddressService, centerPageTaxService, centerPageIdentityRoleService, employeePostProductCenterViewModel, employeePutProductCenterViewModel, employeeDeleteProductCenterViewModel, employeeGetsProductCenterViewModel)
                    
        {
            
        }
    }
}