using BusinessView.ofDTO.ofWarehouse.ofEmployer;
using BusinessView.ofCommon.ofUser;
using BusinessView.ofViewModels.ofGeneric.ofCommon;
using BusinessView.ofViewModels.ofWebApp.ofWarehouse.ofLoadFrame;
using BusinessView.ofUser.ofCommon;

namespace BusinessView.ofViewModels.ofWebApp.ofEmployer.ofWarehouse
{
    public class EmployerPostLoadFrameViewModel : LoadFramePostViewModel<EmployerLoadFrame>
    {
        private readonly EmployerActorContext _EmployerActorContext;
        public EmployerPostLoadFrameViewModel(EmployerActorContext EmployerActorContext)
            : base(EmployerActorContext)
        {
            _EmployerActorContext = EmployerActorContext;
        }
    }
    public class EmployerPutLoadFrameViewModel : LoadFramePutViewModel<EmployerLoadFrame>
    {
        private readonly EmployerActorContext _EmployerActorContext;
        public EmployerPutLoadFrameViewModel(EmployerActorContext EmployerActorContext)
            :base(EmployerActorContext)
        {
            _EmployerActorContext = EmployerActorContext;
        }
    }
    public class EmployerDeleteLoadFrameViewModel : LoadFrameDeleteViewModel<EmployerLoadFrame>
    {
        private readonly EmployerActorContext _EmployerActorContext;
        public EmployerDeleteLoadFrameViewModel(EmployerActorContext EmployerActorContext)
            :base(EmployerActorContext)
        {
            _EmployerActorContext = EmployerActorContext;
        }
    }
    public class EmployerGetsLoadFrameViewModel : LoadFrameGetsViewModel<EmployerLoadFrame>
    {
        private readonly EmployerActorContext _EmployerActorContext;
        public EmployerGetsLoadFrameViewModel(EmployerActorContext EmployerActorContext)
            :base(EmployerActorContext)
        {
            _EmployerActorContext = EmployerActorContext;
        }
    }
}
