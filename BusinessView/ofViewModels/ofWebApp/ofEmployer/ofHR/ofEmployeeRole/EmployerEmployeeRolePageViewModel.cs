using BusinessView.ofDTO.ofHR.ofEmployer;
using BusinessView.ofViewModels.ofGeneric;

namespace BusinessView.ofViewModels.ofWebApp.ofEmployer.ofHR.ofEmployeeRole
{
    public class EmployerEmployeeRolePageViewModel : EntityPageViewModel<EmployerEmployeeRole> 
    {
        public EmployerEmployeeRolePageViewModel(EmployerPostEmployeeRoleViewModel EmployerPostEmployeeRoleViewModel, 
                                        EmployerPutEmployeeRoleViewModel EmployerPutEmployeeRoleViewModel,
                                        EmployerDeleteEmployeeRoleViewModel EmployerDeleteEmployeeRoleViewModel,
                                        EmployerGetsEmployeeRoleViewModel EmployerGetsEmployeeRoleViewModel)
                :base(EmployerPostEmployeeRoleViewModel, EmployerPutEmployeeRoleViewModel, EmployerDeleteEmployeeRoleViewModel, EmployerGetsEmployeeRoleViewModel)
                    
        {
            
        }
    }
}