using BusinessView.ofDTO.ofHR.ofEmployee;
using BusinessView.ofViewModels.ofGeneric;

namespace BusinessView.ofViewModels.ofWebApp.ofEmployee.ofHR.ofHRRole
{
    public class EmployeeHRRolePageViewModel : EntityPageViewModel<EmployeeHRRole> 
    {
        public EmployeeHRRolePageViewModel(EmployeePostHRRoleViewModel employeePostHRRoleViewModel, 
                                        EmployeePutHRRoleViewModel employeePutHRRoleViewModel,
                                        EmployeeDeleteHRRoleViewModel employeeDeleteHRRoleViewModel,
                                        EmployeeGetsHRRoleViewModel employeeGetsHRRoleViewModel)
                :base(employeePostHRRoleViewModel, employeePutHRRoleViewModel, employeeDeleteHRRoleViewModel, employeeGetsHRRoleViewModel)
                    
        {
            
        }
    }
}