using BusinessData.ofPresentationLayer.ofActorContext.ofBusiness;
using BusinessView.ofUser.ofCommon;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessData.ofPresentationLayer.ofDTO.ofOrder.ofLogister
{
    [ActorContext(typeof(LogisterContext))]
    public class LogisterOrderCenter : OrderCenterDTO
    {
    }
    [ActorContext(typeof(LogisterContext))]
    public class LogisterOCommodity : OCommodityDTO
    {
    }
    [ActorContext(typeof(LogisterContext))]
    public class LogisterSOCommodity : SOCommodityDTO
    {
    }
    [ActorContext(typeof(LogisterContext))]
    public class LogisterMOCommodity : MOCommodityDTO
    {
    }
    [ActorContext(typeof(LogisterContext))]
    public class LogisterEOCommodity : EOCommodityDTO
    {
    }
}
