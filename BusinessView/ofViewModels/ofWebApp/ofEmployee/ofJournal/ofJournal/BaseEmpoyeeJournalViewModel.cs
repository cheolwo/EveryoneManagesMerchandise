using BusinessView.ofDTO.ofJournal.ofEmployee;
using BusinessView.ofCommon.ofUser;
using BusinessView.ofViewModels.ofGeneric.ofCommon;

namespace BusinessView.ofViewModels.ofWebApp.ofEmployee.ofJournal
{
    public class BaseEmployeeJournalViewModel : BaseEntityViewModel<EmployeeJournal>
    {
        public BaseEmployeeJournalViewModel(EmployeeActorContext EmployeeActorContext)
            :base(EmployeeActorContext)
        {
        }
    }
    public class EmployeePostJournalViewModel : EntityPostViewModel<EmployeeJournal>
    {
        public EmployeePostJournalViewModel(EmployeeActorContext EmployeeActorContext)
            : base(EmployeeActorContext)
        {

        }
    }
    public class EmployeePutJournalViewModel : EntityPutViewModel<EmployeeJournal>
    {
        public EmployeePutJournalViewModel(EmployeeActorContext EmployeeActorContext)
            :base(EmployeeActorContext)
        {

        }
    }
    public class EmployeeDeleteJournalViewModel : EntityDeleteViewModel<EmployeeJournal>
    {
        public EmployeeDeleteJournalViewModel(EmployeeActorContext EmployeeActorContext)
            :base(EmployeeActorContext)
        {

        }
    }
    public class EmployeeGetsJournalViewModel : EntityGetsViewModel<EmployeeJournal>
    {
        public EmployeeGetsJournalViewModel(EmployeeActorContext EmployeeActorContext)
            :base(EmployeeActorContext)
        {

        }
    }
}
