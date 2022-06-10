using BusinessData.ofPresentationLayer.ofActorContext.ofBusiness;
using BusinessView.ofUser.ofCommon;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessData.ofPresentationLayer.ofDTO.ofMarket.ofProducter
{
    [ActorContext(typeof(ProducterContext))]
    public class ProducterMarket : MarketDTO
    {
    }
    [ActorContext(typeof(ProducterContext))]
    public class ProducterPlatMarket : PlatMarketDTO
    {
    }
    [ActorContext(typeof(ProducterContext))]
    public class ProducterMCommodity : MCommodityDTO
    {
    }
    [ActorContext(typeof(ProducterContext))]
    public class ProducterSMCommodity : SMCommodityDTO
    {
    }
    [ActorContext(typeof(ProducterContext))]
    public class ProducterMMCommodity : MMCommodityDTO
    {
    }
    [ActorContext(typeof(ProducterContext))]
    public class ProducterEMCommodity : EMCommodityDTO
    {
    }
}
