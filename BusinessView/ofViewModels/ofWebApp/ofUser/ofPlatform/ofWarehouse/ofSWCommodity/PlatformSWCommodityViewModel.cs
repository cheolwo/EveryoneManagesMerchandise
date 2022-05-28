using BusinessView.ofDTO.ofWarehouse.ofPlatform;
using BusinessView.ofCommon.ofUser;
using BusinessView.ofViewModels.ofGeneric.ofCommon;
using BusinessView.ofViewModels.ofWebApp.ofWarehouse.ofSWCommodity;
using BusinessView.ofUser.ofCommon;

namespace BusinessView.ofViewModels.ofWebApp.ofPlatform.ofWarehouse
{
    public class PlatformPostSWCommodityViewModel : SWCommodityPostViewModel<PlatformSWCommodity>
    {
        private readonly PlatformActorContext _PlatformActorContext;
        public PlatformPostSWCommodityViewModel(PlatformActorContext PlatformActorContext)
            : base(PlatformActorContext)
        {
            _PlatformActorContext = PlatformActorContext;
        }
    }
    public class PlatformPutSWCommodityViewModel : SWCommodityPutViewModel<PlatformSWCommodity>
    {
        private readonly PlatformActorContext _PlatformActorContext;
        public PlatformPutSWCommodityViewModel(PlatformActorContext PlatformActorContext)
            :base(PlatformActorContext)
        {
            _PlatformActorContext = PlatformActorContext;
        }
    }
    public class PlatformDeleteSWCommodityViewModel : SWCommodityDeleteViewModel<PlatformSWCommodity>
    {
        private readonly PlatformActorContext _PlatformActorContext;
        public PlatformDeleteSWCommodityViewModel(PlatformActorContext PlatformActorContext)
            :base(PlatformActorContext)
        {
            _PlatformActorContext = PlatformActorContext;
        }
    }
    public class PlatformGetsSWCommodityViewModel : SWCommodityGetsViewModel<PlatformSWCommodity>
    {
        private readonly PlatformActorContext _PlatformActorContext;
        public PlatformGetsSWCommodityViewModel(PlatformActorContext PlatformActorContext)
            :base(PlatformActorContext)
        {
            _PlatformActorContext = PlatformActorContext;
        }
    }
}
