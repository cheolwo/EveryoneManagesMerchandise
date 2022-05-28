using BusinessView.ofDTO.ofWarehouse.ofEmployee;
using BusinessView.ofViewModels.ofGeneric;

namespace BusinessView.ofViewModels.ofWebApp.ofEmployee.ofWarehouse.ofDividedTag
{
    public class EmployeeDividedTagPageViewModel : EntityPageViewModel<EmployeeDividedTag> 
    {
        public readonly EmployeePostDividedTagViewModel _EmployeePostDividedTagViewModel;
        public readonly EmployeePutDividedTagViewModel _EmployeePutDividedTagViewModel;
        public readonly EmployeeDeleteDividedTagViewModel _EmployeeDeleteDividedTagViewModel;
        public readonly EmployeeGetsDividedTagViewModel _EmployeeGetsDividedTagViewModel;
        public EmployeeDividedTagPageViewModel(EmployeePostDividedTagViewModel employeePostDividedTagViewModel, 
                                        EmployeePutDividedTagViewModel employeePutDividedTagViewModel,
                                        EmployeeDeleteDividedTagViewModel employeeDeleteDividedTagViewModel,
                                        EmployeeGetsDividedTagViewModel employeeGetsDividedTagViewModel)
                :base(employeePostDividedTagViewModel, employeePutDividedTagViewModel, employeeDeleteDividedTagViewModel, employeeGetsDividedTagViewModel)
                    
        {
            _EmployeePostDividedTagViewModel = employeePostDividedTagViewModel;
            _EmployeePutDividedTagViewModel = employeePutDividedTagViewModel;
            _EmployeeDeleteDividedTagViewModel = employeeDeleteDividedTagViewModel;
            _EmployeeGetsDividedTagViewModel = employeeGetsDividedTagViewModel;
        }
    }
}