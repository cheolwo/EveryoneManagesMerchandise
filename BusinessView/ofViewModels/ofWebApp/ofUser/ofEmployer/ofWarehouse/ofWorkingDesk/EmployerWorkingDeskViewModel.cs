using BusinessView.ofDTO.ofWarehouse.ofEmployer;
using BusinessView.ofCommon.ofUser;
using BusinessView.ofViewModels.ofGeneric.ofCommon;
using BusinessView.ofViewModels.ofWebApp.ofWarehouse.ofWorkingDesk;
using BusinessView.ofUser.ofCommon;

namespace BusinessView.ofViewModels.ofWebApp.ofEmployer.ofWarehouse
{
    public class EmployerPostWorkingDeskViewModel : WorkingDeskPostViewModel<EmployerWorkingDesk>
    {
        private readonly EmployerActorContext _EmployerActorContext;
        public EmployerPostWorkingDeskViewModel(EmployerActorContext EmployerActorContext)
            : base(EmployerActorContext)
        {
            _EmployerActorContext = EmployerActorContext;
        }
    }
    public class EmployerPutWorkingDeskViewModel : WorkingDeskPutViewModel<EmployerWorkingDesk>
    {
        private readonly EmployerActorContext _EmployerActorContext;
        public EmployerPutWorkingDeskViewModel(EmployerActorContext EmployerActorContext)
            :base(EmployerActorContext)
        {
            _EmployerActorContext = EmployerActorContext;
        }
    }
    public class EmployerDeleteWorkingDeskViewModel : WorkingDeskDeleteViewModel<EmployerWorkingDesk>
    {
        private readonly EmployerActorContext _EmployerActorContext;
        public EmployerDeleteWorkingDeskViewModel(EmployerActorContext EmployerActorContext)
            :base(EmployerActorContext)
        {
            _EmployerActorContext = EmployerActorContext;
        }
    }
    public class EmployerGetsWorkingDeskViewModel : WorkingDeskGetsViewModel<EmployerWorkingDesk>
    {
        private readonly EmployerActorContext _EmployerActorContext;
        public EmployerGetsWorkingDeskViewModel(EmployerActorContext EmployerActorContext)
            :base(EmployerActorContext)
        {
            _EmployerActorContext = EmployerActorContext;
        }
    }
}
