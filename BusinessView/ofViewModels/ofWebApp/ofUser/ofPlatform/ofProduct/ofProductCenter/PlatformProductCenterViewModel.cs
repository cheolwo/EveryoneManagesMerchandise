using BusinessView.ofDTO.ofProduct.ofPlatform;
using BusinessView.ofCommon.ofUser;
using BusinessView.ofViewModels.ofGeneric.ofCommon;
using BusinessView.ofViewModels.ofWebApp.ofProduct.ofProductCenter;
using BusinessView.ofUser.ofCommon;

namespace BusinessView.ofViewModels.ofWebApp.ofPlatform.ofProduct
{
    public class PlatformPostProductCenterViewModel : ProductCenterPostViewModel<PlatformProductCenter>
    {
        private readonly PlatformActorContext _PlatformActorContext;
        public PlatformPostProductCenterViewModel(PlatformActorContext PlatformActorContext)
            : base(PlatformActorContext)
        {
            _PlatformActorContext = PlatformActorContext;
        }
    }
    public class PlatformPutProductCenterViewModel : ProductCenterPutViewModel<PlatformProductCenter>
    {
        private readonly PlatformActorContext _PlatformActorContext;
        public PlatformPutProductCenterViewModel(PlatformActorContext PlatformActorContext)
            :base(PlatformActorContext)
        {
            _PlatformActorContext = PlatformActorContext;
        }
    }
    public class PlatformDeleteProductCenterViewModel : ProductCenterDeleteViewModel<PlatformProductCenter>
    {
        private readonly PlatformActorContext _PlatformActorContext;
        public PlatformDeleteProductCenterViewModel(PlatformActorContext PlatformActorContext)
            :base(PlatformActorContext)
        {
            _PlatformActorContext = PlatformActorContext;
        }
    }
    public class PlatformGetsProductCenterViewModel : ProductCenterGetsViewModel<PlatformProductCenter>
    {
        private readonly PlatformActorContext _PlatformActorContext;
        public PlatformGetsProductCenterViewModel(PlatformActorContext PlatformActorContext)
            :base(PlatformActorContext)
        {
            _PlatformActorContext = PlatformActorContext;
        }
    }
}
