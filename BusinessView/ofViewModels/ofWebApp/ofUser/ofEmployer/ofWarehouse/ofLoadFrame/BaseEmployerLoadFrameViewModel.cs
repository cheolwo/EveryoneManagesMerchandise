using BusinessView.ofCommon.ofUser;
using BusinessView.ofViewModels.ofGeneric.ofCommon;
using BusinessView.ofDTO.ofWarehouse.ofEmployer;
using BusinessView.ofViewModels.ofGeneric;

namespace BusinessView.ofViewModels.ofWebApp.ofEmployer.ofWarehouse
{
    public class EmployerPostLoadFrameViewModel : EmployerPostViewModel<EmployerLoadFrame>
    {
        public EmployerPostLoadFrameViewModel(EmployerActorContext EmployerActorContext)
            : base(EmployerActorContext)
        {

        }
    }
    public class EmployerPutLoadFrameViewModel : EmployerPutViewModel<EmployerLoadFrame>
    {
        public EmployerPutLoadFrameViewModel(EmployerActorContext EmployerActorContext)
            :base(EmployerActorContext)
        {

        }
    }
    public class EmployerDeleteLoadFrameViewModel : EmployerDeleteViewModel<EmployerLoadFrame>
    {
        public EmployerDeleteLoadFrameViewModel(EmployerActorContext EmployerActorContext)
            :base(EmployerActorContext)
        {

        }
    }
    public class EmployerGetsLoadFrameViewModel : EmployerGetsViewModel<EmployerLoadFrame>
    {
        public EmployerGetsLoadFrameViewModel(EmployerActorContext EmployerActorContext)
            :base(EmployerActorContext)
        {

        }
    }
}
