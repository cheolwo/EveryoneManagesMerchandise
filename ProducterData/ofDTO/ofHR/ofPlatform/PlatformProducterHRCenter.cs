using BusinessData.ofPresendationLayer.ofActorContext.ofCommon;
using BusinessData.ofPresendationLayer.ofActorContext.ofPlatform;


namespace BusinessData.ofPresentationLayer.ofDTO.ofHR.ofProducter.ofPlatform
{
    [ActorContext(typeof(PlatformProducterContext))]
    public class PlatformProducterHRCenter : ProducterHRCenter
    {
    }
    [ActorContext(typeof(PlatformProducterContext))]
    public class PlatformProducterHRBusinessPart : ProducterHRBusinessPart
    {
    }
    [ActorContext(typeof(PlatformProducterContext))]
    public class PlatformProducterHREmployee : ProducterHREmployee
    {
    }
    [ActorContext(typeof(PlatformProducterContext))]
    public class PlatformProducterHRRole : ProducterHRRole
    {
    }
    [ActorContext(typeof(PlatformProducterContext))]
    public class PlatformProducterPlatformRole : ProducterEmployeeRole
    {
    }
}
