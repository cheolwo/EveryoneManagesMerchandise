using BusinessView.ofDTO.ofOrder.ofPlatform;
using BusinessView.ofCommon.ofUser;
using BusinessView.ofViewModels.ofGeneric.ofCommon;
using BusinessView.ofViewModels.ofWebApp.ofOrder.ofMOCommodity;
using BusinessView.ofUser.ofCommon;

namespace BusinessView.ofViewModels.ofWebApp.ofPlatform.ofOrder
{
    public class PlatformPostMOCommodityViewModel : MOCommodityPostViewModel<PlatformMOCommodity>
    {
        private readonly PlatformActorContext _PlatformActorContext;
        public PlatformPostMOCommodityViewModel(PlatformActorContext PlatformActorContext)
            : base(PlatformActorContext)
        {
            _PlatformActorContext = PlatformActorContext;
        }
    }
    public class PlatformPutMOCommodityViewModel : MOCommodityPutViewModel<PlatformMOCommodity>
    {
        private readonly PlatformActorContext _PlatformActorContext;
        public PlatformPutMOCommodityViewModel(PlatformActorContext PlatformActorContext)
            :base(PlatformActorContext)
        {
            _PlatformActorContext = PlatformActorContext;
        }
    }
    public class PlatformDeleteMOCommodityViewModel : MOCommodityDeleteViewModel<PlatformMOCommodity>
    {
        private readonly PlatformActorContext _PlatformActorContext;
        public PlatformDeleteMOCommodityViewModel(PlatformActorContext PlatformActorContext)
            :base(PlatformActorContext)
        {
            _PlatformActorContext = PlatformActorContext;
        }
    }
    public class PlatformGetsMOCommodityViewModel : MOCommodityGetsViewModel<PlatformMOCommodity>
    {
        private readonly PlatformActorContext _PlatformActorContext;
        public PlatformGetsMOCommodityViewModel(PlatformActorContext PlatformActorContext)
            :base(PlatformActorContext)
        {
            _PlatformActorContext = PlatformActorContext;
        }
    }
}
