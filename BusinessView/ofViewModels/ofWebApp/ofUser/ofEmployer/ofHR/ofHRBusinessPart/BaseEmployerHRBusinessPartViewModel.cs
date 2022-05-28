using BusinessView.ofCommon.ofUser;
using BusinessView.ofViewModels.ofGeneric.ofCommon;
using BusinessView.ofDTO.ofHR.ofEmployer;
using BusinessView.ofViewModels.ofGeneric;

namespace BusinessView.ofViewModels.ofWebApp.ofEmployer.ofHR
{
    public class EmployerPostHRBusinessPartViewModel : EmployerPostViewModel<EmployerHRBusinessPart>
    {
        public EmployerPostHRBusinessPartViewModel(EmployerActorContext EmployerActorContext)
            : base(EmployerActorContext)
        {

        }
    }
    public class EmployerPutHRBusinessPartViewModel : EmployerPutViewModel<EmployerHRBusinessPart>
    {
        public EmployerPutHRBusinessPartViewModel(EmployerActorContext EmployerActorContext)
            :base(EmployerActorContext)
        {

        }
    }
    public class EmployerDeleteHRBusinessPartViewModel : EmployerDeleteViewModel<EmployerHRBusinessPart>
    {
        public EmployerDeleteHRBusinessPartViewModel(EmployerActorContext EmployerActorContext)
            :base(EmployerActorContext)
        {

        }
    }
    public class EmployerGetsHRBusinessPartViewModel : EmployerGetsViewModel<EmployerHRBusinessPart>
    {
        public EmployerGetsHRBusinessPartViewModel(EmployerActorContext EmployerActorContext)
            :base(EmployerActorContext)
        {

        }
    }
}
