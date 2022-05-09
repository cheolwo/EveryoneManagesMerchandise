using BusinessView.ofCommon.ofUser;
using BusinessView.ofViewModels.ofGeneric.ofCommon;
using BusinessView.ofDTO.ofJournal.ofEmployer;

namespace BusinessView.ofViewModels.ofWebApp.ofEmployer.ofJournal
{
    public class BaseEmployerJournalViewModel : BaseEntityViewModel<EmployerJournal>
    {
        public BaseEmployerJournalViewModel(EmployerActorContext EmployerActorContext)
            :base(EmployerActorContext)
        {
        }
    }
    public class EmployerPostJournalViewModel : EntityPostViewModel<EmployerJournal>
    {
        public EmployerPostJournalViewModel(EmployerActorContext EmployerActorContext)
            : base(EmployerActorContext)
        {

        }
    }
    public class EmployerPutJournalViewModel : EntityPutViewModel<EmployerJournal>
    {
        public EmployerPutJournalViewModel(EmployerActorContext EmployerActorContext)
            :base(EmployerActorContext)
        {

        }
    }
    public class EmployerDeleteJournalViewModel : EntityDeleteViewModel<EmployerJournal>
    {
        public EmployerDeleteJournalViewModel(EmployerActorContext EmployerActorContext)
            :base(EmployerActorContext)
        {

        }
    }
    public class EmployerGetsJournalViewModel : EntityGetsViewModel<EmployerJournal>
    {
        public EmployerGetsJournalViewModel(EmployerActorContext EmployerActorContext)
            :base(EmployerActorContext)
        {

        }
    }
}
