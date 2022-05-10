using BusinessView.ofCommon.ofUser;
using BusinessView.ofViewModels.ofGeneric.ofCommon;
using BusinessView.ofDTO.ofWarehouse.ofEmployer;

namespace BusinessView.ofViewModels.ofWebApp.ofEmployer.ofWarehouse
{
    public class BaseEmployerWorkingDeskViewModel : BaseEntityViewModel<EmployerWorkingDesk>
    {
        public BaseEmployerWorkingDeskViewModel(EmployerActorContext EmployerActorContext)
            :base(EmployerActorContext)
        {
        }
    }
    public class EmployerPostWorkingDeskViewModel : EntityPostViewModel<EmployerWorkingDesk>
    {
        public EmployerPostWorkingDeskViewModel(EmployerActorContext EmployerActorContext)
            : base(EmployerActorContext)
        {

        }
    }
    public class EmployerPutWorkingDeskViewModel : EntityPutViewModel<EmployerWorkingDesk>
    {
        public EmployerPutWorkingDeskViewModel(EmployerActorContext EmployerActorContext)
            :base(EmployerActorContext)
        {

        }
    }
    public class EmployerDeleteWorkingDeskViewModel : EntityDeleteViewModel<EmployerWorkingDesk>
    {
        public EmployerDeleteWorkingDeskViewModel(EmployerActorContext EmployerActorContext)
            :base(EmployerActorContext)
        {

        }
    }
    public class EmployerGetsWorkingDeskViewModel : EntityGetsViewModel<EmployerWorkingDesk>
    {
        public EmployerGetsWorkingDeskViewModel(EmployerActorContext EmployerActorContext)
            :base(EmployerActorContext)
        {

        }
    }
}
