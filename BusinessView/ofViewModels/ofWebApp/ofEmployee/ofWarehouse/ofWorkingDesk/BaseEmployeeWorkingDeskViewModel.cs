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
    public class EmployeePostWorkingDeskommodityViewModel : EntityPostViewModel<EmployeeWorkingDesk>
    {
        public EmployeePostWorkingDeskommodityViewModel(EmployeeActorContext EmployeeActorContext)
            : base(EmployeeActorContext)
        {

        }
    }
    public class EmployeePutWorkingDeskommodityViewModel : EntityPutViewModel<EmployeeWorkingDesk>
    {
        public EmployeePutWorkingDeskommodityViewModel(EmployeeActorContext EmployeeActorContext)
            :base(EmployeeActorContext)
        {

        }
    }
    public class EmployeeDeleteWorkingDeskommodityViewModel : EntityDeleteViewModel<EmployeeWorkingDesk>
    {
        public EmployeeDeleteWorkingDeskommodityViewModel(EmployeeActorContext EmployeeActorContext)
            :base(EmployeeActorContext)
        {

        }
    }
    public class EmployeeGetsWorkingDeskommodityViewModel : EntityGetsViewModel<EmployeeWorkingDesk>
    {
        public EmployeeGetsWorkingDeskommodityViewModel(EmployeeActorContext EmployeeActorContext)
            :base(EmployeeActorContext)
        {

        }
    }
}
