using BusinessView.ofDTO.ofOrder.ofEmployee;
using BusinessView.ofViewModels.ofGeneric;

namespace BusinessView.ofViewModels.ofWebApp.ofEmployee.ofOrder.ofSOCommodity
{
    public class EmployeeSOCommodityPageViewModel : StatusPageViewModel<EmployeeSOCommodity> 
    {
        public EmployeeSOCommodityPageViewModel(EmployeePostSOCommodityViewModel employeePostSOCommodityViewModel, 
                                        EmployeePutSOCommodityViewModel employeePutSOCommodityViewModel,
                                        EmployeeDeleteSOCommodityViewModel employeeDeleteSOCommodityViewModel,
                                        EmployeeGetsSOCommodityViewModel employeeGetsSOCommodityViewModel)
                :base(employeePostSOCommodityViewModel, employeePutSOCommodityViewModel, employeeDeleteSOCommodityViewModel, employeeGetsSOCommodityViewModel)
                    
        {
            
        }
    }
}