using BusinessView.ofDTO.ofGroupOrder.ofEmployee;
using BusinessView.ofServices.ofCommon;
using BusinessView.ofViewModels.ofGeneric;

namespace BusinessView.ofViewModels.ofWebApp.ofEmployee.ofGroupOrder.ofGOC
{
    public class EmployeeGOCPageViewModel : CenterPageViewModel<EmployeeGOC> 
    {
        public EmployeeGOCPageViewModel(ICenterPageRoadAddressService centerPageRoadAddressService,
                                        ICenterPageTaxService centerPageTaxService,
                                        ICenterPageIdentityRoleService centerPageIdentityRoleService,
                                        EmployeePostGOCViewModel employeePostGOCViewModel, 
                                        EmployeePutGOCViewModel employeePutGOCViewModel,
                                        EmployeeDeleteGOCViewModel employeeDeleteGOCViewModel,
                                        EmployeeGetsGOCViewModel employeeGetsGOCViewModel)
                :base(centerPageRoadAddressService, centerPageTaxService, centerPageIdentityRoleService, employeePostGOCViewModel, employeePutGOCViewModel, employeeDeleteGOCViewModel, employeeGetsGOCViewModel)
                    
        {
            
        }
    }
}