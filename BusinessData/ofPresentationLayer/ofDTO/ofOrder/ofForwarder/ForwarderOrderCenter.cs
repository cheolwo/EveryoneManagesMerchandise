using BusinessData.ofPresentationLayer.ofActorContext.ofBusiness;
using BusinessView.ofUser.ofCommon;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessData.ofPresentationLayer.ofDTO.ofOrder.ofForwarder
{
    [ActorContext(typeof(ForwarderContext))]
    public class ForwarderOrderCenter : OrderCenterDTO
    {
    }
    [ActorContext(typeof(ForwarderContext))]
    public class ForwarderOCommodity : OCommodityDTO
    {
    }
    [ActorContext(typeof(ForwarderContext))]
    public class ForwarderSOCommodity : SOCommodityDTO
    {
    }
    [ActorContext(typeof(ForwarderContext))]
    public class ForwarderMOCommodity : MOCommodityDTO
    {
    }
    [ActorContext(typeof(ForwarderContext))]
    public class ForwarderEOCommodity : EOCommodityDTO
    {
    }
}
