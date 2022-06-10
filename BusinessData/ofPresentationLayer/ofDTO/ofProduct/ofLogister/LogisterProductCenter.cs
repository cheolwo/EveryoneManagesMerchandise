using BusinessData.ofPresentationLayer.ofActorContext.ofBusiness;
using BusinessView.ofUser.ofCommon;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessData.ofPresentationLayer.ofDTO.ofProduct.ofLogister
{
    [ActorContext(typeof(LogisterContext))]
    public class LogisterProductCenter : ProductCenterDTO
    {
    }
    [ActorContext(typeof(LogisterContext))]
    public class LogisterProducter : ProducterDTO
    {
    }
    [ActorContext(typeof(LogisterContext))]
    public class LogisterProductLand : ProductLandDTO
    {
    }
    [ActorContext(typeof(LogisterContext))]
    public class LogisterPCommodity : PCommodityDTO
    {
    }
    [ActorContext(typeof(LogisterContext))]
    public class LogisterSPCommodity : SPCommodityDTO
    {
    }
    [ActorContext(typeof(LogisterContext))]
    public class LogisterMPCommodity : MPCommodityDTO
    {
    }
    [ActorContext(typeof(LogisterContext))]
    public class LogisterEPCommodity : EPCommodityDTO
    {
    }
}
