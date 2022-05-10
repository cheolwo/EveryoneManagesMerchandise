using BusinessView.ofDTO.ofMarket.ofEmployee;
using BusinessView.ofViewModels.ofGeneric;

namespace BusinessView.ofViewModels.ofWebApp.ofEmployee.ofMarket.ofMMCommodity
{
    public class EmployeeMMCommodityPageViewModel : StatusPageViewModel<EmployeeMMCommodity> 
    {
        public EmployeeMMCommodityPageViewModel(EmployeePostMMCommodityViewModel employeePostMMCommodityViewModel, 
                                        EmployeePutMMCommodityViewModel employeePutMMCommodityViewModel,
                                        EmployeeDeleteMMCommodityViewModel employeeDeleteMMCommodityViewModel,
                                        EmployeeGetsMMCommodityViewModel employeeGetsMMCommodityViewModel)
                :base(employeePostMMCommodityViewModel, employeePutMMCommodityViewModel, employeeDeleteMMCommodityViewModel, employeeGetsMMCommodityViewModel)
                    
        {
            
        }
    }
}