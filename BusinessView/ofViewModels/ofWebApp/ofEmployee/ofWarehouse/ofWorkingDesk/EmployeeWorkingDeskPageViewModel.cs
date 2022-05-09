using BusinessView.ofDTO.ofWarehouse.ofEmployee;
using BusinessView.ofViewModels.ofGeneric;

namespace BusinessView.ofViewModels.ofWebApp.ofEmployee.ofWarehouse.ofWorkingDesk
{
    public class EmployeeWorkingDeskPageViewModel : EntityPageViewModel<EmployeeWorkingDesk> 
    {
        public EmployeeWorkingDeskPageViewModel(EmployeePostWorkingDeskViewModel employeePostWorkingDeskViewModel, 
                                        EmployeePutWorkingDeskViewModel employeePutWorkingDeskViewModel,
                                        EmployeeDeleteWorkingDeskViewModel employeeDeleteWorkingDeskViewModel,
                                        EmployeeGetsWorkingDeskViewModel employeeGetsWorkingDeskViewModel)
                :base(employeePostWorkingDeskViewModel, employeePutWorkingDeskViewModel, employeeDeleteWorkingDeskViewModel, employeeGetsWorkingDeskViewModel)
                    
        {
            
        }
    }
}