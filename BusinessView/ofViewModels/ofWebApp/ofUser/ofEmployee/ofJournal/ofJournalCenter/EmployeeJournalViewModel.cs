using BusinessView.ofDTO.ofJournal.ofEmployee;
using BusinessView.ofCommon.ofUser;
using BusinessView.ofViewModels.ofGeneric.ofCommon;
using BusinessView.ofViewModels.ofWebApp.ofJournal.ofJournalCenter;
using BusinessView.ofUser.ofCommon;

namespace BusinessView.ofViewModels.ofWebApp.ofEmployee.ofJournal
{
    public class EmployeePostJournalCenterViewModel : JournalCenterPostViewModel<EmployeeJournalCenter>
    {
        private readonly EmployeeActorContext _EmployeeActorContext;
        public EmployeePostJournalCenterViewModel(EmployeeActorContext EmployeeActorContext)
            : base(EmployeeActorContext)
        {
            _EmployeeActorContext = EmployeeActorContext;
        }
    }
    public class EmployeePutJournalCenterViewModel : JournalCenterPutViewModel<EmployeeJournalCenter>
    {
        private readonly EmployeeActorContext _EmployeeActorContext;
        public EmployeePutJournalCenterViewModel(EmployeeActorContext EmployeeActorContext)
            :base(EmployeeActorContext)
        {
            _EmployeeActorContext = EmployeeActorContext;
        }
    }
    public class EmployeeDeleteJournalCenterViewModel : JournalCenterDeleteViewModel<EmployeeJournalCenter>
    {
        private readonly EmployeeActorContext _EmployeeActorContext;
        public EmployeeDeleteJournalCenterViewModel(EmployeeActorContext EmployeeActorContext)
            :base(EmployeeActorContext)
        {
            _EmployeeActorContext = EmployeeActorContext;
        }
    }
    public class EmployeeGetsJournalCenterViewModel : JournalCenterGetsViewModel<EmployeeJournalCenter>
    {
        private readonly EmployeeActorContext _EmployeeActorContext;
        public EmployeeGetsJournalCenterViewModel(EmployeeActorContext EmployeeActorContext)
            :base(EmployeeActorContext)
        {
            _EmployeeActorContext = EmployeeActorContext;
        }
    }
}
