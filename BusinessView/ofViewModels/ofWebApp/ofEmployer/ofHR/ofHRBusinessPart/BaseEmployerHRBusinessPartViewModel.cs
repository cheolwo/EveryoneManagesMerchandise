using BusinessView.ofCommon.ofUser;
using BusinessView.ofViewModels.ofGeneric.ofCommon;
using BusinessView.ofDTO.ofHR.ofEmployer;

namespace BusinessView.ofViewModels.ofWebApp.ofEmployer.ofHR
{
    public class BaseEmployerHRBusinessPartViewModel : BaseEntityViewModel<EmployerHRBusinessPart>
    {
        public BaseEmployerHRBusinessPartViewModel(EmployerActorContext EmployerActorContext)
            :base(EmployerActorContext)
        {
        }
    }
    public class EmployerPostHRBusinessPartViewModel : EntityPostViewModel<EmployerHRBusinessPart>
    {
        public EmployerPostHRBusinessPartViewModel(EmployerActorContext EmployerActorContext)
            : base(EmployerActorContext)
        {

        }
    }
    public class EmployerPutHRBusinessPartViewModel : EntityPutViewModel<EmployerHRBusinessPart>
    {
        public EmployerPutHRBusinessPartViewModel(EmployerActorContext EmployerActorContext)
            :base(EmployerActorContext)
        {

        }
    }
    public class EmployerDeleteHRBusinessPartViewModel : EntityDeleteViewModel<EmployerHRBusinessPart>
    {
        public EmployerDeleteHRBusinessPartViewModel(EmployerActorContext EmployerActorContext)
            :base(EmployerActorContext)
        {

        }
    }
    public class EmployerGetsHRBusinessPartViewModel : EntityGetsViewModel<EmployerHRBusinessPart>
    {
        public EmployerGetsHRBusinessPartViewModel(EmployerActorContext EmployerActorContext)
            :base(EmployerActorContext)
        {

        }
    }
}
