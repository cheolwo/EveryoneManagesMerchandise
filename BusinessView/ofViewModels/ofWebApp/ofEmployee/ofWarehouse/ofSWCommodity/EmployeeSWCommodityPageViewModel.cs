using BusinessView.ofDTO.ofWarehouse.ofEmployee;
using BusinessView.ofViewModels.ofGeneric;

namespace BusinessView.ofViewModels.ofWebApp.ofEmployee.ofWarehouse.ofSWCommodity
{
    public class EmployeeSWCommodityPageViewModel : StatusPageViewModel<EmployeeSWCommodity> 
    {
        public EmployeeSWCommodityPageViewModel(EmployeePostSWCommodityViewModel employeePostSWCommodityViewModel, 
                                        EmployeePutSWCommodityViewModel employeePutSWCommodityViewModel,
                                        EmployeeDeleteSWCommodityViewModel employeeDeleteSWCommodityViewModel,
                                        EmployeeGetsSWCommodityViewModel employeeGetsSWCommodityViewModel)
                :base(employeePostSWCommodityViewModel, employeePutSWCommodityViewModel, employeeDeleteSWCommodityViewModel, employeeGetsSWCommodityViewModel)
                    
        {
            
        }
    }
}