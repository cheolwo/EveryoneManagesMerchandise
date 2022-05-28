using BusinessView.ofDTO.ofWarehouse.ofEmployee;
using BusinessView.ofCommon.ofUser;
using BusinessView.ofViewModels.ofGeneric.ofCommon;
using BusinessView.ofViewModels.ofWebApp.ofWarehouse.ofWorkingDesk;
using BusinessView.ofUser.ofCommon;

namespace BusinessView.ofViewModels.ofWebApp.ofEmployee.ofWarehouse
{
    public class EmployeePostWorkingDeskViewModel : WorkingDeskPostViewModel<EmployeeWorkingDesk>
    {
        private readonly EmployeeActorContext _EmployeeActorContext;
        public EmployeePostWorkingDeskViewModel(EmployeeActorContext EmployeeActorContext)
            : base(EmployeeActorContext)
        {
            _EmployeeActorContext = EmployeeActorContext;
        }
    }
    public class EmployeePutWorkingDeskViewModel : WorkingDeskPutViewModel<EmployeeWorkingDesk>
    {
        private readonly EmployeeActorContext _EmployeeActorContext;
        public EmployeePutWorkingDeskViewModel(EmployeeActorContext EmployeeActorContext)
            :base(EmployeeActorContext)
        {
            _EmployeeActorContext = EmployeeActorContext;
        }
    }
    public class EmployeeDeleteWorkingDeskViewModel : WorkingDeskDeleteViewModel<EmployeeWorkingDesk>
    {
        private readonly EmployeeActorContext _EmployeeActorContext;
        public EmployeeDeleteWorkingDeskViewModel(EmployeeActorContext EmployeeActorContext)
            :base(EmployeeActorContext)
        {
            _EmployeeActorContext = EmployeeActorContext;
        }
    }
    public class EmployeeGetsWorkingDeskViewModel : WorkingDeskGetsViewModel<EmployeeWorkingDesk>
    {
        private readonly EmployeeActorContext _EmployeeActorContext;
        public EmployeeGetsWorkingDeskViewModel(EmployeeActorContext EmployeeActorContext)
            :base(EmployeeActorContext)
        {
            _EmployeeActorContext = EmployeeActorContext;
        }
    }
}
