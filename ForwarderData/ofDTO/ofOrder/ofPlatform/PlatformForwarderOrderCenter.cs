using BusinessData.ofPresendationLayer.ofActorContext.ofCommon;
using BusinessData.ofPresendationLayer.ofActorContext.ofPlatform;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessData.ofPresentationLayer.ofDTO.ofOrder.ofForwarder.ofPlatform
{
    [ActorContext(typeof(PlatformForwarderContext))]
    public class PlatformForwarderOrderCenter : ForwarderOrderCenter
    {
    }
    [ActorContext(typeof(PlatformForwarderContext))]
    public class PlatformForwarderOCommodity : ForwarderOCommodity
    {
    }
    [ActorContext(typeof(PlatformForwarderContext))]
    public class PlatformForwarderSOCommodity : ForwarderSOCommodity
    {
    }
    [ActorContext(typeof(PlatformForwarderContext))]
    public class PlatformForwarderMOCommodity : ForwarderMOCommodity
    {
    }
    [ActorContext(typeof(PlatformForwarderContext))]
    public class PlatformForwarderEOCommodity : ForwarderEOCommodity
    {
    }
}
