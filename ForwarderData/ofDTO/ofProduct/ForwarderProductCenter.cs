using BusinessData.ofPresentationLayer.ofActorContext.ofBusiness;
using BusinessView.ofUser.ofCommon;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessData.ofPresentationLayer.ofDTO.ofProduct.ofForwarder
{
    [ActorContext(typeof(ForwarderContext))]
    public class ForwarderProductCenter : ProductCenterDTO
    {
    }
    [ActorContext(typeof(ForwarderContext))]
    public class ForwarderProducter : ProducterDTO
    {
    }
    [ActorContext(typeof(ForwarderContext))]
    public class ForwarderProductLand : ProductLandDTO
    {
    }
    [ActorContext(typeof(ForwarderContext))]
    public class ForwarderPCommodity : PCommodityDTO
    {
    }
    [ActorContext(typeof(ForwarderContext))]
    public class ForwarderSPCommodity : SPCommodityDTO
    {
    }
    [ActorContext(typeof(ForwarderContext))]
    public class ForwarderMPCommodity : MPCommodityDTO
    {
    }
    [ActorContext(typeof(ForwarderContext))]
    public class ForwarderEPCommodity : EPCommodityDTO
    {
    }
}
