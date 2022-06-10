using BusinessData.ofPresentationLayer.ofActorContext.ofBusiness;
using BusinessView.ofUser.ofCommon;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessData.ofPresentationLayer.ofDTO.ofTrade.ofSeller
{
    [ActorContext(typeof(SellerContext))]
    public class SellerTradeCenter : TradeCenterDTO
    {
    }
    [ActorContext(typeof(SellerContext))]
    public class SellerTCommodity : TCommodityDTO
    {
    }
    [ActorContext(typeof(SellerContext))]
    public class SellerSTCommodity : STCommodityDTO
    {
    }
    [ActorContext(typeof(SellerContext))]
    public class SellerMTCommodity : MTCommodityDTO
    {
    }
    [ActorContext(typeof(SellerContext))]
    public class SellerETCommodity : ETCommodityDTO
    {
    }
}
