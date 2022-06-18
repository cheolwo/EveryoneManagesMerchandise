using BusinessData.ofPresendationLayer.ofActorContext.ofCommon;
using BusinessData.ofPresendationLayer.ofActorContext.ofPlatform;

namespace BusinessData.ofPresentationLayer.ofDTO.ofTrade.ofLogister.ofPlatform
{
    [ActorContext(typeof(PlatformLogisterContext))]
    public class PlatformLogisterTradeCenter : LogisterTradeCenter
    {
    }
    [ActorContext(typeof(PlatformLogisterContext))]
    public class PlatformLogisterTCommodity : LogisterTCommodity
    {
    }
    [ActorContext(typeof(PlatformLogisterContext))]
    public class PlatformLogisterSTCommodity : LogisterSTCommodity
    {
    }
    [ActorContext(typeof(PlatformLogisterContext))]
    public class PlatformLogisterMTCommodity : LogisterMTCommodity
    {
    }
    [ActorContext(typeof(PlatformLogisterContext))]
    public class PlatformLogisterETCommodity : LogisterETCommodity
    {
    }
}
