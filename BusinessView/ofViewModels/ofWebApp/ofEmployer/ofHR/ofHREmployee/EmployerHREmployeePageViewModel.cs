using BusinessView.ofDTO.ofHR.ofEmployer;
using BusinessView.ofViewModels.ofGeneric;

namespace BusinessView.ofViewModels.ofWebApp.ofEmployer.ofHR.ofHREmployee
{
    public class EmployerHREmployeePageViewModel : EntityPageViewModel<EmployerHREmployee> 
    {
        public EmployerHREmployeePageViewModel(EmployerPostHREmployeeViewModel EmployerPostHREmployeeViewModel, 
                                        EmployerPutHREmployeeViewModel EmployerPutHREmployeeViewModel,
                                        EmployerDeleteHREmployeeViewModel EmployerDeleteHREmployeeViewModel,
                                        EmployerGetsHREmployeeViewModel EmployerGetsHREmployeeViewModel)
                :base(EmployerPostHREmployeeViewModel, EmployerPutHREmployeeViewModel, EmployerDeleteHREmployeeViewModel, EmployerGetsHREmployeeViewModel)
                    
        {
            
        }
    }
}