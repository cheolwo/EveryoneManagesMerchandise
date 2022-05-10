using BusinessView.ofDTO.ofGroupOrder.ofEmployee;
using BusinessView.ofViewModels.ofGeneric;

namespace BusinessView.ofViewModels.ofWebApp.ofEmployee.ofGroupOrder.ofEGOC
{
    public class EmployeeEGOCPageViewModel : StatusPageViewModel<EmployeeEGOC> 
    {
        public EmployeeEGOCPageViewModel(EmployeePostEGOCViewModel employeePostEGOCViewModel, 
                                        EmployeePutEGOCViewModel employeePutEGOCViewModel,
                                        EmployeeDeleteEGOCViewModel employeeDeleteEGOCViewModel,
                                        EmployeeGetsEGOCViewModel employeeGetsEGOCViewModel)
                :base(employeePostEGOCViewModel, employeePutEGOCViewModel, employeeDeleteEGOCViewModel, employeeGetsEGOCViewModel)
                    
        {
            
        }
    }
}