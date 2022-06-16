using BusinessData.ofPresendationLayer.ofActorContext.ofCommon;
using BusinessData.ofPresendationLayer.ofActorContext.ofPlatform;

namespace BusinessData.ofPresentationLayer.ofDTO.ofHR.ofForwarder.ofPlatform
{
    [ActorContext(typeof(PlatformForwarderContext))]
    public class PlatformForwarderHRCenter : ForwarderHRCenter
    {
    }
    [ActorContext(typeof(PlatformForwarderContext))]
    public class PlatformForwarderHRBusinessPart : ForwarderHRBusinessPart
    {
    }
    [ActorContext(typeof(PlatformForwarderContext))]
    public class PlatformForwarderHREmployee : ForwarderHREmployee
    {
    }
    [ActorContext(typeof(PlatformForwarderContext))]
    public class PlatformForwarderHRRole : ForwarderHRRole
    {
    }
    [ActorContext(typeof(PlatformForwarderContext))]
    public class PlatformForwarderPlatformRole : ForwarderEmployeeRole
    {
    }
}
