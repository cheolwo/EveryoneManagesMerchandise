using BusinessData.ofPresentationLayer.ofActorContext.ofBusiness;
using BusinessView.ofUser.ofCommon;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessData.ofPresentationLayer.ofDTO.ofTrade.ofOrderer
{
    [ActorContext(typeof(OrdererContext))]
    public class OrdererTradeCenter : TradeCenterDTO
    {
    }
    [ActorContext(typeof(OrdererContext))]
    public class OrdererTCommodity : TCommodityDTO
    {
    }
    [ActorContext(typeof(OrdererContext))]
    public class OrdererSTCommodity : STCommodityDTO
    {
    }
    [ActorContext(typeof(OrdererContext))]
    public class OrdererMTCommodity : MTCommodityDTO
    {
    }
    [ActorContext(typeof(OrdererContext))]
    public class OrdererETCommodity : ETCommodityDTO
    {
    }
}
