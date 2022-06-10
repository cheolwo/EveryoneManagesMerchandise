using BusinessView.ofUser.ofCommon;
using BusinessView.ofUser.ofPlatform;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessData.ofPresentationLayer.ofDTO.ofMarket.ofProducter.ofPlatform
{
    [ActorContext(typeof(PlatformProducterContext))]
    public class PlatformProducterMarket : ProducterMarket
    {
    }
    [ActorContext(typeof(PlatformProducterContext))]
    public class PlatformProducterPlatMarket : ProducterPlatMarket
    {
    }
    [ActorContext(typeof(PlatformProducterContext))]
    public class PlatformProducterMCommodity : ProducterMCommodity
    {
    }
    [ActorContext(typeof(PlatformProducterContext))]
    public class PlatformProducterSMCommodity : ProducterSMCommodity
    {
    }
    [ActorContext(typeof(PlatformProducterContext))]
    public class PlatformProducterMMCommodity : ProducterMMCommodity
    {
    }
    [ActorContext(typeof(PlatformProducterContext))]
    public class PlatformProducterEMCommodity : ProducterEMCommodity
    {
    }
}
