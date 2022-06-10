using BusinessView.ofUser.ofCommon;
using BusinessView.ofUser.ofPlatform;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessData.ofPresentationLayer.ofDTO.ofMarket.ofSeller.ofPlatform
{
    [ActorContext(typeof(PlatformSellerContext))]
    public class PlatformSellerMarket : SellerMarket
    {
    }
    [ActorContext(typeof(PlatformSellerContext))]
    public class PlatformSellerPlatMarket : SellerPlatMarket
    {
    }
    [ActorContext(typeof(PlatformSellerContext))]
    public class PlatformSellerMCommodity : SellerMCommodity
    {
    }
    [ActorContext(typeof(PlatformSellerContext))]
    public class PlatformSellerSMCommodity : SellerSMCommodity
    {
    }
    [ActorContext(typeof(PlatformSellerContext))]
    public class PlatformSellerMMCommodity : SellerMMCommodity
    {
    }
    [ActorContext(typeof(PlatformSellerContext))]
    public class PlatformSellerEMCommodity : SellerEMCommodity
    {
    }
}
