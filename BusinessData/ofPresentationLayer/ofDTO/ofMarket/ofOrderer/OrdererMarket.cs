using BusinessData.ofPresentationLayer.ofActorContext.ofBusiness;
using BusinessView.ofUser.ofCommon;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessData.ofPresentationLayer.ofDTO.ofMarket.ofOrderer
{
    [ActorContext(typeof(OrdererContext))]
    public class OrdererMarket : MarketDTO
    {
    }
    [ActorContext(typeof(OrdererContext))]
    public class OrdererPlatMarket : PlatMarketDTO
    {
    }
    [ActorContext(typeof(OrdererContext))]
    public class OrdererMCommodity : MCommodityDTO
    {
    }
    [ActorContext(typeof(OrdererContext))]
    public class OrdererSMCommodity : SMCommodityDTO
    {
    }
    [ActorContext(typeof(OrdererContext))]
    public class OrdererMMCommodity : MMCommodityDTO
    {
    }
    [ActorContext(typeof(OrdererContext))]
    public class OrdererEMCommodity : EMCommodityDTO
    {
    }
}
