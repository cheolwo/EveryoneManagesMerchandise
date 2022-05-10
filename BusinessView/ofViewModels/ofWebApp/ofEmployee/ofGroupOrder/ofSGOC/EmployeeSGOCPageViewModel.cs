using BusinessView.ofDTO.ofGroupOrder.ofEmployee;
using BusinessView.ofViewModels.ofGeneric;

namespace BusinessView.ofViewModels.ofWebApp.ofEmployee.ofGroupOrder.ofSGOC
{
    public class EmployeeSGOCPageViewModel : StatusPageViewModel<EmployeeSGOC> 
    {
        public EmployeeSGOCPageViewModel(EmployeePostSGOCViewModel employeePostSGOCViewModel, 
                                        EmployeePutSGOCViewModel employeePutSGOCViewModel,
                                        EmployeeDeleteSGOCViewModel employeeDeleteSGOCViewModel,
                                        EmployeeGetsSGOCViewModel employeeGetsSGOCViewModel)
                :base(employeePostSGOCViewModel, employeePutSGOCViewModel, employeeDeleteSGOCViewModel, employeeGetsSGOCViewModel)
                    
        {
            
        }
    }
}