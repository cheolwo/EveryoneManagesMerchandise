using BusinessView.ofCommon.ofUser;
using BusinessView.ofViewModels.ofWebApp.ofProduct.ofProductLand;
using BusinessData.ofPresentationLayer.ofDTO.ofProduct.ofPlatform;

namespace BusinessView.ofViewModels.ofWebApp.ofPlatform.ofProduct
{
    public class PlatformPostProductLandViewModel : ProductLandPostViewModel<PlatformProductLand>
    {
        private readonly PlatformActorContext _PlatformActorContext;
        public PlatformPostProductLandViewModel(PlatformActorContext PlatformActorContext)
            : base(PlatformActorContext)
        {
            _PlatformActorContext = PlatformActorContext;
        }
    }
    public class PlatformPutProductLandViewModel : ProductLandPutViewModel<PlatformProductLand>
    {
        private readonly PlatformActorContext _PlatformActorContext;
        public PlatformPutProductLandViewModel(PlatformActorContext PlatformActorContext)
            :base(PlatformActorContext)
        {
            _PlatformActorContext = PlatformActorContext;
        }
    }
    public class PlatformDeleteProductLandViewModel : ProductLandDeleteViewModel<PlatformProductLand>
    {
        private readonly PlatformActorContext _PlatformActorContext;
        public PlatformDeleteProductLandViewModel(PlatformActorContext PlatformActorContext)
            :base(PlatformActorContext)
        {
            _PlatformActorContext = PlatformActorContext;
        }
    }
    public class PlatformGetsProductLandViewModel : ProductLandGetsViewModel<PlatformProductLand>
    {
        private readonly PlatformActorContext _PlatformActorContext;
        public PlatformGetsProductLandViewModel(PlatformActorContext PlatformActorContext)
            :base(PlatformActorContext)
        {
            _PlatformActorContext = PlatformActorContext;
        }
    }
}