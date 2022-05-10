using BusinessView.ofDTO.ofWarehouse.ofEmployee;
using BusinessView.ofViewModels.ofGeneric;

namespace BusinessView.ofViewModels.ofWebApp.ofEmployee.ofWarehouse.ofWCommodity
{
    public class EmployeeWCommodityPageViewModel : CommodityPageViewModel<EmployeeWCommodity> 
    {
        public EmployeeWCommodityPageViewModel(EmployeePostWCommodityViewModel employeePostWCommodityViewModel, 
                                        EmployeePutWCommodityViewModel employeePutWCommodityViewModel,
                                        EmployeeDeleteWCommodityViewModel employeeDeleteWCommodityViewModel,
                                        EmployeeGetsWCommodityViewModel employeeGetsWCommodityViewModel)
                :base(employeePostWCommodityViewModel, employeePutWCommodityViewModel, employeeDeleteWCommodityViewModel, employeeGetsWCommodityViewModel)
                    
        {
            
        }
    }
}