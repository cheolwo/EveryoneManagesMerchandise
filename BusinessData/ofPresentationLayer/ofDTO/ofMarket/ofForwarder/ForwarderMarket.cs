using BusinessData.ofPresentationLayer.ofActorContext.ofBusiness;
using BusinessView.ofUser.ofCommon;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessData.ofPresentationLayer.ofDTO.ofMarket.ofForwarder
{
    [ActorContext(typeof(ForwarderContext))]
    public class ForwarderMarket : MarketDTO
    {
    }
    [ActorContext(typeof(ForwarderContext))]
    public class ForwarderPlatMarket : PlatMarketDTO
    {
    }
    [ActorContext(typeof(ForwarderContext))]
    public class ForwarderMCommodity : MCommodityDTO
    {
    }
    [ActorContext(typeof(ForwarderContext))]
    public class ForwarderSMCommodity : SMCommodityDTO
    {
    }
    [ActorContext(typeof(ForwarderContext))]
    public class ForwarderMMCommodity : MMCommodityDTO
    {
    }
    [ActorContext(typeof(ForwarderContext))]
    public class ForwarderEMCommodity : EMCommodityDTO
    {
    }
}
