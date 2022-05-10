using BusinessView.ofTrade.ofEmployee;
using BusinessView.ofViewModels.ofGeneric;

namespace BusinessView.ofViewModels.ofWebApp.ofEmployee.ofTrade.ofSTCommodity
{
    public class EmployeeSTCommodityPageViewModel : StatusPageViewModel<EmployeeSTCommodity> 
    {
        public EmployeeSTCommodityPageViewModel(EmployeePostSTCommodityViewModel employeePostSTCommodityViewModel, 
                                        EmployeePutSTCommodityViewModel employeePutSTCommodityViewModel,
                                        EmployeeDeleteSTCommodityViewModel employeeDeleteSTCommodityViewModel,
                                        EmployeeGetsSTCommodityViewModel employeeGetsSTCommodityViewModel)
                :base(employeePostSTCommodityViewModel, employeePutSTCommodityViewModel, employeeDeleteSTCommodityViewModel, employeeGetsSTCommodityViewModel)
                    
        {
            
        }
    }
}