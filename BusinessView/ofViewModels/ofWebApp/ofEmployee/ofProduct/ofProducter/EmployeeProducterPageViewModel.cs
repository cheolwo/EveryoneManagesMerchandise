using BusinessView.ofDTO.ofProduct.ofEmployee;
using BusinessView.ofServices.ofCommon;
using BusinessView.ofViewModels.ofGeneric;

namespace BusinessView.ofViewModels.ofWebApp.ofEmployee.ofProduct.ofProducter
{
    public class EmployeeProducterPageViewModel : CenterPageViewModel<EmployeeProducter> 
    {
        public EmployeeProducterPageViewModel(ICenterPageRoadAddressService centerPageRoadAddressService,
                                        ICenterPageTaxService centerPageTaxService,
                                        ICenterPageIdentityRoleService centerPageIdentityRoleService,
            EmployeePostProducterViewModel employeePostProducterViewModel, 
                                        EmployeePutProducterViewModel employeePutProducterViewModel,
                                        EmployeeDeleteProducterViewModel employeeDeleteProducterViewModel,
                                        EmployeeGetsProducterViewModel employeeGetsProducterViewModel)
                :base(centerPageRoadAddressService, centerPageTaxService, centerPageIdentityRoleService, employeePostProducterViewModel, employeePutProducterViewModel, employeeDeleteProducterViewModel, employeeGetsProducterViewModel)
                    
        {
            
        }
    }
}