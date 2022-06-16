using BusinessData.ofPresendationLayer.ofActorContext.ofCommon;
using BusinessData.ofPresendationLayer.ofActorContext.ofPlatform;

namespace BusinessData.ofPresentationLayer.ofDTO.ofOrder.ofLogister.ofPlatform
{
    [ActorContext(typeof(PlatformLogisterContext))]
    public class PlatformLogisterOrderCenter : LogisterOrderCenter
    {
    }
    [ActorContext(typeof(PlatformLogisterContext))]
    public class PlatformLogisterOCommodity : LogisterOCommodity
    {
    }
    [ActorContext(typeof(PlatformLogisterContext))]
    public class PlatformLogisterSOCommodity : LogisterSOCommodity
    {
    }
    [ActorContext(typeof(PlatformLogisterContext))]
    public class PlatformLogisterMOCommodity : LogisterMOCommodity
    {
    }
    [ActorContext(typeof(PlatformLogisterContext))]
    public class PlatformLogisterEOCommodity : LogisterEOCommodity
    {
    }
}
