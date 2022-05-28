using BusinessView.ofDTO.ofOrder.ofEmployee;
using BusinessView.ofViewModels.ofGeneric;
using BusinessView.ofViewModels.ofWebApp.ofOrder.ofSOCommodity;
namespace BusinessView.ofViewModels.ofWebApp.ofEmployee.ofOrder.ofSOCommodity
{
    public class EmployeeSOCommodityPageViewModel : SOCommodityPageViewModel<EmployeeSOCommodity> 
    {
        public readonly EmployeePostSOCommodityViewModel _EmployeePostSOCommodityViewModel;
        public readonly EmployeePutSOCommodityViewModel _EmployeePutSOCommodityViewModel;
        public readonly EmployeeDeleteSOCommodityViewModel _EmployeeDeleteSOCommodityViewModel;
        public readonly EmployeeGetsSOCommodityViewModel _EmployeeGetsSOCommodityViewModel;
        public EmployeeSOCommodityPageViewModel(EmployeePostSOCommodityViewModel employeePostSOCommodityViewModel, 
                                        EmployeePutSOCommodityViewModel employeePutSOCommodityViewModel,
                                        EmployeeDeleteSOCommodityViewModel employeeDeleteSOCommodityViewModel,
                                        EmployeeGetsSOCommodityViewModel employeeGetsSOCommodityViewModel)
                :base(employeePostSOCommodityViewModel, employeePutSOCommodityViewModel, employeeDeleteSOCommodityViewModel, employeeGetsSOCommodityViewModel)
                    
        {
            _EmployeePostSOCommodityViewModel = employeePostSOCommodityViewModel;
            _EmployeePutSOCommodityViewModel = employeePutSOCommodityViewModel;
            _EmployeeDeleteSOCommodityViewModel = employeeDeleteSOCommodityViewModel;
            _EmployeeGetsSOCommodityViewModel = employeeGetsSOCommodityViewModel;
        }
    }
}