using BusinessView.ofDTO.ofWarehouse.ofEmployee;
using BusinessView.ofViewModels.ofGeneric;

namespace BusinessView.ofViewModels.ofWebApp.ofEmployee.ofWarehouse.ofLoadFrame
{
    public class EmployeeLoadFramePageViewModel : EntityPageViewModel<EmployeeLoadFrame> 
    {
        public EmployeeLoadFramePageViewModel(EmployeePostLoadFrameViewModel employeePostLoadFrameViewModel, 
                                        EmployeePutLoadFrameViewModel employeePutLoadFrameViewModel,
                                        EmployeeDeleteLoadFrameViewModel employeeDeleteLoadFrameViewModel,
                                        EmployeeGetsLoadFrameViewModel employeeGetsLoadFrameViewModel)
                :base(employeePostLoadFrameViewModel, employeePutLoadFrameViewModel, employeeDeleteLoadFrameViewModel, employeeGetsLoadFrameViewModel)
                    
        {
            
        }
    }
}