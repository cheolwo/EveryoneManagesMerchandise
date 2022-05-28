using BusinessView.ofDTO.ofMarket.ofEmployee;
using BusinessView.ofViewModels.ofGeneric;

namespace BusinessView.ofViewModels.ofWebApp.ofEmployee.ofMarket.ofMMCommodity
{
    public class EmployeeMMCommodityPageViewModel : StatusPageViewModel<EmployeeMMCommodity> 
    {
        public readonly EmployeePostMMCommodityViewModel _EmployeePostMMCommodityViewModel;
        public readonly EmployeePutMMCommodityViewModel _EmployeePutMMCommodityViewModel;
        public readonly EmployeeDeleteMMCommodityViewModel _EmployeeDeleteMMCommodityViewModel;
        public readonly EmployeeGetsMMCommodityViewModel _EmployeeGetsMMCommodityViewModel;
        public EmployeeMMCommodityPageViewModel(EmployeePostMMCommodityViewModel employeePostMMCommodityViewModel, 
                                        EmployeePutMMCommodityViewModel employeePutMMCommodityViewModel,
                                        EmployeeDeleteMMCommodityViewModel employeeDeleteMMCommodityViewModel,
                                        EmployeeGetsMMCommodityViewModel employeeGetsMMCommodityViewModel)
                :base(employeePostMMCommodityViewModel, employeePutMMCommodityViewModel, employeeDeleteMMCommodityViewModel, employeeGetsMMCommodityViewModel)
                    
        {
             _EmployeePostMMCommodityViewModel = employeePostMMCommodityViewModel;
            _EmployeePutMMCommodityViewModel = employeePutMMCommodityViewModel;
            _EmployeeDeleteMMCommodityViewModel = employeeDeleteMMCommodityViewModel;
            _EmployeeGetsMMCommodityViewModel = employeeGetsMMCommodityViewModel;
        }
    }
}