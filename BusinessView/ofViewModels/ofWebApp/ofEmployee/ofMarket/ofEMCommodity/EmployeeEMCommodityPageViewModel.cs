using BusinessView.ofDTO.ofMarket.ofEmployee;
using BusinessView.ofViewModels.ofGeneric;

namespace BusinessView.ofViewModels.ofWebApp.ofEmployee.ofMarket.ofEMCommodity
{
    public class EmployeeEMCommodityPageViewModel : StatusPageViewModel<EmployeeEMCommodity> 
    {
        public EmployeeEMCommodityPageViewModel(EmployeePostEMCommodityViewModel employeePostEMCommodityViewModel, 
                                        EmployeePutEMCommodityViewModel employeePutEMCommodityViewModel,
                                        EmployeeDeleteEMCommodityViewModel employeeDeleteEMCommodityViewModel,
                                        EmployeeGetsEMCommodityViewModel employeeGetsEMCommodityViewModel)
                :base(employeePostEMCommodityViewModel, employeePutEMCommodityViewModel, employeeDeleteEMCommodityViewModel, employeeGetsEMCommodityViewModel)
                    
        {
            
        }
    }
}