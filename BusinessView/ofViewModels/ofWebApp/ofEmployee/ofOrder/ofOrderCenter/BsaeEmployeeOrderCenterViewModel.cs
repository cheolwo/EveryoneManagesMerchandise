using BusinessView.ofDTO.ofOrder.ofEmployee;
using BusinessView.ofCommon.ofUser;
using BusinessView.ofViewModels.ofGeneric.ofCommon;

namespace BusinessView.ofViewModels.ofWebApp.ofEmployee.ofOrder
{
    public class BaseEmployeeOrderCenterViewModel : BaseCenterViewModel<EmployeeOrderCenter>
    {
        public BaseEmployeeOrderCenterViewModel(EmployeeActorContext EmployeeActorContext)
            :base(EmployeeActorContext)
        {
        }
    }
    public class EmployeePostOrderCenterViewModel : CenterPostViewModel<EmployeeOrderCenter>
    {
        public EmployeePostOrderCenterViewModel(EmployeeActorContext EmployeeActorContext)
            : base(EmployeeActorContext)
        {

        }
    }
    public class EmployeePutOrderCenterViewModel : CenterPutViewModel<EmployeeOrderCenter>
    {
        public EmployeePutOrderCenterViewModel(EmployeeActorContext EmployeeActorContext)
            :base(EmployeeActorContext)
        {

        }
    }
    public class EmployeeDeleteOrderCenterViewModel : CenterDeleteViewModel<EmployeeOrderCenter>
    {
        public EmployeeDeleteOrderCenterViewModel(EmployeeActorContext EmployeeActorContext)
            :base(EmployeeActorContext)
        {

        }
    }
    public class EmployeeGetsOrderCenterViewModel : CenterGetsViewModel<EmployeeOrderCenter>
    {
        public EmployeeGetsOrderCenterViewModel(EmployeeActorContext EmployeeActorContext)
            :base(EmployeeActorContext)
        {

        }
    }
}
