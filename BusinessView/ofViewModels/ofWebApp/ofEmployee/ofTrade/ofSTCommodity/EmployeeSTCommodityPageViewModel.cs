using BusinessView.ofTrade.ofEmployee;
using BusinessView.ofViewModels.ofGeneric;

namespace BusinessView.ofViewModels.ofWebApp.ofEmployee.ofTrade.ofSTCommodity
{
    public class EmployeeSTCommodityPageViewModel : StatusPageViewModel<EmployeeSTCommodity> 
    {
        public readonly EmployeePostSTCommodityViewModel _EmployeePostSTCommodityViewModel;
        public readonly EmployeePutSTCommodityViewModel _EmployeePutSTCommodityViewModel;
        public readonly EmployeeDeleteSTCommodityViewModel _EmployeeDeleteSTCommodityViewModel;
        public readonly EmployeeGetsSTCommodityViewModel _EmployeeGetsSTCommodityViewModel;
        public EmployeeSTCommodityPageViewModel(EmployeePostSTCommodityViewModel employeePostSTCommodityViewModel, 
                                        EmployeePutSTCommodityViewModel employeePutSTCommodityViewModel,
                                        EmployeeDeleteSTCommodityViewModel employeeDeleteSTCommodityViewModel,
                                        EmployeeGetsSTCommodityViewModel employeeGetsSTCommodityViewModel)
                :base(employeePostSTCommodityViewModel, employeePutSTCommodityViewModel, employeeDeleteSTCommodityViewModel, employeeGetsSTCommodityViewModel)
                    
        {
            _EmployeePostSTCommodityViewModel = employeePostSTCommodityViewModel;
            _EmployeePutSTCommodityViewModel = employeePutSTCommodityViewModel;
            _EmployeeDeleteSTCommodityViewModel = employeeDeleteSTCommodityViewModel;
            _EmployeeGetsSTCommodityViewModel = employeeGetsSTCommodityViewModel;
        }
    }
}