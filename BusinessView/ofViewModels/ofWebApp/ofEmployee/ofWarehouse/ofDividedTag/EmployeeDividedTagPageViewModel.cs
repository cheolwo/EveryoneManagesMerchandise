using BusinessView.ofDTO.ofWarehouse.ofEmployee;
using BusinessView.ofViewModels.ofGeneric;

namespace BusinessView.ofViewModels.ofWebApp.ofEmployee.ofWarehouse.ofDividedTag
{
    public class EmployeeDividedTagPageViewModel : EntityPageViewModel<EmployeeDividedTag> 
    {
        public EmployeeDividedTagPageViewModel(EmployeePostDividedTagViewModel employeePostDividedTagViewModel, 
                                        EmployeePutDividedTagViewModel employeePutDividedTagViewModel,
                                        EmployeeDeleteDividedTagViewModel employeeDeleteDividedTagViewModel,
                                        EmployeeGetsDividedTagViewModel employeeGetsDividedTagViewModel)
                :base(employeePostDividedTagViewModel, employeePutDividedTagViewModel, employeeDeleteDividedTagViewModel, employeeGetsDividedTagViewModel)
                    
        {
            
        }
    }
}