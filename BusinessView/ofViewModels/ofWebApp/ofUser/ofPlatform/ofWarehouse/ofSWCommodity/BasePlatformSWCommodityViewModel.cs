using BusinessView.ofCommon.ofUser;
using BusinessView.ofViewModels.ofGeneric.ofCommon;
using BusinessView.ofDTO.ofWarehouse.ofPlatform;

namespace BusinessView.ofViewModels.ofWebApp.ofPlatform.ofWarehouse
{
    public class BasePlatformSWCommodityViewModel : BaseStatusViewModel<PlatformSWCommodity>
    {
        public BasePlatformSWCommodityViewModel(PlatformActorContext PlatformActorContext)
            :base(PlatformActorContext)
        {
        }
    }
    public class PlatformPostSWCommodityViewModel : StatusPostViewModel<PlatformSWCommodity>
    {
        public PlatformPostSWCommodityViewModel(PlatformActorContext PlatformActorContext)
            : base(PlatformActorContext)
        {

        }
    }
    public class PlatformPutSWCommodityViewModel : StatusPutViewModel<PlatformSWCommodity>
    {
        public PlatformPutSWCommodityViewModel(PlatformActorContext PlatformActorContext)
            :base(PlatformActorContext)
        {

        }
    }
    public class PlatformDeleteSWCommodityViewModel : StatusDeleteViewModel<PlatformSWCommodity>
    {
        public PlatformDeleteSWCommodityViewModel(PlatformActorContext PlatformActorContext)
            :base(PlatformActorContext)
        {

        }
    }
    public class PlatformGetsSWCommodityViewModel : StatusGetsViewModel<PlatformSWCommodity>
    {
        public PlatformGetsSWCommodityViewModel(PlatformActorContext PlatformActorContext)
            :base(PlatformActorContext)
        {

        }
    }
}
