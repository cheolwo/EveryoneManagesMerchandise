using BusinessView.ofDTO.ofHR.ofEmployee;
using BusinessView.ofViewModels.ofGeneric;

namespace BusinessView.ofViewModels.ofWebApp.ofEmployee.ofHR.ofEmployeeRole
{
    public class EmployeeEmployeeRolePageViewModel : EntityPageViewModel<EmployeeEmployeeRole> 
    {
        public EmployeeEmployeeRolePageViewModel(EmployeePostEmployeeRoleViewModel employeePostEmployeeRoleViewModel, 
                                        EmployeePutEmployeeRoleViewModel employeePutEmployeeRoleViewModel,
                                        EmployeeDeleteEmployeeRoleViewModel employeeDeleteEmployeeRoleViewModel,
                                        EmployeeGetsEmployeeRoleViewModel employeeGetsEmployeeRoleViewModel)
                :base(employeePostEmployeeRoleViewModel, employeePutEmployeeRoleViewModel, employeeDeleteEmployeeRoleViewModel, employeeGetsEmployeeRoleViewModel)
                    
        {
            
        }
    }
}