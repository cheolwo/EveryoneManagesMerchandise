using BusinessData.ofPresentationLayer.ofActorContext.ofBusiness;
using BusinessView.ofUser.ofCommon;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessData.ofPresentationLayer.ofDTO.ofTrade.ofProducter
{
    [ActorContext(typeof(ProducterContext))]
    public class ProducterTradeCenter : TradeCenterDTO
    {
    }
    [ActorContext(typeof(ProducterContext))]
    public class ProducterTCommodity : TCommodityDTO
    {
    }
    [ActorContext(typeof(ProducterContext))]
    public class ProducterSTCommodity : STCommodityDTO
    {
    }
    [ActorContext(typeof(ProducterContext))]
    public class ProducterMTCommodity : MTCommodityDTO
    {
    }
    [ActorContext(typeof(ProducterContext))]
    public class ProducterETCommodity : ETCommodityDTO
    {
    }
}
