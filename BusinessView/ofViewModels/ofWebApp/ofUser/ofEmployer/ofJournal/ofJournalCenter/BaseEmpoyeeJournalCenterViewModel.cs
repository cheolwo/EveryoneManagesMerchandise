using BusinessView.ofCommon.ofUser;
using BusinessView.ofViewModels.ofGeneric.ofCommon;
using BusinessView.ofDTO.ofJournal.ofEmployer;
using BusinessView.ofViewModels.ofGeneric;

namespace BusinessView.ofViewModels.ofWebApp.ofEmployer.ofJournal
{
    public class BaseEmployerJournalCenterViewModel : BaseCenterViewModel<EmployerJournalCenter>
    {
        public BaseEmployerJournalCenterViewModel(EmployerActorContext EmployerActorContext)
            :base(EmployerActorContext)
        {
        }
    }
    public class EmployerPostJournalCenterViewModel : EmployerCenterPostViewModel<EmployerJournalCenter>
    {
        public EmployerPostJournalCenterViewModel(EmployerActorContext EmployerActorContext)
            : base(EmployerActorContext)
        {

        }
    }
    public class EmployerPutJournalCenterViewModel : EmployerCenterPutViewModel<EmployerJournalCenter>
    {
        public EmployerPutJournalCenterViewModel(EmployerActorContext EmployerActorContext)
            :base(EmployerActorContext)
        {

        }
    }
    public class EmployerDeleteJournalCenterViewModel : EmployerCenterDeleteViewModel<EmployerJournalCenter>
    {
        public EmployerDeleteJournalCenterViewModel(EmployerActorContext EmployerActorContext)
            :base(EmployerActorContext)
        {

        }
    }
    public class EmployerGetsJournalCenterViewModel : EmployerCenterGetsViewModel<EmployerJournalCenter>
    {
        public EmployerGetsJournalCenterViewModel(EmployerActorContext EmployerActorContext)
            :base(EmployerActorContext)
        {

        }
    }
}
