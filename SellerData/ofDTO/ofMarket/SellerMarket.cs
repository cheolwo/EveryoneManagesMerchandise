using BusinessData.ofPresentationLayer.ofActorContext.ofBusiness;
using BusinessView.ofUser.ofCommon;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessData.ofPresentationLayer.ofDTO.ofMarket.ofSeller
{
    [ActorContext(typeof(SellerContext))]
    public class SellerMarket : MarketDTO
    {
    }
    [ActorContext(typeof(SellerContext))]
    public class SellerPlatMarket : PlatMarketDTO
    {
    }
    [ActorContext(typeof(SellerContext))]
    public class SellerMCommodity : MCommodityDTO
    {
    }
    [ActorContext(typeof(SellerContext))]
    public class SellerSMCommodity : SMCommodityDTO
    {
    }
    [ActorContext(typeof(SellerContext))]
    public class SellerMMCommodity : MMCommodityDTO
    {
    }
    [ActorContext(typeof(SellerContext))]
    public class SellerEMCommodity : EMCommodityDTO
    {
    }
}
