using BusinessView.ofDTO.ofWarehouse.ofEmployee;
using BusinessView.ofCommon.ofUser;
using BusinessView.ofViewModels.ofGeneric.ofCommon;

namespace BusinessView.ofViewModels.ofWebApp.ofEmployee.ofWarehouse
{
    public class BaseEmployeeWorkingDeskViewModel : BaseEntityViewModel<EmployeeWorkingDesk>
    {
        public BaseEmployeeWorkingDeskViewModel(EmployeeActorContext EmployeeActorContext)
            :base(EmployeeActorContext)
        {
        }
    }
    public class EmployeePostWorkingDeskViewModel : EntityPostViewModel<EmployeeWorkingDesk>
    {
        public EmployeePostWorkingDeskViewModel(EmployeeActorContext EmployeeActorContext)
            : base(EmployeeActorContext)
        {

        }
    }
    public class EmployeePutWorkingDeskViewModel : EntityPutViewModel<EmployeeWorkingDesk>
    {
        public EmployeePutWorkingDeskViewModel(EmployeeActorContext EmployeeActorContext)
            :base(EmployeeActorContext)
        {

        }
    }
    public class EmployeeDeleteWorkingDeskViewModel : EntityDeleteViewModel<EmployeeWorkingDesk>
    {
        public EmployeeDeleteWorkingDeskViewModel(EmployeeActorContext EmployeeActorContext)
            :base(EmployeeActorContext)
        {

        }
    }
    public class EmployeeGetsWorkingDeskViewModel : EntityGetsViewModel<EmployeeWorkingDesk>
    {
        public EmployeeGetsWorkingDeskViewModel(EmployeeActorContext EmployeeActorContext)
            :base(EmployeeActorContext)
        {

        }
    }
}
