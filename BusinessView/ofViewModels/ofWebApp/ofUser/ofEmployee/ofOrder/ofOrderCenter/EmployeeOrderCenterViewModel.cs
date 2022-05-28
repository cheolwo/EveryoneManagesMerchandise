using BusinessView.ofDTO.ofOrder.ofEmployee;
using BusinessView.ofCommon.ofUser;
using BusinessView.ofViewModels.ofGeneric.ofCommon;
using BusinessView.ofViewModels.ofWebApp.ofOrder.ofOrderCenter;
using BusinessView.ofUser.ofCommon;

namespace BusinessView.ofViewModels.ofWebApp.ofEmployee.ofOrder
{
    public class EmployeePostOrderCenterViewModel : OrderCenterPostViewModel<EmployeeOrderCenter>
    {
        private readonly EmployeeActorContext _EmployeeActorContext;
        public EmployeePostOrderCenterViewModel(EmployeeActorContext EmployeeActorContext)
            : base(EmployeeActorContext)
        {
            _EmployeeActorContext = EmployeeActorContext;
        }
    }
    public class EmployeePutOrderCenterViewModel : OrderCenterPutViewModel<EmployeeOrderCenter>
    {
        private readonly EmployeeActorContext _EmployeeActorContext;
        public EmployeePutOrderCenterViewModel(EmployeeActorContext EmployeeActorContext)
            :base(EmployeeActorContext)
        {
            _EmployeeActorContext = EmployeeActorContext;
        }
    }
    public class EmployeeDeleteOrderCenterViewModel : OrderCenterDeleteViewModel<EmployeeOrderCenter>
    {
        private readonly EmployeeActorContext _EmployeeActorContext;
        public EmployeeDeleteOrderCenterViewModel(EmployeeActorContext EmployeeActorContext)
            :base(EmployeeActorContext)
        {
            _EmployeeActorContext = EmployeeActorContext;
        }
    }
    public class EmployeeGetsOrderCenterViewModel : OrderCenterGetsViewModel<EmployeeOrderCenter>
    {
        private readonly EmployeeActorContext _EmployeeActorContext;
        public EmployeeGetsOrderCenterViewModel(EmployeeActorContext EmployeeActorContext)
            :base(EmployeeActorContext)
        {
            _EmployeeActorContext = EmployeeActorContext;
        }
    }
}
