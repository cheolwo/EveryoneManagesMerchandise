using BusinessView.ofCommon.ofUser;
using BusinessView.ofViewModels.ofWebApp.ofOrder.ofOrderCenter;
using BusinessData.ofPresentationLayer.ofDTO.ofOrder.ofEmployer;

namespace BusinessView.ofViewModels.ofWebApp.ofEmployer.ofOrder
{
    public class EmployerPostOrderCenterViewModel : OrderCenterPostViewModel<EmployerOrderCenter>
    {
        private readonly EmployerActorContext _EmployerActorContext;
        public EmployerPostOrderCenterViewModel(EmployerActorContext EmployerActorContext)
            : base(EmployerActorContext)
        {
            _EmployerActorContext = EmployerActorContext;
        }
    }
    public class EmployerPutOrderCenterViewModel : OrderCenterPutViewModel<EmployerOrderCenter>
    {
        private readonly EmployerActorContext _EmployerActorContext;
        public EmployerPutOrderCenterViewModel(EmployerActorContext EmployerActorContext)
            :base(EmployerActorContext)
        {
            _EmployerActorContext = EmployerActorContext;
        }
    }
    public class EmployerDeleteOrderCenterViewModel : OrderCenterDeleteViewModel<EmployerOrderCenter>
    {
        private readonly EmployerActorContext _EmployerActorContext;
        public EmployerDeleteOrderCenterViewModel(EmployerActorContext EmployerActorContext)
            :base(EmployerActorContext)
        {
            _EmployerActorContext = EmployerActorContext;
        }
    }
    public class EmployerGetsOrderCenterViewModel : OrderCenterGetsViewModel<EmployerOrderCenter>
    {
        private readonly EmployerActorContext _EmployerActorContext;
        public EmployerGetsOrderCenterViewModel(EmployerActorContext EmployerActorContext)
            :base(EmployerActorContext)
        {
            _EmployerActorContext = EmployerActorContext;
        }
    }
}
