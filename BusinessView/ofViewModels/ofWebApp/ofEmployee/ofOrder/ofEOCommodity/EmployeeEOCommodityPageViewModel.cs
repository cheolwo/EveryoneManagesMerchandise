using BusinessView.ofDTO.ofOrder.ofEmployee;
using BusinessView.ofViewModels.ofGeneric;

namespace BusinessView.ofViewModels.ofWebApp.ofEmployee.ofOrder.ofEOCommodity
{
    public class EmployeeEOCommodityPageViewModel : StatusPageViewModel<EmployeeEOCommodity> 
    {
        public EmployeeEOCommodityPageViewModel(EmployeePostEOCommodityViewModel employeePostEOCommodityViewModel, 
                                        EmployeePutEOCommodityViewModel employeePutEOCommodityViewModel,
                                        EmployeeDeleteEOCommodityViewModel employeeDeleteEOCommodityViewModel,
                                        EmployeeGetsEOCommodityViewModel employeeGetsEOCommodityViewModel)
                :base(employeePostEOCommodityViewModel, employeePutEOCommodityViewModel, employeeDeleteEOCommodityViewModel, employeeGetsEOCommodityViewModel)
                    
        {
            
        }
    }
}