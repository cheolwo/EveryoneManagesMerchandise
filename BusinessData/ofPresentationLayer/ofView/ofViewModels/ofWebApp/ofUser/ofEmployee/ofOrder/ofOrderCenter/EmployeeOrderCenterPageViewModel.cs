using BusinessView.ofViewModels.ofWebApp.ofOrder.ofOrderCenter;
using BusinessData.ofPresentationLayer.ofDTO.ofOrder.ofEmployee;

namespace BusinessView.ofViewModels.ofWebApp.ofEmployee.ofOrder.ofOrderCenter
{
    public class EmployeeOrderCenterPageViewModel : OrderCenterPageViewModel<EmployeeOrderCenter> 
    {
        public readonly EmployeePostOrderCenterViewModel _EmployeePostOrderCenterViewModel;
        public readonly EmployeePutOrderCenterViewModel _EmployeePutOrderCenterViewModel;
        public readonly EmployeeDeleteOrderCenterViewModel _EmployeeDeleteOrderCenterViewModel;
        public readonly EmployeeGetsOrderCenterViewModel _EmployeeGetsOrderCenterViewModel;
        public EmployeeOrderCenterPageViewModel(
            EmployeePostOrderCenterViewModel employeePostOrderCenterViewModel, 
                                        EmployeePutOrderCenterViewModel employeePutOrderCenterViewModel,
                                        EmployeeDeleteOrderCenterViewModel employeeDeleteOrderCenterViewModel,
                                        EmployeeGetsOrderCenterViewModel employeeGetsOrderCenterViewModel)
                :base(employeePostOrderCenterViewModel, employeePutOrderCenterViewModel, employeeDeleteOrderCenterViewModel, employeeGetsOrderCenterViewModel)
                    
        {
            _EmployeePostOrderCenterViewModel = employeePostOrderCenterViewModel;
            _EmployeePutOrderCenterViewModel = employeePutOrderCenterViewModel;
            _EmployeeDeleteOrderCenterViewModel = employeeDeleteOrderCenterViewModel;
            _EmployeeGetsOrderCenterViewModel = employeeGetsOrderCenterViewModel;
        }
    }
}