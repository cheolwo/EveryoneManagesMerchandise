using BusinessView.ofDTO.ofHR.ofEmployee;
using BusinessView.ofViewModels.ofGeneric;
using BusinessView.ofViewModels.ofWebApp.ofHR.ofHRRole;
namespace BusinessView.ofViewModels.ofWebApp.ofEmployee.ofHR.ofHRRole
{
    public class EmployeeHRRolePageViewModel : HRRolePageViewModel<EmployeeHRRole> 
    {
        public readonly EmployeePostHRRoleViewModel _EmployeePostHRRoleViewModel;
        public readonly EmployeePutHRRoleViewModel _EmployeePutHRRoleViewModel;
        public readonly EmployeeDeleteHRRoleViewModel _EmployeeDeleteHRRoleViewModel;
        public readonly EmployeeGetsHRRoleViewModel _EmployeeGetsHRRoleViewModel;
        public EmployeeHRRolePageViewModel(EmployeePostHRRoleViewModel employeePostHRRoleViewModel, 
                                        EmployeePutHRRoleViewModel employeePutHRRoleViewModel,
                                        EmployeeDeleteHRRoleViewModel employeeDeleteHRRoleViewModel,
                                        EmployeeGetsHRRoleViewModel employeeGetsHRRoleViewModel)
                :base(employeePostHRRoleViewModel, employeePutHRRoleViewModel, employeeDeleteHRRoleViewModel, employeeGetsHRRoleViewModel)
                    
        {
            _EmployeePostHRRoleViewModel = employeePostHRRoleViewModel;
            _EmployeePutHRRoleViewModel = employeePutHRRoleViewModel;
            _EmployeeDeleteHRRoleViewModel = employeeDeleteHRRoleViewModel;
            _EmployeeGetsHRRoleViewModel = employeeGetsHRRoleViewModel;
        }
    }
}