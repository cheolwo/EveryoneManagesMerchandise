using BusinessView.ofUser.ofCommon;
using BusinessView.ofUser.ofPlatform;

namespace BusinessData.ofPresentationLayer.ofDTO.ofHR.ofOrderer.ofPlatform
{
    [ActorContext(typeof(PlatformOrdererContext))]
    public class PlatformOrdererHRCenter : OrdererHRCenter
    {
    }
    [ActorContext(typeof(PlatformOrdererContext))]
    public class PlatformOrdererHRBusinessPart : OrdererHRBusinessPart
    {
    }
    [ActorContext(typeof(PlatformOrdererContext))]
    public class PlatformOrdererHREmployee : OrdererHREmployee
    {
    }
    [ActorContext(typeof(PlatformOrdererContext))]
    public class PlatformOrdererHRRole : OrdererHRRole
    {
    }
    [ActorContext(typeof(PlatformOrdererContext))]
    public class PlatformOrdererPlatformRole : OrdererEmployeeRole
    {
    }
}
