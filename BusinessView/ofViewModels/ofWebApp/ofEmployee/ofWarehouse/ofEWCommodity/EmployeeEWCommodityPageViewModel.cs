using BusinessView.ofDTO.ofWarehouse.ofEmployee;
using BusinessView.ofViewModels.ofGeneric;

namespace BusinessView.ofViewModels.ofWebApp.ofEmployee.ofWarehouse.ofEWCommodity
{
    public class EmployeeEWCommodityPageViewModel : StatusPageViewModel<EmployeeEWCommodity> 
    {
        public EmployeeEWCommodityPageViewModel(EmployeePostEWCommodityViewModel employeePostEWCommodityViewModel, 
                                        EmployeePutEWCommodityViewModel employeePutEWCommodityViewModel,
                                        EmployeeDeleteEWCommodityViewModel employeeDeleteEWCommodityViewModel,
                                        EmployeeGetsEWCommodityViewModel employeeGetsEWCommodityViewModel)
                :base(employeePostEWCommodityViewModel, employeePutEWCommodityViewModel, employeeDeleteEWCommodityViewModel, employeeGetsEWCommodityViewModel)
                    
        {
            
        }
    }
}