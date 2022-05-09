using BusinessView.ofDTO.ofProduct.ofEmployee;
using BusinessView.ofViewModels.ofGeneric;

namespace BusinessView.ofViewModels.ofWebApp.ofEmployee.ofProduct.ofPCommodity
{
    public class EmployeePCommodityPageViewModel : CommodityPageViewModel<EmployeePCommodity> 
    {
        public EmployeePCommodityPageViewModel(EmployeePostPCommodityViewModel employeePostPCommodityViewModel, 
                                        EmployeePutPCommodityViewModel employeePutPCommodityViewModel,
                                        EmployeeDeletePCommodityViewModel employeeDeletePCommodityViewModel,
                                        EmployeeGetsPCommodityViewModel employeeGetsPCommodityViewModel)
                :base(employeePostPCommodityViewModel, employeePutPCommodityViewModel, employeeDeletePCommodityViewModel, employeeGetsPCommodityViewModel)
                    
        {
            
        }
    }
}