using BusinessView.ofDTO.ofJournal.ofEmployee;
using BusinessView.ofViewModels.ofGeneric;

namespace BusinessView.ofViewModels.ofWebApp.ofEmployee.ofJournal.ofJCommodity
{
    public class EmployeeJCommodityPageViewModel : CommodityPageViewModel<EmployeeJCommodity> 
    {
        public EmployeeJCommodityPageViewModel(EmployeePostJCommodityViewModel employeePostJCommodityViewModel, 
                                        EmployeePutJCommodityViewModel employeePutJCommodityViewModel,
                                        EmployeeDeleteJCommodityViewModel employeeDeleteJCommodityViewModel,
                                        EmployeeGetsJCommodityViewModel employeeGetsJCommodityViewModel)
                :base(employeePostJCommodityViewModel, employeePutJCommodityViewModel, employeeDeleteJCommodityViewModel, employeeGetsJCommodityViewModel)
                    
        {
            
        }
    }
}