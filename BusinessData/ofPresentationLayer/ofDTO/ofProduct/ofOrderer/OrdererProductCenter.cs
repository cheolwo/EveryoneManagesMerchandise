using BusinessData.ofPresentationLayer.ofActorContext.ofBusiness;
using BusinessView.ofUser.ofCommon;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessData.ofPresentationLayer.ofDTO.ofProduct.ofOrderer
{
    [ActorContext(typeof(OrdererContext))]
    public class OrdererProductCenter : ProductCenterDTO
    {
    }
    [ActorContext(typeof(OrdererContext))]
    public class OrdererProducter : ProducterDTO
    {
    }
    [ActorContext(typeof(OrdererContext))]
    public class OrdererProductLand : ProductLandDTO
    {
    }
    [ActorContext(typeof(OrdererContext))]
    public class OrdererPCommodity : PCommodityDTO
    {
    }
    [ActorContext(typeof(OrdererContext))]
    public class OrdererSPCommodity : SPCommodityDTO
    {
    }
    [ActorContext(typeof(OrdererContext))]
    public class OrdererMPCommodity : MPCommodityDTO
    {
    }
    [ActorContext(typeof(OrdererContext))]
    public class OrdererEPCommodity : EPCommodityDTO
    {
    }
}
