using BusinessData.ofPresentationLayer.ofActorContext.ofBusiness;
using BusinessView.ofUser.ofCommon;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessData.ofPresentationLayer.ofDTO.ofOrder.ofSeller
{
    [ActorContext(typeof(SellerContext))]
    public class SellerOrderCenter : OrderCenterDTO
    {
    }
    [ActorContext(typeof(SellerContext))]
    public class SellerOCommodity : OCommodityDTO
    {
    }
    [ActorContext(typeof(SellerContext))]
    public class SellerSOCommodity : SOCommodityDTO
    {
    }
    [ActorContext(typeof(SellerContext))]
    public class SellerMOCommodity : MOCommodityDTO
    {
    }
    [ActorContext(typeof(SellerContext))]
    public class SellerEOCommodity : EOCommodityDTO
    {
    }
}
