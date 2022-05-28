using BusinessView.ofCommon.ofUser;
using BusinessView.ofViewModels.ofGeneric.ofCommon;
using BusinessView.ofDTO.ofProduct.ofPlatform;

namespace BusinessView.ofViewModels.ofWebApp.ofPlatform.ofProduct
{
    public class BasePlatformProductLandViewModel : BaseEntityViewModel<PlatformProductLand>
    {
        public BasePlatformProductLandViewModel(PlatformActorContext PlatformActorContext)
            :base(PlatformActorContext)
        {
        }
    }
    public class PlatformPostProductLandViewModel : EntityPostViewModel<PlatformProductLand>
    {
        public PlatformPostProductLandViewModel(PlatformActorContext PlatformActorContext)
            : base(PlatformActorContext)
        {

        }
    }
    public class PlatformPutProductLandViewModel : EntityPutViewModel<PlatformProductLand>
    {
        public PlatformPutProductLandViewModel(PlatformActorContext PlatformActorContext)
            :base(PlatformActorContext)
        {

        }
    }
    public class PlatformDeleteProductLandViewModel : EntityDeleteViewModel<PlatformProductLand>
    {
        public PlatformDeleteProductLandViewModel(PlatformActorContext PlatformActorContext)
            :base(PlatformActorContext)
        {

        }
    }
    public class PlatformGetsProductLandViewModel : EntityGetsViewModel<PlatformProductLand>
    {
        public PlatformGetsProductLandViewModel(PlatformActorContext PlatformActorContext)
            :base(PlatformActorContext)
        {

        }
    }
}
