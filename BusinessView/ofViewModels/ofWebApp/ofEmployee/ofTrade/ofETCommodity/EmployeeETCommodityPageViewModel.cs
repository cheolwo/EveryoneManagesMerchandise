using BusinessView.ofTrade.ofEmployee;
using BusinessView.ofViewModels.ofGeneric;

namespace BusinessView.ofViewModels.ofWebApp.ofEmployee.ofTrade.ofETCommodity
{
    public class EmployeeETCommodityPageViewModel : StatusPageViewModel<EmployeeETCommodity> 
    {
        public EmployeeETCommodityPageViewModel(EmployeePostETCommodityViewModel employeePostETCommodityViewModel, 
                                        EmployeePutETCommodityViewModel employeePutETCommodityViewModel,
                                        EmployeeDeleteETCommodityViewModel employeeDeleteETCommodityViewModel,
                                        EmployeeGetsETCommodityViewModel employeeGetsETCommodityViewModel)
                :base(employeePostETCommodityViewModel, employeePutETCommodityViewModel, employeeDeleteETCommodityViewModel, employeeGetsETCommodityViewModel)
                    
        {
            
        }
    }
}