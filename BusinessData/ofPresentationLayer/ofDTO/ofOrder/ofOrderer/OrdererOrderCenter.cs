using BusinessData.ofPresentationLayer.ofActorContext.ofBusiness;
using BusinessView.ofUser.ofCommon;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessData.ofPresentationLayer.ofDTO.ofOrder.ofOrderer
{
    [ActorContext(typeof(OrdererContext))]
    public class OrdererOrderCenter : OrderCenterDTO
    {
    }
    [ActorContext(typeof(OrdererContext))]
    public class OrdererOCommodity : OCommodityDTO
    {
    }
    [ActorContext(typeof(OrdererContext))]
    public class OrdererSOCommodity : SOCommodityDTO
    {
    }
    [ActorContext(typeof(OrdererContext))]
    public class OrdererMOCommodity : MOCommodityDTO
    {
    }
    [ActorContext(typeof(OrdererContext))]
    public class OrdererEOCommodity : EOCommodityDTO
    {
    }
}
