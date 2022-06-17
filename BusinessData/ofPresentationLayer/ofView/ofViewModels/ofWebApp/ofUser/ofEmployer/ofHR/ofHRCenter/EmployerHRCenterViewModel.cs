using BusinessView.ofCommon.ofUser;
using BusinessView.ofViewModels.ofWebApp.ofHR.ofHRCenter;
using BusinessData.ofPresentationLayer.ofDTO.ofHR.ofEmployer;

namespace BusinessView.ofViewModels.ofWebApp.ofEmployer.ofHR
{
    public class EmployerPostHRCenterViewModel : HRCenterPostViewModel<EmployerHRCenter>
    {
        private readonly EmployerActorContext _EmployerActorContext;
        public EmployerPostHRCenterViewModel(EmployerActorContext EmployerActorContext)
            : base(EmployerActorContext)
        {
            _EmployerActorContext = EmployerActorContext;
        }
    }
    public class EmployerPutHRCenterViewModel : HRCenterPutViewModel<EmployerHRCenter>
    {
        private readonly EmployerActorContext _EmployerActorContext;
        public EmployerPutHRCenterViewModel(EmployerActorContext EmployerActorContext)
            :base(EmployerActorContext)
        {
            _EmployerActorContext = EmployerActorContext;
        }
    }
    public class EmployerDeleteHRCenterViewModel : HRCenterDeleteViewModel<EmployerHRCenter>
    {
        private readonly EmployerActorContext _EmployerActorContext;
        public EmployerDeleteHRCenterViewModel(EmployerActorContext EmployerActorContext)
            :base(EmployerActorContext)
        {
            _EmployerActorContext = EmployerActorContext;
        }
    }
    public class EmployerGetsHRCenterViewModel : HRCenterGetsViewModel<EmployerHRCenter>
    {
        private readonly EmployerActorContext _EmployerActorContext;
        public EmployerGetsHRCenterViewModel(EmployerActorContext EmployerActorContext)
            :base(EmployerActorContext)
        {
            _EmployerActorContext = EmployerActorContext;
        }
    }
}