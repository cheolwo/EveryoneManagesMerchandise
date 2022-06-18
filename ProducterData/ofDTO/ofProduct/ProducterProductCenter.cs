using BusinessData.ofPresentationLayer.ofActorContext.ofBusiness;
using BusinessView.ofUser.ofCommon;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessData.ofPresentationLayer.ofDTO.ofProduct.ofProducter
{
    [ActorContext(typeof(ProducterContext))]
    public class ProducterProductCenter : ProductCenterDTO
    {
    }
    [ActorContext(typeof(ProducterContext))]
    public class ProducterProducter : ProducterDTO
    {
    }
    [ActorContext(typeof(ProducterContext))]
    public class ProducterProductLand : ProductLandDTO
    {
    }
    [ActorContext(typeof(ProducterContext))]
    public class ProducterPCommodity : PCommodityDTO
    {
    }
    [ActorContext(typeof(ProducterContext))]
    public class ProducterSPCommodity : SPCommodityDTO
    {
    }
    [ActorContext(typeof(ProducterContext))]
    public class ProducterMPCommodity : MPCommodityDTO
    {
    }
    [ActorContext(typeof(ProducterContext))]
    public class ProducterEPCommodity : EPCommodityDTO
    {
    }
}
