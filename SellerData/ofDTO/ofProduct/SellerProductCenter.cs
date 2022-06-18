using BusinessData.ofPresentationLayer.ofActorContext.ofBusiness;
using BusinessView.ofUser.ofCommon;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessData.ofPresentationLayer.ofDTO.ofProduct.ofSeller
{
    [ActorContext(typeof(SellerContext))]
    public class SellerProductCenter : ProductCenterDTO
    {
    }
    [ActorContext(typeof(SellerContext))]
    public class SellerProducter : ProducterDTO
    {
    }
    [ActorContext(typeof(SellerContext))]
    public class SellerProductLand : ProductLandDTO
    {
    }
    [ActorContext(typeof(SellerContext))]
    public class SellerPCommodity : PCommodityDTO
    {
    }
    [ActorContext(typeof(SellerContext))]
    public class SellerSPCommodity : SPCommodityDTO
    {
    }
    [ActorContext(typeof(SellerContext))]
    public class SellerMPCommodity : MPCommodityDTO
    {
    }
    [ActorContext(typeof(SellerContext))]
    public class SellerEPCommodity : EPCommodityDTO
    {
    }
}
