using BusinessData.ofPresentationLayer.ofActorContext.ofBusiness;
using BusinessView.ofUser.ofCommon;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessData.ofPresentationLayer.ofDTO.ofOrder.ofProducter
{
    [ActorContext(typeof(ProducterContext))]
    public class ProducterOrderCenter : OrderCenterDTO
    {
    }
    [ActorContext(typeof(ProducterContext))]
    public class ProducterOCommodity : OCommodityDTO
    {
    }
    [ActorContext(typeof(ProducterContext))]
    public class ProducterSOCommodity : SOCommodityDTO
    {
    }
    [ActorContext(typeof(ProducterContext))]
    public class ProducterMOCommodity : MOCommodityDTO
    {
    }
    [ActorContext(typeof(ProducterContext))]
    public class ProducterEOCommodity : EOCommodityDTO
    {
    }
}
