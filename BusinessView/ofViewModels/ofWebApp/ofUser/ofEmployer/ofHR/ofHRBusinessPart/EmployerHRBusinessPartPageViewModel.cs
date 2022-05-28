using BusinessView.ofDTO.ofHR.ofEmployer;
using BusinessView.ofViewModels.ofGeneric;
using BusinessView.ofViewModels.ofWebApp.ofHR.ofHRBusinessPart;

namespace BusinessView.ofViewModels.ofWebApp.ofEmployer.ofHR.ofHRBusinessPart
{
    public class EmployerHRBusinessPartPageViewModel : HRBusinessPartPageViewModel<EmployerHRBusinessPart> 
    {
        public readonly EmployerPostHRBusinessPartViewModel _EmployerPostHRBusinessPartViewModel;
        public readonly EmployerPutHRBusinessPartViewModel _EmployerPutHRBusinessPartViewModel;
        public readonly EmployerDeleteHRBusinessPartViewModel _EmployerDeleteHRBusinessPartViewModel;
        public readonly EmployerGetsHRBusinessPartViewModel _EmployerGetsHRBusinessPartViewModel;

        public EmployerHRBusinessPartPageViewModel(EmployerPostHRBusinessPartViewModel EmployerPostHRBusinessPartViewModel, 
                                        EmployerPutHRBusinessPartViewModel EmployerPutHRBusinessPartViewModel,
                                        EmployerDeleteHRBusinessPartViewModel EmployerDeleteHRBusinessPartViewModel,
                                        EmployerGetsHRBusinessPartViewModel EmployerGetsHRBusinessPartViewModel)
                :base(EmployerPostHRBusinessPartViewModel, EmployerPutHRBusinessPartViewModel, EmployerDeleteHRBusinessPartViewModel, EmployerGetsHRBusinessPartViewModel)
                    
        {
            _EmployerPostHRBusinessPartViewModel = EmployerPostHRBusinessPartViewModel;
            _EmployerPutHRBusinessPartViewModel = EmployerPutHRBusinessPartViewModel;
            _EmployerDeleteHRBusinessPartViewModel = EmployerDeleteHRBusinessPartViewModel;
            _EmployerGetsHRBusinessPartViewModel = EmployerGetsHRBusinessPartViewModel;
        }
    }
}