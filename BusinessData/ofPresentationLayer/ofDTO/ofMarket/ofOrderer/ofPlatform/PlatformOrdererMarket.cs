using BusinessView.ofUser.ofCommon;
using BusinessView.ofUser.ofPlatform;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessData.ofPresentationLayer.ofDTO.ofMarket.ofOrderer.ofPlatform
{
    [ActorContext(typeof(PlatformOrdererContext))]
    public class PlatformOrdererMarket : OrdererMarket
    {
    }
    [ActorContext(typeof(PlatformOrdererContext))]
    public class PlatformOrdererPlatMarket : OrdererPlatMarket
    {
    }
    [ActorContext(typeof(PlatformOrdererContext))]
    public class PlatformOrdererMCommodity : OrdererMCommodity
    {
    }
    [ActorContext(typeof(PlatformOrdererContext))]
    public class PlatformOrdererSMCommodity : OrdererSMCommodity
    {
    }
    [ActorContext(typeof(PlatformOrdererContext))]
    public class PlatformOrdererMMCommodity : OrdererMMCommodity
    {
    }
    [ActorContext(typeof(PlatformOrdererContext))]
    public class PlatformOrdererEMCommodity : OrdererEMCommodity
    {
    }
}
