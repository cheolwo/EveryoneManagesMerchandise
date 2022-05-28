using BusinessView.ofCommon.ofUser;
using BusinessView.ofViewModels.ofGeneric.ofCommon;
using BusinessView.ofDTO.ofJournal.ofEmployer;
using BusinessView.ofViewModels.ofGeneric;

namespace BusinessView.ofViewModels.ofWebApp.ofEmployer.ofJournal
{
    public class EmployerPostJournalViewModel : EmployerPostViewModel<EmployerJournal>
    {
        public EmployerPostJournalViewModel(EmployerActorContext EmployerActorContext)
            : base(EmployerActorContext)
        {

        }
    }
    public class EmployerPutJournalViewModel : EmployerPutViewModel<EmployerJournal>
    {
        public EmployerPutJournalViewModel(EmployerActorContext EmployerActorContext)
            :base(EmployerActorContext)
        {

        }
    }
    public class EmployerDeleteJournalViewModel : EmployerDeleteViewModel<EmployerJournal>
    {
        public EmployerDeleteJournalViewModel(EmployerActorContext EmployerActorContext)
            :base(EmployerActorContext)
        {

        }
    }
    public class EmployerGetsJournalViewModel : EmployerGetsViewModel<EmployerJournal>
    {
        public EmployerGetsJournalViewModel(EmployerActorContext EmployerActorContext)
            :base(EmployerActorContext)
        {

        }
    }
}
