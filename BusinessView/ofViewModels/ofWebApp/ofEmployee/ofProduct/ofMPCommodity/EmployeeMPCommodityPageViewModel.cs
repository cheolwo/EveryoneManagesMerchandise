using BusinessView.ofDTO.ofProduct.ofEmployee;
using BusinessView.ofViewModels.ofGeneric;

namespace BusinessView.ofViewModels.ofWebApp.ofEmployee.ofProduct.ofMPCommodity
{
    public class EmployeeMPCommodityPageViewModel : StatusPageViewModel<EmployeeMPCommodity> 
    {
        public EmployeeMPCommodityPageViewModel(EmployeePostMPCommodityViewModel employeePostMPCommodityViewModel, 
                                        EmployeePutMPCommodityViewModel employeePutMPCommodityViewModel,
                                        EmployeeDeleteMPCommodityViewModel employeeDeleteMPCommodityViewModel,
                                        EmployeeGetsMPCommodityViewModel employeeGetsMPCommodityViewModel)
                :base(employeePostMPCommodityViewModel, employeePutMPCommodityViewModel, employeeDeleteMPCommodityViewModel, employeeGetsMPCommodityViewModel)
                    
        {
            
        }
    }
}