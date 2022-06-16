using BusinessData.ofPresentationLayer.ofDTO.ofHR.ofEmployer;
using BusinessView.ofViewModels.ofWebApp.ofHR.ofHRRole;

namespace BusinessView.ofViewModels.ofWebApp.ofEmployer.ofHR.ofHRRole
{
    public class EmployerHRRolePageViewModel : HRRolePageViewModel<EmployerHRRole> 
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