using BusinessView.ofUser.ofCommon;
using BusinessView.ofUser.ofPlatform;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessData.ofPresentationLayer.ofDTO.ofMarket.ofForwarder.ofPlatform
{
    [ActorContext(typeof(PlatformForwarderContext))]
    public class PlatformForwarderMarket : ForwarderMarket
    {
    }
    [ActorContext(typeof(PlatformForwarderContext))]
    public class PlatformForwarderPlatMarket : ForwarderPlatMarket
    {
    }
    [ActorContext(typeof(PlatformForwarderContext))]
    public class PlatformForwarderMCommodity : ForwarderMCommodity
    {
    }
    [ActorContext(typeof(PlatformForwarderContext))]
    public class PlatformForwarderSMCommodity : ForwarderSMCommodity
    {
    }
    [ActorContext(typeof(PlatformForwarderContext))]
    public class PlatformForwarderMMCommodity : ForwarderMMCommodity
    {
    }
    [ActorContext(typeof(PlatformForwarderContext))]
    public class PlatformForwarderEMCommodity : ForwarderEMCommodity
    {
    }
}
