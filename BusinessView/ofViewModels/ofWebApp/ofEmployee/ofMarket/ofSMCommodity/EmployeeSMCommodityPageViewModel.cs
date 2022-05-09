using BusinessView.ofDTO.ofMarket.ofEmployee;
using BusinessView.ofViewModels.ofGeneric;

namespace BusinessView.ofViewModels.ofWebApp.ofEmployee.ofMarket.ofSMCommodity
{
    public class EmployeeSMCommodityPageViewModel : StatusPageViewModel<EmployeeSMCommodity> 
    {
        public EmployeeSMCommodityPageViewModel(EmployeePostSMCommodityViewModel employeePostSMCommodityViewModel, 
                                        EmployeePutSMCommodityViewModel employeePutSMCommodityViewModel,
                                        EmployeeDeleteSMCommodityViewModel employeeDeleteSMCommodityViewModel,
                                        EmployeeGetsSMCommodityViewModel employeeGetsSMCommodityViewModel)
                :base(employeePostSMCommodityViewModel, employeePutSMCommodityViewModel, employeeDeleteSMCommodityViewModel, employeeGetsSMCommodityViewModel)
                    
        {
            
        }
    }
}