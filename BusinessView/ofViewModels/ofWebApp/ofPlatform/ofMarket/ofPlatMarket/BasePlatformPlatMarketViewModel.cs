using BusinessView.ofCommon.ofUser;
using BusinessView.ofViewModels.ofGeneric.ofCommon;
using BusinessView.ofDTO.ofMarket.ofPlatform;

namespace BusinessView.ofViewModels.ofWebApp.ofPlatform.ofMarket
{
    public class BasePlatformPlatMarketViewModel : BaseCenterViewModel<PlatformPlatMarket>
    {
        public BasePlatformPlatMarketViewModel(PlatformActorContext PlatformActorContext)
            :base(PlatformActorContext)
        {
        }
    }
    public class PlatformPostPlatMarketViewModel : CenterPostViewModel<PlatformPlatMarket>
    {
        public PlatformPostPlatMarketViewModel(PlatformActorContext PlatformActorContext)
            : base(PlatformActorContext)
        {

        }
    }
    public class PlatformPutPlatMarketViewModel : CenterPutViewModel<PlatformPlatMarket>
    {
        public PlatformPutPlatMarketViewModel(PlatformActorContext PlatformActorContext)
            :base(PlatformActorContext)
        {

        }
    }
    public class PlatformDeletePlatMarketViewModel : CenterDeleteViewModel<PlatformPlatMarket>
    {
        public PlatformDeletePlatMarketViewModel(PlatformActorContext PlatformActorContext)
            :base(PlatformActorContext)
        {

        }
    }
    public class PlatformGetsPlatMarketViewModel : CenterGetsViewModel<PlatformPlatMarket>
    {
        public PlatformGetsPlatMarketViewModel(PlatformActorContext PlatformActorContext)
            :base(PlatformActorContext)
        {

        }
    }
}
