using BusinessView.ofCommon.ofUser;
using BusinessView.ofViewModels.ofGeneric.ofCommon;
using BusinessView.ofDTO.ofProduct.ofPlatform;

namespace BusinessView.ofViewModels.ofWebApp.ofPlatform.ofProduct
{
    public class BasePlatformProducterViewModel : BaseCenterViewModel<PlatformProducter>
    {
        public BasePlatformProducterViewModel(PlatformActorContext PlatformActorContext)
            :base(PlatformActorContext)
        {
        }
    }
    public class PlatformPostProducterViewModel : CenterPostViewModel<PlatformProducter>
    {
        public PlatformPostProducterViewModel(PlatformActorContext PlatformActorContext)
            : base(PlatformActorContext)
        {

        }
    }
    public class PlatformPutProducterViewModel : CenterPutViewModel<PlatformProducter>
    {
        public PlatformPutProducterViewModel(PlatformActorContext PlatformActorContext)
            :base(PlatformActorContext)
        {

        }
    }
    public class PlatformDeleteProducterViewModel : CenterDeleteViewModel<PlatformProducter>
    {
        public PlatformDeleteProducterViewModel(PlatformActorContext PlatformActorContext)
            :base(PlatformActorContext)
        {

        }
    }
    public class PlatformGetsProducterViewModel : CenterGetsViewModel<PlatformProducter>
    {
        public PlatformGetsProducterViewModel(PlatformActorContext PlatformActorContext)
            :base(PlatformActorContext)
        {

        }
    }
}
