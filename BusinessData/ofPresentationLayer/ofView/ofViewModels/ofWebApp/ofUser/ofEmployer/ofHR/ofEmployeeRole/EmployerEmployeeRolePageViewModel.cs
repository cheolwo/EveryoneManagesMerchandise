using BusinessData.ofPresentationLayer.ofDTO.ofHR.ofEmployer;
using BusinessView.ofViewModels.ofWebApp.ofHR.ofEmployeeRole;

namespace BusinessView.ofViewModels.ofWebApp.ofEmployer.ofHR.ofEmployeeRole
{
    public class EmployerEmployeeRolePageViewModel : EmployeeRolePageViewModel<EmployerEmployeeRole> 
    {
        public readonly EmployerPostEmployeeRoleViewModel _EmployerPostEmployeeRoleViewModel;
        public readonly EmployerPutEmployeeRoleViewModel _EmployerPutEmployeeRoleViewModel;
        public readonly EmployerDeleteEmployeeRoleViewModel _EmployerDeleteEmployeeRoleViewModel;
        public readonly EmployerGetsEmployeeRoleViewModel _EmployerGetsEmployeeRoleViewModel;

        public EmployerEmployeeRolePageViewModel(EmployerPostEmployeeRoleViewModel EmployerPostEmployeeRoleViewModel, 
                                        EmployerPutEmployeeRoleViewModel EmployerPutEmployeeRoleViewModel,
                                        EmployerDeleteEmployeeRoleViewModel EmployerDeleteEmployeeRoleViewModel,
                                        EmployerGetsEmployeeRoleViewModel EmployerGetsEmployeeRoleViewModel)
                :base(EmployerPostEmployeeRoleViewModel, EmployerPutEmployeeRoleViewModel, EmployerDeleteEmployeeRoleViewModel, EmployerGetsEmployeeRoleViewModel)
                    
        {
            _EmployerPostEmployeeRoleViewModel = EmployerPostEmployeeRoleViewModel;
            _EmployerPutEmployeeRoleViewModel = EmployerPutEmployeeRoleViewModel;
            _EmployerDeleteEmployeeRoleViewModel = EmployerDeleteEmployeeRoleViewModel;
            _EmployerGetsEmployeeRoleViewModel = EmployerGetsEmployeeRoleViewModel;
        }
    }
}