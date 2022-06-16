using BusinessView.ofCommon.ofUser;
using BusinessView.ofViewModels.ofWebApp.ofJournal.ofJournal;
using BusinessData.ofPresentationLayer.ofDTO.ofJournal.ofEmployee;

namespace BusinessView.ofViewModels.ofWebApp.ofEmployee.ofJournal
{
    public class EmployeePostJournalViewModel : JournalPostViewModel<EmployeeJournal>
    {
        private readonly EmployeeActorContext _EmployeeActorContext;
        public EmployeePostJournalViewModel(EmployeeActorContext EmployeeActorContext)
            : base(EmployeeActorContext)
        {
            _EmployeeActorContext = EmployeeActorContext;
        }
    }
    public class EmployeePutJournalViewModel : JournalPutViewModel<EmployeeJournal>
    {
        private readonly EmployeeActorContext _EmployeeActorContext;
        public EmployeePutJournalViewModel(EmployeeActorContext EmployeeActorContext)
            :base(EmployeeActorContext)
        {
            _EmployeeActorContext = EmployeeActorContext;
        }
    }
    public class EmployeeDeleteJournalViewModel : JournalDeleteViewModel<EmployeeJournal>
    {
        private readonly EmployeeActorContext _EmployeeActorContext;
        public EmployeeDeleteJournalViewModel(EmployeeActorContext EmployeeActorContext)
            :base(EmployeeActorContext)
        {
            _EmployeeActorContext = EmployeeActorContext;
        }
    }
    public class EmployeeGetsJournalViewModel : JournalGetsViewModel<EmployeeJournal>
    {
        private readonly EmployeeActorContext _EmployeeActorContext;
        public EmployeeGetsJournalViewModel(EmployeeActorContext EmployeeActorContext)
            :base(EmployeeActorContext)
        {
            _EmployeeActorContext = EmployeeActorContext;
        }
    }
}
