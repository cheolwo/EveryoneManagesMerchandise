using BusinessView.ofCommon.ofUser;
using BusinessView.ofViewModels.ofGeneric.ofCommon;
using BusinessView.ofDTO.ofHR.ofEmployer;

namespace BusinessView.ofViewModels.ofWebApp.ofEmployer.ofHR
{
    public class BaseEmployerHRCenterViewModel : BaseCenterViewModel<EmployerHRCenter>
    {
        public BaseEmployerHRCenterViewModel(EmployerActorContext EmployerActorContext)
            :base(EmployerActorContext)
        {
        }
    }
    public class EmployerPostHRCenterViewModel : CenterPostViewModel<EmployerHRCenter>
    {
        public EmployerPostHRCenterViewModel(EmployerActorContext EmployerActorContext)
            : base(EmployerActorContext)
        {

        }
    }
    public class EmployerPutHRCenterViewModel : CenterPutViewModel<EmployerHRCenter>
    {
        public EmployerPutHRCenterViewModel(EmployerActorContext EmployerActorContext)
            :base(EmployerActorContext)
        {

        }
    }
    public class EmployerDeleteHRCenterViewModel : CenterDeleteViewModel<EmployerHRCenter>
    {
        public EmployerDeleteHRCenterViewModel(EmployerActorContext EmployerActorContext)
            :base(EmployerActorContext)
        {

        }
    }
    public class EmployerGetsHRCenterViewModel : CenterGetsViewModel<EmployerHRCenter>
    {
        public EmployerGetsHRCenterViewModel(EmployerActorContext EmployerActorContext)
            :base(EmployerActorContext)
        {

        }
    }
}
