using BusinessView.ofDTO.ofGroupOrder.ofEmployee;
using BusinessView.ofViewModels.ofGeneric;

namespace BusinessView.ofViewModels.ofWebApp.ofEmployee.ofGroupOrder.ofGOCC
{
    public class EmployeeGOCCPageViewModel : CommodityPageViewModel<EmployeeGOCC> 
    {
        public EmployeeGOCCPageViewModel(EmployeePostGOCCViewModel employeePostGOCCViewModel, 
                                        EmployeePutGOCCViewModel employeePutGOCCViewModel,
                                        EmployeeDeleteGOCCViewModel employeeDeleteGOCCViewModel,
                                        EmployeeGetsGOCCViewModel employeeGetsGOCCViewModel)
                :base(employeePostGOCCViewModel, employeePutGOCCViewModel, employeeDeleteGOCCViewModel, employeeGetsGOCCViewModel)
                    
        {
            
        }
    }
}