using BusinessView.ofDTO.ofProduct.ofPlatform;
using BusinessView.ofCommon.ofUser;
using BusinessView.ofViewModels.ofGeneric.ofCommon;
using BusinessView.ofViewModels.ofWebApp.ofProduct.ofSPCommodity;
using BusinessView.ofUser.ofCommon;

namespace BusinessView.ofViewModels.ofWebApp.ofPlatform.ofProduct
{
    public class PlatformPostSPCommodityViewModel : SPCommodityPostViewModel<PlatformSPCommodity>
    {
        private readonly PlatformActorContext _PlatformActorContext;
        public PlatformPostSPCommodityViewModel(PlatformActorContext PlatformActorContext)
            : base(PlatformActorContext)
        {
            _PlatformActorContext = PlatformActorContext;
        }
    }
    public class PlatformPutSPCommodityViewModel : SPCommodityPutViewModel<PlatformSPCommodity>
    {
        private readonly PlatformActorContext _PlatformActorContext;
        public PlatformPutSPCommodityViewModel(PlatformActorContext PlatformActorContext)
            :base(PlatformActorContext)
        {
            _PlatformActorContext = PlatformActorContext;
        }
    }
    public class PlatformDeleteSPCommodityViewModel : SPCommodityDeleteViewModel<PlatformSPCommodity>
    {
        private readonly PlatformActorContext _PlatformActorContext;
        public PlatformDeleteSPCommodityViewModel(PlatformActorContext PlatformActorContext)
            :base(PlatformActorContext)
        {
            _PlatformActorContext = PlatformActorContext;
        }
    }
    public class PlatformGetsSPCommodityViewModel : SPCommodityGetsViewModel<PlatformSPCommodity>
    {
        private readonly PlatformActorContext _PlatformActorContext;
        public PlatformGetsSPCommodityViewModel(PlatformActorContext PlatformActorContext)
            :base(PlatformActorContext)
        {
            _PlatformActorContext = PlatformActorContext;
        }
    }
}
