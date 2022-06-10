using BusinessData.ofPresentationLayer.ofActorContext.ofBusiness;
using BusinessView.ofUser.ofCommon;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessData.ofPresentationLayer.ofDTO.ofMarket.ofLogister
{
    [ActorContext(typeof(LogisterContext))]
    public class LogisterMarket : MarketDTO
    {
    }
    [ActorContext(typeof(LogisterContext))]
    public class LogisterPlatMarket : PlatMarketDTO
    {
    }
    [ActorContext(typeof(LogisterContext))]
    public class LogisterMCommodity : MCommodityDTO
    {
    }
    [ActorContext(typeof(LogisterContext))]
    public class LogisterSMCommodity : SMCommodityDTO
    {
    }
    [ActorContext(typeof(LogisterContext))]
    public class LogisterMMCommodity : MMCommodityDTO
    {
    }
    [ActorContext(typeof(LogisterContext))]
    public class LogisterEMCommodity : EMCommodityDTO
    {
    }
}
