using BusinessView.ofDTO.ofHR.ofEmployer;
using BusinessView.ofViewModels.ofGeneric;
using BusinessView.ofViewModels.ofWebApp.ofHR.ofHRCenter;

namespace BusinessView.ofViewModels.ofWebApp.ofEmployer.ofHR.ofHRCenter
{
    public class EmployerHRCenterPageViewModel : HRCenterPageViewModel<EmployerHRCenter> 
    {
        public readonly EmployerPostHRCenterViewModel _EmployerPostHRCenterViewModel;
        public readonly EmployerPutHRCenterViewModel _EmployerPutHRCenterViewModel;
        public readonly EmployerDeleteHRCenterViewModel _EmployerDeleteHRCenterViewModel;
        public readonly EmployerGetsHRCenterViewModel _EmployerGetsHRCenterViewModel;

        public EmployerHRCenterPageViewModel(EmployerPostHRCenterViewModel EmployerPostHRCenterViewModel, 
                                        EmployerPutHRCenterViewModel EmployerPutHRCenterViewModel,
                                        EmployerDeleteHRCenterViewModel EmployerDeleteHRCenterViewModel,
                                        EmployerGetsHRCenterViewModel EmployerGetsHRCenterViewModel)
                :base(EmployerPostHRCenterViewModel, EmployerPutHRCenterViewModel, EmployerDeleteHRCenterViewModel, EmployerGetsHRCenterViewModel)
                    
        {
            _EmployerPostHRCenterViewModel = EmployerPostHRCenterViewModel;
            _EmployerPutHRCenterViewModel = EmployerPutHRCenterViewModel;
            _EmployerDeleteHRCenterViewModel = EmployerDeleteHRCenterViewModel;
            _EmployerGetsHRCenterViewModel = EmployerGetsHRCenterViewModel;
        }
    }
}