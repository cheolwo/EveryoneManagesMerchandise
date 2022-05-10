using BusinessView.ofDTO.ofOrder.ofEmployee;
using BusinessView.ofViewModels.ofGeneric;

namespace BusinessView.ofViewModels.ofWebApp.ofEmployee.ofOrder.ofMOCommodity
{
    public class EmployeeMOCommodityPageViewModel : StatusPageViewModel<EmployeeMOCommodity> 
    {
        public EmployeeMOCommodityPageViewModel(EmployeePostMOCommodityViewModel employeePostMOCommodityViewModel, 
                                        EmployeePutMOCommodityViewModel employeePutMOCommodityViewModel,
                                        EmployeeDeleteMOCommodityViewModel employeeDeleteMOCommodityViewModel,
                                        EmployeeGetsMOCommodityViewModel employeeGetsMOCommodityViewModel)
                :base(employeePostMOCommodityViewModel, employeePutMOCommodityViewModel, employeeDeleteMOCommodityViewModel, employeeGetsMOCommodityViewModel)
                    
        {
            
        }
    }
}