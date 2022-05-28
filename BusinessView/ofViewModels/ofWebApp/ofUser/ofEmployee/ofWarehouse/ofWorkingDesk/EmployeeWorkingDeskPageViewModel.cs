using BusinessView.ofDTO.ofWarehouse.ofEmployee;
using BusinessView.ofViewModels.ofGeneric;
using BusinessView.ofViewModels.ofWebApp.ofWarehouse.ofWorkingDesk;
namespace BusinessView.ofViewModels.ofWebApp.ofEmployee.ofWarehouse.ofWorkingDesk
{
    public class EmployeeWorkingDeskPageViewModel : WorkingDeskPageViewModel<EmployeeWorkingDesk> 
    {
        public readonly EmployeePostWorkingDeskViewModel _EmployeePostWorkingDeskViewModel;
        public readonly EmployeePutWorkingDeskViewModel _EmployeePutWorkingDeskViewModel;
        public readonly EmployeeDeleteWorkingDeskViewModel _EmployeeDeleteWorkingDeskViewModel;
        public readonly EmployeeGetsWorkingDeskViewModel _EmployeeGetsWorkingDeskViewModel;
        public EmployeeWorkingDeskPageViewModel(EmployeePostWorkingDeskViewModel employeePostWorkingDeskViewModel, 
                                        EmployeePutWorkingDeskViewModel employeePutWorkingDeskViewModel,
                                        EmployeeDeleteWorkingDeskViewModel employeeDeleteWorkingDeskViewModel,
                                        EmployeeGetsWorkingDeskViewModel employeeGetsWorkingDeskViewModel)
                :base(employeePostWorkingDeskViewModel, employeePutWorkingDeskViewModel, employeeDeleteWorkingDeskViewModel, employeeGetsWorkingDeskViewModel)
                    
        {
            _EmployeePostWorkingDeskViewModel = employeePostWorkingDeskViewModel;
            _EmployeePutWorkingDeskViewModel = employeePutWorkingDeskViewModel;
            _EmployeeDeleteWorkingDeskViewModel = employeeDeleteWorkingDeskViewModel;
            _EmployeeGetsWorkingDeskViewModel = employeeGetsWorkingDeskViewModel;
        }
    }
}