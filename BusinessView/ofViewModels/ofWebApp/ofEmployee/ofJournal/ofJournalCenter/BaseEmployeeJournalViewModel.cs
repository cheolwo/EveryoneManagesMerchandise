using BusinessView.ofDTO.ofJournal.ofEmployee;
using BusinessView.ofCommon.ofUser;
using BusinessView.ofViewModels.ofGeneric.ofCommon;

namespace BusinessView.ofViewModels.ofWebApp.ofEmployee.ofJournal
{
    public class BaseEmployeeJournalCenterViewModel : BaseCenterViewModel<EmployeeJournalCenter>
    {
        public BaseEmployeeJournalCenterViewModel(EmployeeActorContext EmployeeActorContext)
            :base(EmployeeActorContext)
        {
        }
    }
    public class EmployeePostJournalCenterViewModel : CenterPostViewModel<EmployeeJournalCenter>
    {
        public EmployeePostJournalCenterViewModel(EmployeeActorContext EmployeeActorContext)
            : base(EmployeeActorContext)
        {

        }
    }
    public class EmployeePutJournalCenterViewModel : CenterPutViewModel<EmployeeJournalCenter>
    {
        public EmployeePutJournalCenterViewModel(EmployeeActorContext EmployeeActorContext)
            :base(EmployeeActorContext)
        {

        }
    }
    public class EmployeeDeleteJournalCenterViewModel : CenterDeleteViewModel<EmployeeJournalCenter>
    {
        public EmployeeDeleteJournalCenterViewModel(EmployeeActorContext EmployeeActorContext)
            :base(EmployeeActorContext)
        {

        }
    }
    public class EmployeeGetsJournalCenterViewModel : CenterGetsViewModel<EmployeeJournalCenter>
    {
        public EmployeeGetsJournalCenterViewModel(EmployeeActorContext EmployeeActorContext)
            :base(EmployeeActorContext)
        {

        }
    }
}
