using BusinessView.ofDTO.ofProduct.ofEmployee;
using BusinessView.ofViewModels.ofGeneric;

namespace BusinessView.ofViewModels.ofWebApp.ofEmployee.ofProduct.ofSPCommodity
{
    public class EmployeeSPCommodityPageViewModel : StatusPageViewModel<EmployeeSPCommodity> 
    {
        public EmployeeSPCommodityPageViewModel(EmployeePostSPCommodityViewModel employeePostSPCommodityViewModel, 
                                        EmployeePutSPCommodityViewModel employeePutSPCommodityViewModel,
                                        EmployeeDeleteSPCommodityViewModel employeeDeleteSPCommodityViewModel,
                                        EmployeeGetsSPCommodityViewModel employeeGetsSPCommodityViewModel)
                :base(employeePostSPCommodityViewModel, employeePutSPCommodityViewModel, employeeDeleteSPCommodityViewModel, employeeGetsSPCommodityViewModel)
                    
        {
            
        }
    }
}