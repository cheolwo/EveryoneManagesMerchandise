using BusinessView.ofDTO.ofWarehouse.ofEmployee;
using BusinessView.ofViewModels.ofGeneric;
using BusinessView.ofViewModels.ofWebApp.ofWarehouse.ofLoadFrame;
namespace BusinessView.ofViewModels.ofWebApp.ofEmployee.ofWarehouse.ofLoadFrame
{
    public class EmployeeLoadFramePageViewModel : LoadFramePageViewModel<EmployeeLoadFrame> 
    {
        public readonly EmployeePostLoadFrameViewModel _EmployeePostLoadFrameViewModel;
        public readonly EmployeePutLoadFrameViewModel _EmployeePutLoadFrameViewModel;
        public readonly EmployeeDeleteLoadFrameViewModel _EmployeeDeleteLoadFrameViewModel;
        public readonly EmployeeGetsLoadFrameViewModel _EmployeeGetsLoadFrameViewModel;
        public EmployeeLoadFramePageViewModel(EmployeePostLoadFrameViewModel employeePostLoadFrameViewModel, 
                                        EmployeePutLoadFrameViewModel employeePutLoadFrameViewModel,
                                        EmployeeDeleteLoadFrameViewModel employeeDeleteLoadFrameViewModel,
                                        EmployeeGetsLoadFrameViewModel employeeGetsLoadFrameViewModel)
                :base(employeePostLoadFrameViewModel, employeePutLoadFrameViewModel, employeeDeleteLoadFrameViewModel, employeeGetsLoadFrameViewModel)
                    
        {
            _EmployeePostLoadFrameViewModel = employeePostLoadFrameViewModel;
            _EmployeePutLoadFrameViewModel = employeePutLoadFrameViewModel;
            _EmployeeDeleteLoadFrameViewModel = employeeDeleteLoadFrameViewModel;
            _EmployeeGetsLoadFrameViewModel = employeeGetsLoadFrameViewModel;
        }
    }
}