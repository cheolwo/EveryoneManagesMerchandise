using BusinessView.ofUser.ofCommon;
using BusinessView.ofUser.ofPlatform;

namespace BusinessData.ofPresentationLayer.ofDTO.ofOrder.ofOrderer.ofPlatform
{
    [ActorContext(typeof(PlatformOrdererContext))]
    public class PlatformOrdererOrderCenter : OrdererOrderCenter
    {
    }
    [ActorContext(typeof(PlatformOrdererContext))]
    public class PlatformOrdererOCommodity : OrdererOCommodity
    {
    }
    [ActorContext(typeof(PlatformOrdererContext))]
    public class PlatformOrdererSOCommodity : OrdererSOCommodity
    {
    }
    [ActorContext(typeof(PlatformOrdererContext))]
    public class PlatformOrdererMOCommodity : OrdererMOCommodity
    {
    }
    [ActorContext(typeof(PlatformOrdererContext))]
    public class PlatformOrdererEOCommodity : OrdererEOCommodity
    {
    }
}
