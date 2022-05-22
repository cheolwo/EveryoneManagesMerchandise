using BusinessView.ofCommon.ofUser;
using BusinessView.ofViewModels.ofGeneric.ofCommon;
using BusinessView.ofDTO.ofHR.ofEmployer;
using BusinessView.ofViewModels.ofGeneric;

namespace BusinessView.ofViewModels.ofWebApp.ofEmployer.ofHR
{
    public class BaseEmployerHRCenterViewModel : BaseCenterViewModel<EmployerHRCenter>
    {
        public BaseEmployerHRCenterViewModel(EmployerActorContext EmployerActorContext)
            :base(EmployerActorContext)
        {
        }
    }
    public class EmployerPostHRCenterViewModel : EmployerCenterPostViewModel<EmployerHRCenter>
    {
        public EmployerPostHRCenterViewModel(EmployerActorContext EmployerActorContext)
            : base(EmployerActorContext)
        {

        }
    }
    public class EmployerPutHRCenterViewModel : EmployerCenterPutViewModel<EmployerHRCenter>
    {
        public EmployerPutHRCenterViewModel(EmployerActorContext EmployerActorContext)
            :base(EmployerActorContext)
        {

        }
    }
    public class EmployerDeleteHRCenterViewModel : EmployerCenterDeleteViewModel<EmployerHRCenter>
    {
        public EmployerDeleteHRCenterViewModel(EmployerActorContext EmployerActorContext)
            :base(EmployerActorContext)
        {

        }
    }
    public class EmployerGetsHRCenterViewModel : EmployerCenterGetsViewModel<EmployerHRCenter>
    {
        public EmployerGetsHRCenterViewModel(EmployerActorContext EmployerActorContext)
            :base(EmployerActorContext)
        {

        }
    }
}
