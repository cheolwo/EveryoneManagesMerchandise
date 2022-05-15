using BusinessView.ofTrade.ofEmployee;
using BusinessView.ofViewModels.ofGeneric;

namespace BusinessView.ofViewModels.ofWebApp.ofEmployee.ofTrade.ofTCommodity
{
    public class EmployeeTCommodityPageViewModel : CommodityPageViewModel<EmployeeTCommodity> 
    {
        public readonly EmployeePostTCommodityViewModel _EmployeePostTCommodityViewModel;
        public readonly EmployeePutTCommodityViewModel _EmployeePutTCommodityViewModel;
        public readonly EmployeeDeleteTCommodityViewModel _EmployeeDeleteTCommodityViewModel;
        public readonly EmployeeGetsTCommodityViewModel _EmployeeGetsTCommodityViewModel;
        public EmployeeTCommodityPageViewModel(EmployeePostTCommodityViewModel employeePostTCommodityViewModel, 
                                        EmployeePutTCommodityViewModel employeePutTCommodityViewModel,
                                        EmployeeDeleteTCommodityViewModel employeeDeleteTCommodityViewModel,
                                        EmployeeGetsTCommodityViewModel employeeGetsTCommodityViewModel)
                :base(employeePostTCommodityViewModel, employeePutTCommodityViewModel, employeeDeleteTCommodityViewModel, employeeGetsTCommodityViewModel)
                    
        {
            _EmployeePostTCommodityViewModel = employeePostTCommodityViewModel;
            _EmployeePutTCommodityViewModel = employeePutTCommodityViewModel;
            _EmployeeDeleteTCommodityViewModel = employeeDeleteTCommodityViewModel;
            _EmployeeGetsTCommodityViewModel = employeeGetsTCommodityViewModel;
        }
    }
}