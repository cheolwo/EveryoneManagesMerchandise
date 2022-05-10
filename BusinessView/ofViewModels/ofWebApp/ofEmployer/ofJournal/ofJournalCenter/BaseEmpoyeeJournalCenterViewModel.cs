using BusinessView.ofCommon.ofUser;
using BusinessView.ofViewModels.ofGeneric.ofCommon;
using BusinessView.ofDTO.ofJournal.ofEmployer;

namespace BusinessView.ofViewModels.ofWebApp.ofEmployer.ofJournal
{
    public class BaseEmployerJournalCenterViewModel : BaseCenterViewModel<EmployerJournalCenter>
    {
        public BaseEmployerJournalCenterViewModel(EmployerActorContext EmployerActorContext)
            :base(EmployerActorContext)
        {
        }
    }
    public class EmployerPostJournalCenterViewModel : CenterPostViewModel<EmployerJournalCenter>
    {
        public EmployerPostJournalCenterViewModel(EmployerActorContext EmployerActorContext)
            : base(EmployerActorContext)
        {

        }
    }
    public class EmployerPutJournalCenterViewModel : CenterPutViewModel<EmployerJournalCenter>
    {
        public EmployerPutJournalCenterViewModel(EmployerActorContext EmployerActorContext)
            :base(EmployerActorContext)
        {

        }
    }
    public class EmployerDeleteJournalCenterViewModel : CenterDeleteViewModel<EmployerJournalCenter>
    {
        public EmployerDeleteJournalCenterViewModel(EmployerActorContext EmployerActorContext)
            :base(EmployerActorContext)
        {

        }
    }
    public class EmployerGetsJournalCenterViewModel : CenterGetsViewModel<EmployerJournalCenter>
    {
        public EmployerGetsJournalCenterViewModel(EmployerActorContext EmployerActorContext)
            :base(EmployerActorContext)
        {

        }
    }
}
