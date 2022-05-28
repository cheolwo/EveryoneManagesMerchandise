using BusinessView.ofDTO.ofProduct.ofPlatform;
using BusinessView.ofCommon.ofUser;
using BusinessView.ofViewModels.ofGeneric.ofCommon;
using BusinessView.ofViewModels.ofWebApp.ofProduct.ofPCommodity;
using BusinessView.ofUser.ofCommon;

namespace BusinessView.ofViewModels.ofWebApp.ofPlatform.ofProduct
{
    public class PlatformPostPCommodityViewModel : PCommodityPostViewModel<PlatformPCommodity>
    {
        private readonly PlatformActorContext _PlatformActorContext;
        public PlatformPostPCommodityViewModel(PlatformActorContext PlatformActorContext)
            : base(PlatformActorContext)
        {
            _PlatformActorContext = PlatformActorContext;
        }
    }
    public class PlatformPutPCommodityViewModel : PCommodityPutViewModel<PlatformPCommodity>
    {
        private readonly PlatformActorContext _PlatformActorContext;
        public PlatformPutPCommodityViewModel(PlatformActorContext PlatformActorContext)
            :base(PlatformActorContext)
        {
            _PlatformActorContext = PlatformActorContext;
        }
    }
    public class PlatformDeletePCommodityViewModel : PCommodityDeleteViewModel<PlatformPCommodity>
    {
        private readonly PlatformActorContext _PlatformActorContext;
        public PlatformDeletePCommodityViewModel(PlatformActorContext PlatformActorContext)
            :base(PlatformActorContext)
        {
            _PlatformActorContext = PlatformActorContext;
        }
    }
    public class PlatformGetsPCommodityViewModel : PCommodityGetsViewModel<PlatformPCommodity>
    {
        private readonly PlatformActorContext _PlatformActorContext;
        public PlatformGetsPCommodityViewModel(PlatformActorContext PlatformActorContext)
            :base(PlatformActorContext)
        {
            _PlatformActorContext = PlatformActorContext;
        }
    }
}
