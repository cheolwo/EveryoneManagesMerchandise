using BusinessView.ofDTO.ofJournal.ofEmployer;
using BusinessView.ofCommon.ofUser;
using BusinessView.ofViewModels.ofGeneric.ofCommon;
using BusinessView.ofViewModels.ofWebApp.ofJournal.ofJournal;
using BusinessView.ofUser.ofCommon;

namespace BusinessView.ofViewModels.ofWebApp.ofEmployer.ofJournal
{
    public class EmployerPostJournalViewModel : JournalPostViewModel<EmployerJournal>
    {
        private readonly EmployerActorContext _EmployerActorContext;
        public EmployerPostJournalViewModel(EmployerActorContext EmployerActorContext)
            : base(EmployerActorContext)
        {
            _EmployerActorContext = EmployerActorContext;
        }
    }
    public class EmployerPutJournalViewModel : JournalPutViewModel<EmployerJournal>
    {
        private readonly EmployerActorContext _EmployerActorContext;
        public EmployerPutJournalViewModel(EmployerActorContext EmployerActorContext)
            :base(EmployerActorContext)
        {
            _EmployerActorContext = EmployerActorContext;
        }
    }
    public class EmployerDeleteJournalViewModel : JournalDeleteViewModel<EmployerJournal>
    {
        private readonly EmployerActorContext _EmployerActorContext;
        public EmployerDeleteJournalViewModel(EmployerActorContext EmployerActorContext)
            :base(EmployerActorContext)
        {
            _EmployerActorContext = EmployerActorContext;
        }
    }
    public class EmployerGetsJournalViewModel : JournalGetsViewModel<EmployerJournal>
    {
        private readonly EmployerActorContext _EmployerActorContext;
        public EmployerGetsJournalViewModel(EmployerActorContext EmployerActorContext)
            :base(EmployerActorContext)
        {
            _EmployerActorContext = EmployerActorContext;
        }
    }
}
