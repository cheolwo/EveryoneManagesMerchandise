using BusinessView.ofCommon.ofUser;
using BusinessView.ofViewModels.ofGeneric.ofCommon;
using BusinessView.ofDTO.ofProduct.ofPlatform;

namespace BusinessView.ofViewModels.ofWebApp.ofPlatform.ofProduct
{
    public class BasePlatformProductCenterViewModel : BaseCenterViewModel<PlatformProductCenter>
    {
        public BasePlatformProductCenterViewModel(PlatformActorContext PlatformActorContext)
            :base(PlatformActorContext)
        {
        }
    }
    public class PlatformPostProductCenterViewModel : CenterPostViewModel<PlatformProductCenter>
    {
        public PlatformPostProductCenterViewModel(PlatformActorContext PlatformActorContext)
            : base(PlatformActorContext)
        {

        }
    }
    public class PlatformPutProductCenterViewModel : CenterPutViewModel<PlatformProductCenter>
    {
        public PlatformPutProductCenterViewModel(PlatformActorContext PlatformActorContext)
            :base(PlatformActorContext)
        {

        }
    }
    public class PlatformDeleteProductCenterViewModel : CenterDeleteViewModel<PlatformProductCenter>
    {
        public PlatformDeleteProductCenterViewModel(PlatformActorContext PlatformActorContext)
            :base(PlatformActorContext)
        {

        }
    }
    public class PlatformGetsProductCenterViewModel : CenterGetsViewModel<PlatformProductCenter>
    {
        public PlatformGetsProductCenterViewModel(PlatformActorContext PlatformActorContext)
            :base(PlatformActorContext)
        {

        }
    }
}
