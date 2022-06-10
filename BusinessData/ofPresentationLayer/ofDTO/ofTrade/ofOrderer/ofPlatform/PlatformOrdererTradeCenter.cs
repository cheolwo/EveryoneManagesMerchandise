using BusinessView.ofUser.ofCommon;
using BusinessView.ofUser.ofPlatform;

namespace BusinessData.ofPresentationLayer.ofDTO.ofTrade.ofOrderer.ofPlatform
{
    [ActorContext(typeof(PlatformOrdererContext))]
    public class PlatformOrdererTradeCenter : OrdererTradeCenter
    {
    }
    [ActorContext(typeof(PlatformOrdererContext))]
    public class PlatformOrdererTCommodity : OrdererTCommodity
    {
    }
    [ActorContext(typeof(PlatformOrdererContext))]
    public class PlatformOrdererSTCommodity : OrdererSTCommodity
    {
    }
    [ActorContext(typeof(PlatformOrdererContext))]
    public class PlatformOrdererMTCommodity : OrdererMTCommodity
    {
    }
    [ActorContext(typeof(PlatformOrdererContext))]
    public class PlatformOrdererETCommodity : OrdererETCommodity
    {
    }
}
