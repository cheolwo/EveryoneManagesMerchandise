using BusinessView.ofCommon.ofUser;
using BusinessView.ofViewModels.ofGeneric.ofCommon;
using BusinessView.ofDTO.ofOrder.ofPlatform;

namespace BusinessView.ofViewModels.ofWebApp.ofPlatform.ofOrder
{
    public class BasePlatformOrderCenterViewModel : BaseCenterViewModel<PlatformOrderCenter>
    {
        public BasePlatformOrderCenterViewModel(PlatformActorContext PlatformActorContext)
            :base(PlatformActorContext)
        {
        }
    }
    public class PlatformPostOrderCenterViewModel : CenterPostViewModel<PlatformOrderCenter>
    {
        public PlatformPostOrderCenterViewModel(PlatformActorContext PlatformActorContext)
            : base(PlatformActorContext)
        {

        }
    }
    public class PlatformPutOrderCenterViewModel : CenterPutViewModel<PlatformOrderCenter>
    {
        public PlatformPutOrderCenterViewModel(PlatformActorContext PlatformActorContext)
            :base(PlatformActorContext)
        {

        }
    }
    public class PlatformDeleteOrderCenterViewModel : CenterDeleteViewModel<PlatformOrderCenter>
    {
        public PlatformDeleteOrderCenterViewModel(PlatformActorContext PlatformActorContext)
            :base(PlatformActorContext)
        {

        }
    }
    public class PlatformGetsOrderCenterViewModel : CenterGetsViewModel<PlatformOrderCenter>
    {
        public PlatformGetsOrderCenterViewModel(PlatformActorContext PlatformActorContext)
            :base(PlatformActorContext)
        {

        }
    }
}
