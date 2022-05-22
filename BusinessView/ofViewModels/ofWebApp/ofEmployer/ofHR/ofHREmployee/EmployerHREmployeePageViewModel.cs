using BusinessView.ofDTO.ofHR.ofEmployer;
using BusinessView.ofViewModels.ofGeneric;

namespace BusinessView.ofViewModels.ofWebApp.ofEmployer.ofHR.ofHREmployee
{
    public class EmployerHREmployeePageViewModel : EmployerPageViewModel<EmployerHREmployee> 
    {
        public readonly EmployerPostHREmployeeViewModel _EmployerPostHREmployeeViewModel;
        public readonly EmployerPutHREmployeeViewModel _EmployerPutHREmployeeViewModel;
        public readonly EmployerDeleteHREmployeeViewModel _EmployerDeleteHREmployeeViewModel;
        public readonly EmployerGetsHREmployeeViewModel _EmployerGetsHREmployeeViewModel;
        public EmployerHREmployeePageViewModel(EmployerPostHREmployeeViewModel EmployerPostHREmployeeViewModel, 
                                        EmployerPutHREmployeeViewModel EmployerPutHREmployeeViewModel,
                                        EmployerDeleteHREmployeeViewModel EmployerDeleteHREmployeeViewModel,
                                        EmployerGetsHREmployeeViewModel EmployerGetsHREmployeeViewModel)
                :base(EmployerPostHREmployeeViewModel, EmployerPutHREmployeeViewModel, EmployerDeleteHREmployeeViewModel, EmployerGetsHREmployeeViewModel)
                    
        {
            _EmployerPostHREmployeeViewModel = EmployerPostHREmployeeViewModel;
            _EmployerPutHREmployeeViewModel = EmployerPutHREmployeeViewModel;
            _EmployerDeleteHREmployeeViewModel = EmployerDeleteHREmployeeViewModel;
            _EmployerGetsHREmployeeViewModel = EmployerGetsHREmployeeViewModel;
        }
    }
}