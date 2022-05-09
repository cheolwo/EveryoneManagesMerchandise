using BusinessView.ofDTO.ofMarket.ofEmployee;
using BusinessView.ofViewModels.ofGeneric;

namespace BusinessView.ofViewModels.ofWebApp.ofEmployee.ofMarket.ofMCommodity
{
    public class EmployeeMCommodityPageViewModel : CommodityPageViewModel<EmployeeMCommodity> 
    {
        public EmployeeMCommodityPageViewModel(EmployeePostMCommodityViewModel employeePostMCommodityViewModel, 
                                        EmployeePutMCommodityViewModel employeePutMCommodityViewModel,
                                        EmployeeDeleteMCommodityViewModel employeeDeleteMCommodityViewModel,
                                        EmployeeGetsMCommodityViewModel employeeGetsMCommodityViewModel)
                :base(employeePostMCommodityViewModel, employeePutMCommodityViewModel, employeeDeleteMCommodityViewModel, employeeGetsMCommodityViewModel)
                    
        {
            
        }
    }
}