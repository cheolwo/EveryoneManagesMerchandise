using BusinessView.ofDTO.ofHR.ofEmployee;
using BusinessView.ofViewModels.ofGeneric;

namespace BusinessView.ofViewModels.ofWebApp.ofEmployee.ofHR.ofHREmployee
{
    public class EmployeeHREmployeePageViewModel : EntityPageViewModel<EmployeeHREmployee> 
    {
        public EmployeeHREmployeePageViewModel(EmployeePostHREmployeeViewModel employeePostHREmployeeViewModel, 
                                        EmployeePutHREmployeeViewModel employeePutHREmployeeViewModel,
                                        EmployeeDeleteHREmployeeViewModel employeeDeleteHREmployeeViewModel,
                                        EmployeeGetsHREmployeeViewModel employeeGetsHREmployeeViewModel)
                :base(employeePostHREmployeeViewModel, employeePutHREmployeeViewModel, employeeDeleteHREmployeeViewModel, employeeGetsHREmployeeViewModel)
                    
        {
            
        }
    }
}