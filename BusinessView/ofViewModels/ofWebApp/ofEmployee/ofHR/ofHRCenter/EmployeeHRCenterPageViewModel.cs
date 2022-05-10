using BusinessView.ofDTO.ofHR.ofEmployee;
using BusinessView.ofServices.ofCommon;
using BusinessView.ofViewModels.ofGeneric;

namespace BusinessView.ofViewModels.ofWebApp.ofEmployee.ofHR.ofHRCenter
{
    public class EmployeeHRCenterPageViewModel : CenterPageViewModel<EmployeeHRCenter> 
    {
        public EmployeeHRCenterPageViewModel(ICenterPageRoadAddressService centerPageRoadAddressService,
                                        ICenterPageTaxService centerPageTaxService,
                                        ICenterPageIdentityRoleService centerPageIdentityRoleService,
            EmployeePostHRCenterViewModel employeePostHRCenterViewModel, 
                                        EmployeePutHRCenterViewModel employeePutHRCenterViewModel,
                                        EmployeeDeleteHRCenterViewModel employeeDeleteHRCenterViewModel,
                                        EmployeeGetsHRCenterViewModel employeeGetsHRCenterViewModel)
                :base(centerPageRoadAddressService, centerPageTaxService, centerPageIdentityRoleService, employeePostHRCenterViewModel, employeePutHRCenterViewModel, employeeDeleteHRCenterViewModel, employeeGetsHRCenterViewModel)
                    
        {
            
        }
    }
}