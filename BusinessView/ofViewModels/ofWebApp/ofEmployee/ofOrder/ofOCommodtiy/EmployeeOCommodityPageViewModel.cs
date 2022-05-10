using BusinessView.ofDTO.ofOrder.ofEmployee;
using BusinessView.ofViewModels.ofGeneric;

namespace BusinessView.ofViewModels.ofWebApp.ofEmployee.ofOrder.ofOCommodity
{
    public class EmployeeOCommodityPageViewModel : CommodityPageViewModel<EmployeeOCommodity> 
    {
        public EmployeeOCommodityPageViewModel(EmployeePostOCommodityViewModel employeePostOCommodityViewModel, 
                                        EmployeePutOCommodityViewModel employeePutOCommodityViewModel,
                                        EmployeeDeleteOCommodityViewModel employeeDeleteOCommodityViewModel,
                                        EmployeeGetsOCommodityViewModel employeeGetsOCommodityViewModel)
                :base(employeePostOCommodityViewModel, employeePutOCommodityViewModel, employeeDeleteOCommodityViewModel, employeeGetsOCommodityViewModel)
                    
        {
            
        }
    }
}