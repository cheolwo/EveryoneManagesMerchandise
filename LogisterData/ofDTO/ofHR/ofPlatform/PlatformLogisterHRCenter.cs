using BusinessData.ofPresendationLayer.ofActorContext.ofCommon;
using BusinessData.ofPresendationLayer.ofActorContext.ofPlatform;

namespace BusinessData.ofPresentationLayer.ofDTO.ofHR.ofLogister.ofPlatform
{
    [ActorContext(typeof(PlatformLogisterContext))]
    public class PlatformLogisterHRCenter : LogisterHRCenter
    {
    }
    [ActorContext(typeof(PlatformLogisterContext))]
    public class PlatformLogisterHRBusinessPart : LogisterHRBusinessPart
    {
    }
    [ActorContext(typeof(PlatformLogisterContext))]
    public class PlatformLogisterHREmployee : LogisterHREmployee
    {
    }
    [ActorContext(typeof(PlatformLogisterContext))]
    public class PlatformLogisterHRRole : LogisterHRRole
    {
    }
    [ActorContext(typeof(PlatformLogisterContext))]
    public class PlatformLogisterPlatformRole : LogisterEmployeeRole
    {
    }
}
