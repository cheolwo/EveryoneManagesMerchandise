using BusinessView.ofCommon.ofUser;
using BusinessView.ofViewModels.ofWebApp.ofOrder.ofOrderCenter;
using BusinessData.ofPresentationLayer.ofDTO.ofOrder.ofEmployee;

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
