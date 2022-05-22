using BusinessView.ofDTO.ofHR.ofEmployer;
using BusinessView.ofViewModels.ofGeneric;

namespace BusinessView.ofViewModels.ofWebApp.ofEmployer.ofHR.ofHRRole
{
    public class EmployerHRRolePageViewModel : EmployerPageViewModel<EmployerHRRole> 
    {
        public readonly EmployerPostHRRoleViewModel _EmployerPostHRRoleViewModel;
        public readonly EmployerPutHRRoleViewModel _EmployerPutHRRoleViewModel;
        public readonly EmployerDeleteHRRoleViewModel _EmployerDeleteHRRoleViewModel;
        public readonly EmployerGetsHRRoleViewModel _EmployerGetsHRRoleViewModel;
        public EmployerHRRolePageViewModel(EmployerPostHRRoleViewModel EmployerPostHRRoleViewModel, 
                                        EmployerPutHRRoleViewModel EmployerPutHRRoleViewModel,
                                        EmployerDeleteHRRoleViewModel EmployerDeleteHRRoleViewModel,
                                        EmployerGetsHRRoleViewModel EmployerGetsHRRoleViewModel)
                :base(EmployerPostHRRoleViewModel, EmployerPutHRRoleViewModel, EmployerDeleteHRRoleViewModel, EmployerGetsHRRoleViewModel)
                    
        {
            _EmployerPostHRRoleViewModel = EmployerPostHRRoleViewModel;
            _EmployerPutHRRoleViewModel = EmployerPutHRRoleViewModel;
            _EmployerDeleteHRRoleViewModel = EmployerDeleteHRRoleViewModel;
            _EmployerGetsHRRoleViewModel = EmployerGetsHRRoleViewModel;
        }
    }
}