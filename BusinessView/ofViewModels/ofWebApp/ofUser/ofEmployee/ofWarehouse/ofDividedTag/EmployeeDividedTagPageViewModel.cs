using BusinessData.ofPresentationLayer.ofDTO.ofWarehouse.ofEmployee;
using BusinessView.ofViewModels.ofWebApp.ofWarehouse.ofDividedTag;
namespace BusinessView.ofViewModels.ofWebApp.ofEmployee.ofWarehouse.ofDividedTag
{
    public class EmployeeDividedTagPageViewModel : DividedTagPageViewModel<EmployeeDividedTag> 
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