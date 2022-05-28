using BusinessView.ofDTO.ofWarehouse.ofPlatform;
using BusinessView.ofCommon.ofUser;
using BusinessView.ofViewModels.ofGeneric.ofCommon;
using BusinessView.ofViewModels.ofWebApp.ofWarehouse.ofMWCommodity;
using BusinessView.ofUser.ofCommon;

namespace BusinessView.ofViewModels.ofWebApp.ofPlatform.ofWarehouse
{
    public class PlatformPostMWCommodityViewModel : MWCommodityPostViewModel<PlatformMWCommodity>
    {
        private readonly PlatformActorContext _PlatformActorContext;
        public PlatformPostMWCommodityViewModel(PlatformActorContext PlatformActorContext)
            : base(PlatformActorContext)
        {
            _PlatformActorContext = PlatformActorContext;
        }
    }
    public class PlatformPutMWCommodityViewModel : MWCommodityPutViewModel<PlatformMWCommodity>
    {
        private readonly PlatformActorContext _PlatformActorContext;
        public PlatformPutMWCommodityViewModel(PlatformActorContext PlatformActorContext)
            :base(PlatformActorContext)
        {
            _PlatformActorContext = PlatformActorContext;
        }
    }
    public class PlatformDeleteMWCommodityViewModel : MWCommodityDeleteViewModel<PlatformMWCommodity>
    {
        private readonly PlatformActorContext _PlatformActorContext;
        public PlatformDeleteMWCommodityViewModel(PlatformActorContext PlatformActorContext)
            :base(PlatformActorContext)
        {
            _PlatformActorContext = PlatformActorContext;
        }
    }
    public class PlatformGetsMWCommodityViewModel : MWCommodityGetsViewModel<PlatformMWCommodity>
    {
        private readonly PlatformActorContext _PlatformActorContext;
        public PlatformGetsMWCommodityViewModel(PlatformActorContext PlatformActorContext)
            :base(PlatformActorContext)
        {
            _PlatformActorContext = PlatformActorContext;
        }
    }
}
