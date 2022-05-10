using BusinessView.ofDTO.ofHR.ofEmployee;
using BusinessView.ofViewModels.ofGeneric;

namespace BusinessView.ofViewModels.ofWebApp.ofEmployee.ofHR.ofHRBusinessPart
{
    public class EmployeeHRBusinessPartPageViewModel : EntityPageViewModel<EmployeeHRBusinessPart> 
    {
        public EmployeeHRBusinessPartPageViewModel(EmployeePostHRBusinessPartViewModel employeePostHRBusinessPartViewModel, 
                                        EmployeePutHRBusinessPartViewModel employeePutHRBusinessPartViewModel,
                                        EmployeeDeleteHRBusinessPartViewModel employeeDeleteHRBusinessPartViewModel,
                                        EmployeeGetsHRBusinessPartViewModel employeeGetsHRBusinessPartViewModel)
                :base(employeePostHRBusinessPartViewModel, employeePutHRBusinessPartViewModel, employeeDeleteHRBusinessPartViewModel, employeeGetsHRBusinessPartViewModel)
                    
        {
            
        }
    }
}