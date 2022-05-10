using BusinessView.ofDTO.ofOrder.ofEmployee;
using BusinessView.ofServices.ofCommon;
using BusinessView.ofViewModels.ofGeneric;

namespace BusinessView.ofViewModels.ofWebApp.ofEmployee.ofOrder.ofOrderCenter
{
    public class EmployeeOrderCenterPageViewModel : CenterPageViewModel<EmployeeOrderCenter> 
    {
        public EmployeeOrderCenterPageViewModel(ICenterPageRoadAddressService centerPageRoadAddressService,
                                        ICenterPageTaxService centerPageTaxService,
                                        ICenterPageIdentityRoleService centerPageIdentityRoleService,
            EmployeePostOrderCenterViewModel employeePostOrderCenterViewModel, 
                                        EmployeePutOrderCenterViewModel employeePutOrderCenterViewModel,
                                        EmployeeDeleteOrderCenterViewModel employeeDeleteOrderCenterViewModel,
                                        EmployeeGetsOrderCenterViewModel employeeGetsOrderCenterViewModel)
                :base(centerPageRoadAddressService, centerPageTaxService, centerPageIdentityRoleService, employeePostOrderCenterViewModel, employeePutOrderCenterViewModel, employeeDeleteOrderCenterViewModel, employeeGetsOrderCenterViewModel)
                    
        {
            
        }
    }
}