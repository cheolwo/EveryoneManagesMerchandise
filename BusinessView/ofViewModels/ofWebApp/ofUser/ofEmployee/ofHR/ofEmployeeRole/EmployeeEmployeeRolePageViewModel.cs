using BusinessData.ofPresentationLayer.ofDTO.ofHR.ofEmployee;
using BusinessView.ofViewModels.ofWebApp.ofHR.ofEmployeeRole;
namespace BusinessView.ofViewModels.ofWebApp.ofEmployee.ofHR.ofEmployeeRole
{
    public class EmployeeEmployeeRolePageViewModel : EmployeeRolePageViewModel<EmployeeEmployeeRole> 
    {
        public readonly EmployeePostEmployeeRoleViewModel _EmployeePostEmployeeRoleViewModel;
        public readonly EmployeePutEmployeeRoleViewModel _EmployeePutEmployeeRoleViewModel;
        public readonly EmployeeDeleteEmployeeRoleViewModel _EmployeeDeleteEmployeeRoleViewModel;
        public readonly EmployeeGetsEmployeeRoleViewModel _EmployeeGetsEmployeeRoleViewModel;
        public EmployeeEmployeeRolePageViewModel(EmployeePostEmployeeRoleViewModel employeePostEmployeeRoleViewModel, 
                                        EmployeePutEmployeeRoleViewModel employeePutEmployeeRoleViewModel,
                                        EmployeeDeleteEmployeeRoleViewModel employeeDeleteEmployeeRoleViewModel,
                                        EmployeeGetsEmployeeRoleViewModel employeeGetsEmployeeRoleViewModel)
                :base(employeePostEmployeeRoleViewModel, employeePutEmployeeRoleViewModel, employeeDeleteEmployeeRoleViewModel, employeeGetsEmployeeRoleViewModel)
                    
        {
            _EmployeePostEmployeeRoleViewModel = employeePostEmployeeRoleViewModel;
            _EmployeePutEmployeeRoleViewModel = employeePutEmployeeRoleViewModel;
            _EmployeeDeleteEmployeeRoleViewModel = employeeDeleteEmployeeRoleViewModel;
            _EmployeeGetsEmployeeRoleViewModel = employeeGetsEmployeeRoleViewModel;
        }
    }
}