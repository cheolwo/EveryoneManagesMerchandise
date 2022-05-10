using BusinessView.ofDTO.ofHR.ofEmployer;
using BusinessView.ofViewModels.ofGeneric;

namespace BusinessView.ofViewModels.ofWebApp.ofEmployer.ofHR.ofHRRole
{
    public class EmployerHRRolePageViewModel : EntityPageViewModel<EmployerHRRole> 
    {
        public EmployerHRRolePageViewModel(EmployerPostHRRoleViewModel EmployerPostHRRoleViewModel, 
                                        EmployerPutHRRoleViewModel EmployerPutHRRoleViewModel,
                                        EmployerDeleteHRRoleViewModel EmployerDeleteHRRoleViewModel,
                                        EmployerGetsHRRoleViewModel EmployerGetsHRRoleViewModel)
                :base(EmployerPostHRRoleViewModel, EmployerPutHRRoleViewModel, EmployerDeleteHRRoleViewModel, EmployerGetsHRRoleViewModel)
                    
        {
            
        }
    }
}