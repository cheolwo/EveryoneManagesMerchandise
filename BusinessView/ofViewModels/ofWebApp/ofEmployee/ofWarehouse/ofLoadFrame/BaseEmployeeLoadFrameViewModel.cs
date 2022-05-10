using BusinessView.ofDTO.ofWarehouse.ofEmployee;
using BusinessView.ofCommon.ofUser;
using BusinessView.ofViewModels.ofGeneric.ofCommon;

namespace BusinessView.ofViewModels.ofWebApp.ofEmployee.ofWarehouse
{
    public class BaseEmployeeLoadFrameViewModel : BaseEntityViewModel<EmployeeLoadFrame>
    {
        public BaseEmployeeLoadFrameViewModel(EmployeeActorContext EmployeeActorContext)
            :base(EmployeeActorContext)
        {
        }
    }
    public class EmployeePostLoadFrameViewModel : EntityPostViewModel<EmployeeLoadFrame>
    {
        public EmployeePostLoadFrameViewModel(EmployeeActorContext EmployeeActorContext)
            : base(EmployeeActorContext)
        {

        }
    }
    public class EmployeePutLoadFrameViewModel : EntityPutViewModel<EmployeeLoadFrame>
    {
        public EmployeePutLoadFrameViewModel(EmployeeActorContext EmployeeActorContext)
            :base(EmployeeActorContext)
        {

        }
    }
    public class EmployeeDeleteLoadFrameViewModel : EntityDeleteViewModel<EmployeeLoadFrame>
    {
        public EmployeeDeleteLoadFrameViewModel(EmployeeActorContext EmployeeActorContext)
            :base(EmployeeActorContext)
        {

        }
    }
    public class EmployeeGetsLoadFrameViewModel : EntityGetsViewModel<EmployeeLoadFrame>
    {
        public EmployeeGetsLoadFrameViewModel(EmployeeActorContext EmployeeActorContext)
            :base(EmployeeActorContext)
        {

        }
    }
}
