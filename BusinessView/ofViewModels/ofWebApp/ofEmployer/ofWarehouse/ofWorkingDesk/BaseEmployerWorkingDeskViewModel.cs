using BusinessView.ofCommon.ofUser;
using BusinessView.ofViewModels.ofGeneric.ofCommon;
using BusinessView.ofDTO.ofWarehouse.ofEmployer;
using BusinessView.ofViewModels.ofGeneric;

namespace BusinessView.ofViewModels.ofWebApp.ofEmployer.ofWarehouse
{
    public class EmployerPostWorkingDeskViewModel : EmployerPostViewModel<EmployerWorkingDesk>
    {
        public EmployerPostWorkingDeskViewModel(EmployerActorContext EmployerActorContext)
            : base(EmployerActorContext)
        {

        }
    }
    public class EmployerPutWorkingDeskViewModel : EmployerPutViewModel<EmployerWorkingDesk>
    {
        public EmployerPutWorkingDeskViewModel(EmployerActorContext EmployerActorContext)
            :base(EmployerActorContext)
        {

        }
    }
    public class EmployerDeleteWorkingDeskViewModel : EmployerDeleteViewModel<EmployerWorkingDesk>
    {
        public EmployerDeleteWorkingDeskViewModel(EmployerActorContext EmployerActorContext)
            :base(EmployerActorContext)
        {

        }
    }
    public class EmployerGetsWorkingDeskViewModel : EmployerGetsViewModel<EmployerWorkingDesk>
    {
        public EmployerGetsWorkingDeskViewModel(EmployerActorContext EmployerActorContext)
            :base(EmployerActorContext)
        {

        }
    }
}
