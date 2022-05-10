using BusinessView.ofTrade.ofEmployee;
using BusinessView.ofViewModels.ofGeneric;

namespace BusinessView.ofViewModels.ofWebApp.ofEmployee.ofTrade.ofTCommodity
{
    public class EmployeeTCommodityPageViewModel : CommodityPageViewModel<EmployeeTCommodity> 
    {
        public EmployeeTCommodityPageViewModel(EmployeePostTCommodityViewModel employeePostTCommodityViewModel, 
                                        EmployeePutTCommodityViewModel employeePutTCommodityViewModel,
                                        EmployeeDeleteTCommodityViewModel employeeDeleteTCommodityViewModel,
                                        EmployeeGetsTCommodityViewModel employeeGetsTCommodityViewModel)
                :base(employeePostTCommodityViewModel, employeePutTCommodityViewModel, employeeDeleteTCommodityViewModel, employeeGetsTCommodityViewModel)
                    
        {
            
        }
    }
}