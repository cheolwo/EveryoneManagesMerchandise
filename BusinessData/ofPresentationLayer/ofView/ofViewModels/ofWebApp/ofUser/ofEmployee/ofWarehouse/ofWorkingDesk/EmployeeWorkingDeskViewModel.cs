using BusinessView.ofCommon.ofUser;
using BusinessView.ofViewModels.ofWebApp.ofWarehouse.ofWorkingDesk;
using BusinessData.ofPresentationLayer.ofDTO.ofWarehouse.ofEmployee;

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
