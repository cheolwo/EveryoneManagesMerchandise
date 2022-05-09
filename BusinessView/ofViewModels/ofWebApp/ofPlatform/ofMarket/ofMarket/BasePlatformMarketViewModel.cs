using BusinessView.ofCommon.ofUser;
using BusinessView.ofViewModels.ofGeneric.ofCommon;
using BusinessView.ofDTO.ofMarket.ofPlatform;

namespace BusinessView.ofViewModels.ofWebApp.ofPlatform.ofMarket
{
    public class BasePlatformMarketViewModel : BaseCenterViewModel<PlatformMarket>
    {
        public BasePlatformMarketViewModel(PlatformActorContext PlatformActorContext)
            :base(PlatformActorContext)
        {
        }
    }
    public class PlatformPostMarketViewModel : CenterPostViewModel<PlatformMarket>
    {
        public PlatformPostMarketViewModel(PlatformActorContext PlatformActorContext)
            : base(PlatformActorContext)
        {

        }
    }
    public class PlatformPutMarketViewModel : CenterPutViewModel<PlatformMarket>
    {
        public PlatformPutMarketViewModel(PlatformActorContext PlatformActorContext)
            :base(PlatformActorContext)
        {

        }
    }
    public class PlatformDeleteMarketViewModel : CenterDeleteViewModel<PlatformMarket>
    {
        public PlatformDeleteMarketViewModel(PlatformActorContext PlatformActorContext)
            :base(PlatformActorContext)
        {

        }
    }
    public class PlatformGetsMarketViewModel : CenterGetsViewModel<PlatformMarket>
    {
        public PlatformGetsMarketViewModel(PlatformActorContext PlatformActorContext)
            :base(PlatformActorContext)
        {

        }
    }
}
