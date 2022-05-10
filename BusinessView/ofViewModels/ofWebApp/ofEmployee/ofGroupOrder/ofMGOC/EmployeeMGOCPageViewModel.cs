using BusinessView.ofDTO.ofGroupOrder.ofEmployee;
using BusinessView.ofViewModels.ofGeneric;

namespace BusinessView.ofViewModels.ofWebApp.ofEmployee.ofGroupOrder.ofMGOC
{
    public class EmployeeMGOCPageViewModel : StatusPageViewModel<EmployeeMGOC> 
    {
        public EmployeeMGOCPageViewModel(EmployeePostMGOCViewModel employeePostMGOCViewModel, 
                                        EmployeePutMGOCViewModel employeePutMGOCViewModel,
                                        EmployeeDeleteMGOCViewModel employeeDeleteMGOCViewModel,
                                        EmployeeGetsMGOCViewModel employeeGetsMGOCViewModel)
                :base(employeePostMGOCViewModel, employeePutMGOCViewModel, employeeDeleteMGOCViewModel, employeeGetsMGOCViewModel)
                    
        {
            
        }
    }
}