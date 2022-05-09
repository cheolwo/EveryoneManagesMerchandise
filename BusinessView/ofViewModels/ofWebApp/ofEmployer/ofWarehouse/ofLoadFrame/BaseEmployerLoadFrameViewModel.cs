using BusinessView.ofCommon.ofUser;
using BusinessView.ofViewModels.ofGeneric.ofCommon;
using BusinessView.ofDTO.ofWarehouse.ofEmployer;

namespace BusinessView.ofViewModels.ofWebApp.ofEmployer.ofWarehouse
{
    public class BaseEmployerLoadFrameViewModel : BaseEntityViewModel<EmployerLoadFrame>
    {
        public BaseEmployerLoadFrameViewModel(EmployerActorContext EmployerActorContext)
            :base(EmployerActorContext)
        {
        }
    }
    public class EmployerPostLoadFrameViewModel : EntityPostViewModel<EmployerLoadFrame>
    {
        public EmployerPostLoadFrameViewModel(EmployerActorContext EmployerActorContext)
            : base(EmployerActorContext)
        {

        }
    }
    public class EmployerPutLoadFrameViewModel : EntityPutViewModel<EmployerLoadFrame>
    {
        public EmployerPutLoadFrameViewModel(EmployerActorContext EmployerActorContext)
            :base(EmployerActorContext)
        {

        }
    }
    public class EmployerDeleteLoadFrameViewModel : EntityDeleteViewModel<EmployerLoadFrame>
    {
        public EmployerDeleteLoadFrameViewModel(EmployerActorContext EmployerActorContext)
            :base(EmployerActorContext)
        {

        }
    }
    public class EmployerGetsLoadFrameViewModel : EntityGetsViewModel<EmployerLoadFrame>
    {
        public EmployerGetsLoadFrameViewModel(EmployerActorContext EmployerActorContext)
            :base(EmployerActorContext)
        {

        }
    }
}
