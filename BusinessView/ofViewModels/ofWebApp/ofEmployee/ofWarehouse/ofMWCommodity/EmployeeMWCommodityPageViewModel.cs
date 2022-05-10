using BusinessView.ofDTO.ofWarehouse.ofEmployee;
using BusinessView.ofViewModels.ofGeneric;

namespace BusinessView.ofViewModels.ofWebApp.ofEmployee.ofWarehouse.ofMWCommodity
{
    public class EmployeeMWCommodityPageViewModel : StatusPageViewModel<EmployeeMWCommodity> 
    {
        public EmployeeMWCommodityPageViewModel(EmployeePostMWCommodityViewModel employeePostMWCommodityViewModel, 
                                        EmployeePutMWCommodityViewModel employeePutMWCommodityViewModel,
                                        EmployeeDeleteMWCommodityViewModel employeeDeleteMWCommodityViewModel,
                                        EmployeeGetsMWCommodityViewModel employeeGetsMWCommodityViewModel)
                :base(employeePostMWCommodityViewModel, employeePutMWCommodityViewModel, employeeDeleteMWCommodityViewModel, employeeGetsMWCommodityViewModel)
                    
        {
            
        }
    }
}