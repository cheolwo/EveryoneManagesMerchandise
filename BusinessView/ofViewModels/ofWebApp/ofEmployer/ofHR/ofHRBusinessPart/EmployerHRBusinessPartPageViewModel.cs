using BusinessView.ofDTO.ofHR.ofEmployer;
using BusinessView.ofViewModels.ofGeneric;

namespace BusinessView.ofViewModels.ofWebApp.ofEmployer.ofHR.ofHRBusinessPart
{
    public class EmployerHRBusinessPartPageViewModel : EntityPageViewModel<EmployerHRBusinessPart> 
    {
        public EmployerHRBusinessPartPageViewModel(EmployerPostHRBusinessPartViewModel EmployerPostHRBusinessPartViewModel, 
                                        EmployerPutHRBusinessPartViewModel EmployerPutHRBusinessPartViewModel,
                                        EmployerDeleteHRBusinessPartViewModel EmployerDeleteHRBusinessPartViewModel,
                                        EmployerGetsHRBusinessPartViewModel EmployerGetsHRBusinessPartViewModel)
                :base(EmployerPostHRBusinessPartViewModel, EmployerPutHRBusinessPartViewModel, EmployerDeleteHRBusinessPartViewModel, EmployerGetsHRBusinessPartViewModel)
                    
        {
            
        }
    }
}