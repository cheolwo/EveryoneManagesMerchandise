using BusinessView.ofDTO.ofWarehouse.ofEmployee;
using BusinessView.ofViewModels.ofGeneric;

namespace BusinessView.ofViewModels.ofWebApp.ofEmployee.ofWarehouse.ofIncomingTag
{
    public class EmployeeIncomingTagPageViewModel : EntityPageViewModel<EmployeeIncomingTag> 
    {
        public EmployeeIncomingTagPageViewModel(EmployeePostIncomingTagViewModel employeePostIncomingTagViewModel, 
                                        EmployeePutIncomingTagViewModel employeePutIncomingTagViewModel,
                                        EmployeeDeleteIncomingTagViewModel employeeDeleteIncomingTagViewModel,
                                        EmployeeGetsIncomingTagViewModel employeeGetsIncomingTagViewModel)
                :base(employeePostIncomingTagViewModel, employeePutIncomingTagViewModel, employeeDeleteIncomingTagViewModel, employeeGetsIncomingTagViewModel)
                    
        {
            
        }
    }
}