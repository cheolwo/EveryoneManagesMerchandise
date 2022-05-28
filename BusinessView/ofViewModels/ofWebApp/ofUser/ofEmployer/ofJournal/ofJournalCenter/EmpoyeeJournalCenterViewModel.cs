using BusinessView.ofDTO.ofJournal.ofEmployer;
using BusinessView.ofCommon.ofUser;
using BusinessView.ofViewModels.ofGeneric.ofCommon;
using BusinessView.ofViewModels.ofWebApp.ofJournal.ofJournalCenter;
using BusinessView.ofUser.ofCommon;

namespace BusinessView.ofViewModels.ofWebApp.ofEmployer.ofJournal
{
    public class EmployerPostJournalCenterViewModel : JournalCenterPostViewModel<EmployerJournalCenter>
    {
        private readonly EmployerActorContext _EmployerActorContext;
        public EmployerPostJournalCenterViewModel(EmployerActorContext EmployerActorContext)
            : base(EmployerActorContext)
        {
            _EmployerActorContext = EmployerActorContext;
        }
    }
    public class EmployerPutJournalCenterViewModel : JournalCenterPutViewModel<EmployerJournalCenter>
    {
        private readonly EmployerActorContext _EmployerActorContext;
        public EmployerPutJournalCenterViewModel(EmployerActorContext EmployerActorContext)
            :base(EmployerActorContext)
        {
            _EmployerActorContext = EmployerActorContext;
        }
    }
    public class EmployerDeleteJournalCenterViewModel : JournalCenterDeleteViewModel<EmployerJournalCenter>
    {
        private readonly EmployerActorContext _EmployerActorContext;
        public EmployerDeleteJournalCenterViewModel(EmployerActorContext EmployerActorContext)
            :base(EmployerActorContext)
        {
            _EmployerActorContext = EmployerActorContext;
        }
    }
    public class EmployerGetsJournalCenterViewModel : JournalCenterGetsViewModel<EmployerJournalCenter>
    {
        private readonly EmployerActorContext _EmployerActorContext;
        public EmployerGetsJournalCenterViewModel(EmployerActorContext EmployerActorContext)
            :base(EmployerActorContext)
        {
            _EmployerActorContext = EmployerActorContext;
        }
    }
}
