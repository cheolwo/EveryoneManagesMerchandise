using BusinessView.ofDTO.ofHR.ofEmployer;
using BusinessView.ofCommon.ofUser;
using BusinessView.ofViewModels.ofGeneric.ofCommon;
using BusinessView.ofViewModels.ofWebApp.ofHR.ofHRBusinessPart;
using BusinessView.ofUser.ofCommon;

namespace BusinessView.ofViewModels.ofWebApp.ofEmployer.ofHR
{
    public class EmployerPostHRBusinessPartViewModel : HRBusinessPartPostViewModel<EmployerHRBusinessPart>
    {
        private readonly EmployerActorContext _EmployerActorContext;
        public EmployerPostHRBusinessPartViewModel(EmployerActorContext EmployerActorContext)
            : base(EmployerActorContext)
        {
            _EmployerActorContext = EmployerActorContext;
        }
    }
    public class EmployerPutHRBusinessPartViewModel : HRBusinessPartPutViewModel<EmployerHRBusinessPart>
    {
        private readonly EmployerActorContext _EmployerActorContext;
        public EmployerPutHRBusinessPartViewModel(EmployerActorContext EmployerActorContext)
            :base(EmployerActorContext)
        {
            _EmployerActorContext = EmployerActorContext;
        }
    }
    public class EmployerDeleteHRBusinessPartViewModel : HRBusinessPartDeleteViewModel<EmployerHRBusinessPart>
    {
        private readonly EmployerActorContext _EmployerActorContext;
        public EmployerDeleteHRBusinessPartViewModel(EmployerActorContext EmployerActorContext)
            :base(EmployerActorContext)
        {
            _EmployerActorContext = EmployerActorContext;
        }
    }
    public class EmployerGetsHRBusinessPartViewModel : HRBusinessPartGetsViewModel<EmployerHRBusinessPart>
    {
        private readonly EmployerActorContext _EmployerActorContext;
        public EmployerGetsHRBusinessPartViewModel(EmployerActorContext EmployerActorContext)
            :base(EmployerActorContext)
        {
            _EmployerActorContext = EmployerActorContext;
        }
    }
}
