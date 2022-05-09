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
    public class EmployeePostLoadFrameommodityViewModel : EntityPostViewModel<EmployeeLoadFrame>
    {
        public EmployeePostLoadFrameommodityViewModel(EmployeeActorContext EmployeeActorContext)
            : base(EmployeeActorContext)
        {

        }
    }
    public class EmployeePutLoadFrameommodityViewModel : EntityPutViewModel<EmployeeLoadFrame>
    {
        public EmployeePutLoadFrameommodityViewModel(EmployeeActorContext EmployeeActorContext)
            :base(EmployeeActorContext)
        {

        }
    }
    public class EmployeeDeleteLoadFrameommodityViewModel : EntityDeleteViewModel<EmployeeLoadFrame>
    {
        public EmployeeDeleteLoadFrameommodityViewModel(EmployeeActorContext EmployeeActorContext)
            :base(EmployeeActorContext)
        {

        }
    }
    public class EmployeeGetsLoadFrameommodityViewModel : EntityGetsViewModel<EmployeeLoadFrame>
    {
        public EmployeeGetsLoadFrameommodityViewModel(EmployeeActorContext EmployeeActorContext)
            :base(EmployeeActorContext)
        {

        }
    }
}
