using BusinessView.ofDTO.ofProduct.ofEmployee;
using BusinessView.ofViewModels.ofGeneric;

namespace BusinessView.ofViewModels.ofWebApp.ofEmployee.ofProduct.ofEPCommodity
{
    public class EmployeeEPCommodityPageViewModel : StatusPageViewModel<EmployeeEPCommodity> 
    {
        public EmployeeEPCommodityPageViewModel(EmployeePostEPCommodityViewModel employeePostEPCommodityViewModel, 
                                        EmployeePutEPCommodityViewModel employeePutEPCommodityViewModel,
                                        EmployeeDeleteEPCommodityViewModel employeeDeleteEPCommodityViewModel,
                                        EmployeeGetsEPCommodityViewModel employeeGetsEPCommodityViewModel)
                :base(employeePostEPCommodityViewModel, employeePutEPCommodityViewModel, employeeDeleteEPCommodityViewModel, employeeGetsEPCommodityViewModel)
                    
        {
            
        }
    }
}