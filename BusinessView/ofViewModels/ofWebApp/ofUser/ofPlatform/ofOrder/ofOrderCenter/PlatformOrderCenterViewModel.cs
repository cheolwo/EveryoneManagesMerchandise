using BusinessView.ofDTO.ofOrder.ofPlatform;
using BusinessView.ofCommon.ofUser;
using BusinessView.ofViewModels.ofGeneric.ofCommon;
using BusinessView.ofViewModels.ofWebApp.ofOrder.ofOrderCenter;
using BusinessView.ofUser.ofCommon;

namespace BusinessView.ofViewModels.ofWebApp.ofPlatform.ofOrder
{
    public class PlatformPostOrderCenterViewModel : OrderCenterPostViewModel<PlatformOrderCenter>
    {
        private readonly PlatformActorContext _PlatformActorContext;
        public PlatformPostOrderCenterViewModel(PlatformActorContext PlatformActorContext)
            : base(PlatformActorContext)
        {
            _PlatformActorContext = PlatformActorContext;
        }
    }
    public class PlatformPutOrderCenterViewModel : OrderCenterPutViewModel<PlatformOrderCenter>
    {
        private readonly PlatformActorContext _PlatformActorContext;
        public PlatformPutOrderCenterViewModel(PlatformActorContext PlatformActorContext)
            :base(PlatformActorContext)
        {
            _PlatformActorContext = PlatformActorContext;
        }
    }
    public class PlatformDeleteOrderCenterViewModel : OrderCenterDeleteViewModel<PlatformOrderCenter>
    {
        private readonly PlatformActorContext _PlatformActorContext;
        public PlatformDeleteOrderCenterViewModel(PlatformActorContext PlatformActorContext)
            :base(PlatformActorContext)
        {
            _PlatformActorContext = PlatformActorContext;
        }
    }
    public class PlatformGetsOrderCenterViewModel : OrderCenterGetsViewModel<PlatformOrderCenter>
    {
        private readonly PlatformActorContext _PlatformActorContext;
        public PlatformGetsOrderCenterViewModel(PlatformActorContext PlatformActorContext)
            :base(PlatformActorContext)
        {
            _PlatformActorContext = PlatformActorContext;
        }
    }
}
